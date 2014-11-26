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

            try
            {
                imgProcessing = preProcessImage(imgOriginal);
                imgOriginal.Draw(findContours(imgProcessing), new Bgr(Color.Red), 3);
                imProcessedView.Image = distinguishObjects(imgProcessing);
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

    }
}
