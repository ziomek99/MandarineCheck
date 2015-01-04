using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.UI;

namespace MandarineCheck
{
    public partial class Form1 : Form
    {
        Capture capWebcam = null;  
        bool blnCapturingInProcess = false;
        Image<Bgr, Byte> imgOriginal;
        Image<Gray, Byte> imgProcessed;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            trackBar1val.Text = trackBar1.Value.ToString();
            trackBar2val.Text = trackBar2.Value.ToString();
            trackBar3val.Text = trackBar3.Value.ToString();
            trackBar4val.Text = trackBar4.Value.ToString();
            trackBar5val.Text = trackBar5.Value.ToString();
            trackBar6val.Text = trackBar6.Value.ToString();
            trackBar7val.Text = trackBar7.Value.ToString();
            trackBar8val.Text = trackBar8.Value.ToString();
            trackBar9val.Text = trackBar9.Value.ToString();
            
            /*
            try
            {
                capWebcam = new Capture();  // associate capture object to the default webcam
            } catch (NullReferenceException except)
            {
                shoutBox.Text = except.Message;
                return;
            }

            Application.Idle += processFrameAndUpdateGUI;
            blnCapturingInProcess = true;
             */
        }

        private void Form1_formClosed(object sender, FormClosedEventArgs e)
        {
            if (capWebcam != null)
            {
                capWebcam.Dispose();
            }
        }

        void processFrameAndUpdateGUI(object sender, EventArgs e)
        {
            imgOriginal = capWebcam.QueryFrame();
            if (imgOriginal == null) return;

            //imgProcessed = imgOriginal.InRange(new Bgr(20, 20, 105), new Bgr(100, 100, 256));
            doProcessing();
            imOriginalView.Image = imgOriginal;
            imProcessedView.Image = imgProcessed;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            imgOriginal = new Image<Bgr, Byte>(openFileDialog1.FileName);
            imOriginalView.Image = imgOriginal;
            doProcessing();
            //doKMeansProcessing();
            //imOriginalView.Image = drawCircles(imgProcessed, imgOriginal);

            /*
            if(blnCapturingInProcess)
            {
                Application.Idle -= processFrameAndUpdateGUI;
                blnCapturingInProcess = false;
                button1.Text = "Resume";
            }
            else
            {
                Application.Idle += processFrameAndUpdateGUI;
                blnCapturingInProcess = true;
                button1.Text = "Pause";
            }
             */
            
        }

        /// <summary>
        /// Function to process the images
        /// </summary>
        void doProcessing()
        {
            Image<Gray, Byte> imgProcessing;
            int nrOfLeaves = 0;
            try
            {
                //Copying image to process
                imgProcessing = preProcessImage(imgOriginal);
                imgOriginal.Draw(findContours(imgProcessing), new Bgr(Color.Red), 3);
                nrOfLeaves = countLeafContours(imgProcessing);
                imProcessedView.Image = distinguishObjects(imgProcessing);

                //counting leaves
                if (nrOfLeaves == 1)
                    shoutBox.AppendText("(1 leaf)\n");
                else if (nrOfLeaves !=0)
                    shoutBox.AppendText("Broken mandarine, nr of leaves: " + nrOfLeaves.ToString() + "\n");

                //Contour<Point> contours = imgProcessing.FindContours();
                //imProcessedView.Image = imgProcessing.Draw(, new Bgr(Color.Red), 3);
            }
            catch (NullReferenceException)
            {
                imProcessedView.Image = null;
            }
            
        }

        void doKMeansProcessing()
        {
            Image<Bgr, float> imgProcessing;

            try
            {
                imgProcessing = segmentColors(imgOriginal);
                //imgOriginal.Draw(imgProcessing.FindContours(), new Bgr(Color.Green), 3);
                imProcessedView.Image = imgProcessing;
                //imProcessedView.Image = distinguishObjects(imgProcessing);
            }
            catch (NullReferenceException)
            {
                imProcessedView.Image = null;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg";
            openFileDialog1.Title = "Select Image File";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imgOriginal = new Image<Bgr, Byte>(openFileDialog1.FileName);
                imOriginalView.Image = imgOriginal;
                shoutBox.AppendText("File: " + openFileDialog1.SafeFileName + " loaded.\n");
                doProcessing();
                
                //imProcessedView.Image = imgProcessed;
                //imOriginalView.Image = drawCircles(imgProcessed, imgOriginal);
            }

        }

        private int countLeafContours(Image<Gray, byte> imgToProcess)
        {
            if (imgToProcess == null) return -1;
            Contour<Point> maxCont;
            int nrOfContours = 0;
            //looking for contours on the image
            maxCont = findContours(imgToProcess);

            //imgToProcess.ROI = maxCont.BoundingRectangle;

            Contour<Point> contours = imgToProcess.FindContours();

            try
            {
                while (contours != null)
                {
                    Contour<Point> currentContour = contours.ApproxPoly(2.0);

                    if ((currentContour.BoundingRectangle.Height > 15) && (currentContour.BoundingRectangle.Width < 50))
                    {
                        nrOfContours++;
                        //CvInvoke.cvDrawContours(imgToProcess, contours, new MCvScalar(255), new MCvScalar(255), -1, 2, Emgu.CV.CvEnum.LINE_TYPE.EIGHT_CONNECTED, new Point(0, 0));

                        //Drawing found contours
                        //imgOriginal.ROI = imgToProcess.ROI;
                        //imgOriginal.Draw(currentContour.BoundingRectangle, new Bgr(Color.Blue), 3);
                    }
                    contours = contours.HNext;
                }
            }
            catch (NullReferenceException)
            {
                return -1;
            }

            return nrOfContours;
        }


        /// <summary>
        /// Function to distinguish between mandarines and other objects
        /// </summary>
        /// <param name="imgToProcess"></param>
        /// <returns></returns>
        private Image<Gray, Byte> distinguishObjects(Image<Gray, byte> imgToProcess)
        {
            Contour<Point> maxCont;
            Double circularity;

            if (imgToProcess == null) return null;
            //looking for contours on the image
            maxCont = findContours(imgToProcess);

            //filling the contours white
            imgToProcess.FillConvexPoly(maxCont.ToArray(), new Gray(255));

            //setting the region of the interest to the bounding rectangle
            imgToProcess.ROI = maxCont.BoundingRectangle;
            
            circularity = maxCont.Area*4*Math.PI/(Math.Pow(maxCont.Perimeter, 2));

            //checking circularity
            shoutBox.AppendText((circularity).ToString() + "\n");

            //counting leafs
            
            if (circularity > 0.79)
            {
                shoutBox.AppendText("Mandarine!!!\n");
                return imgToProcess; 
            }
            shoutBox.AppendText("Not mandarine/broken mandarine\n");

            return imgToProcess;

        }

        /// <summary>
        /// Preprocessing image to binary image based on color range
        /// </summary>
        /// <param name="imgToProcess"></param>
        /// <returns></returns>
        private Image<Gray, Byte> preProcessImage(Image<Bgr, byte> imgToProcess)
        {
            int minV = trackBar1.Value, minH = trackBar3.Value, minS = trackBar2.Value;
            int maxV = trackBar4.Value, maxH = trackBar6.Value, maxS = trackBar5.Value;
            
            int cannyThresh = trackBar7.Value;
            int circleAccum = trackBar8.Value, threshLink = trackBar9.Value;

            Image<Gray, Byte> imagePreProcessed;
            Image<Bgr, Byte> imageSmoothed;
            Image<Hsv, Byte> imageHsv;
            if (imgToProcess == null) return null;

            //Smoothing image
            imageSmoothed = imgToProcess.PyrDown().PyrUp();
            imageSmoothed._SmoothGaussian(3);

            //Converting to HSV
            imageHsv = imgToProcess.Convert<Hsv, Byte>();

            //Binarization based on colors
            imagePreProcessed = imageHsv.InRange(new Hsv(minH, minS, minV), new Hsv(maxH, maxS, maxV));

            imagePreProcessed = imagePreProcessed.PyrDown().PyrUp();
            imagePreProcessed._SmoothGaussian(3);

            return imagePreProcessed;            
        }

        private Image<Bgr, float> segmentColors(Image<Bgr, byte> imgToProcess)
        {
            Bgr[] clusterColors = new Bgr[]
            {
                    new Bgr(255, 255, 255),
                    new Bgr(0,128,255),
                    new Bgr(255, 100, 100),
                    new Bgr(255,0,255),
                    new Bgr(133,0,99),
                    new Bgr(130,12,49),
                    new Bgr(0, 255, 255)
            };

            int minV = trackBar1.Value, minH = trackBar3.Value, minS = trackBar2.Value;
            int maxV = trackBar4.Value, maxH = trackBar6.Value, maxS = trackBar5.Value;

            int cannyThresh = trackBar7.Value;
            int circleAccum = trackBar8.Value, threshLink = trackBar9.Value;

            Image<Bgr, Byte> imagePreProcessed;
            if (imgToProcess == null) return null;

            //imagePreProcessed = imgToProcess.PyrDown().PyrUp();
            imagePreProcessed = imgToProcess;

            Matrix<float> samples = new Matrix<float>(imagePreProcessed.Rows * imagePreProcessed.Cols, 1, 3);
            Matrix<int> finalClusters = new Matrix<int>(imagePreProcessed.Rows * imagePreProcessed.Cols, 1);
            int clusterCount = 2; 
            for (int y = 0; y < imagePreProcessed.Rows; y++)
            {
                for (int x = 0; x < imagePreProcessed.Cols; x++)
                {                    
                    samples.Data[y + x * imagePreProcessed.Rows, 0] = (float)imagePreProcessed[y, x].Blue;
                    samples.Data[y + x * imagePreProcessed.Rows, 1] = (float)imagePreProcessed[y, x].Green;
                    samples.Data[y + x * imagePreProcessed.Rows, 2] = (float)imagePreProcessed[y, x].Red;
                }
            }
            MCvTermCriteria crit = new MCvTermCriteria(5);

            CvInvoke.cvKMeans2(samples, clusterCount, finalClusters, crit, 3, IntPtr.Zero, KMeansInitType.PPCenters, IntPtr.Zero, IntPtr.Zero);
            Image<Bgr, float> new_image = new Image<Bgr, float>(imagePreProcessed.Size);

            for (int y = 0; y < imagePreProcessed.Rows; y++)
            {
                for (int x = 0; x < imagePreProcessed.Cols; x++)
                {
                    PointF p = new PointF(x, y);
                    new_image.Draw(new CircleF(p, 1.0f), clusterColors[finalClusters[y + x * imagePreProcessed.Rows, 0]], 1);
                }
            }
            return new_image;
        }

        /// <summary>
        /// Looking for contours on the image
        /// </summary>
        /// <param name="imgFromDraw"></param>
        /// <returns></returns>
        private Contour<Point> findContours(Image<Gray, Byte> imgFromDraw)
        {
            Contour<Point> contours = imgFromDraw.FindContours();
            Contour<Point> maxContour; 

            try
            {
                maxContour = contours.ApproxPoly(2.0);
                while (contours != null)
                {
                    Contour<Point> contour = contours.ApproxPoly(2.0);

                    if (contour.Area > 1000)
                    {
                        //if (contour.Total > 6)
                        if (contour.Area >= maxContour.Area)
                            maxContour = contour;
                    }
                    contours = contours.HNext;
                }
            }
            catch (NullReferenceException)
            {
                return null;
            }

            return maxContour;
        }

        /// <summary>
        /// Function for drawing circles
        /// </summary>
        /// <param name="imgFromDraw"></param>
        /// <param name="imgToDraw"></param>
        /// <returns></returns>
        private IImage drawCircles(Image<Gray, Byte> imgFromDraw, Image<Bgr, byte> imgToDraw)
        {
            int minSize = trackBar7.Value;
            int minCanny = trackBar8.Value, maxCanny = trackBar9.Value;

            if (imgFromDraw == null) return null;

            CircleF[] circles = imgFromDraw.HoughCircles(new Gray(maxCanny), //Canny threshold
                new Gray(minCanny), //accumulator threshold
                2, //size of image / this param = accum resolution
                imgFromDraw.Height/2, //min distance of circles
                minSize,
                500)[0];
            foreach (CircleF circle in circles)
            {
                CvInvoke.cvCircle(imgToDraw, new Point((int)circle.Center.X, (int)circle.Center.Y), (int)circle.Radius, new MCvScalar(255), 4, LINE_TYPE.CV_AA, 0);
            }

            return imgToDraw;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void increaseValue(object sender, EventArgs e)
        {
            TrackBar track = sender as TrackBar;

            foreach (Control c in panel1.Controls)
            {
                TextBox text = c as TextBox;
                if (text != null)
                {
                    if (text.Name.Equals((track).Name.ToString() + "val"))
                        text.Text = track.Value.ToString();
                }
                
            }
            //trackBar1val.Text = (track).Value.ToString();
        }

        private void textChanged(object sender, EventArgs e)
        {
            TextBox text = sender as TextBox;

            foreach (Control c in panel1.Controls)
            {
                TrackBar trackBarVal = c as TrackBar;
                if (trackBarVal != null && text.Text != "")
                {
                    if (text.Name.Equals((trackBarVal).Name.ToString() + "val"))
                        trackBarVal.Value = int.Parse(text.Text);
                }

            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
