namespace MandarineCheck
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imOriginalView = new Emgu.CV.UI.ImageBox();
            this.imProcessedView = new Emgu.CV.UI.ImageBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.shoutBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.trackBar5 = new System.Windows.Forms.TrackBar();
            this.trackBar6 = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.trackBar1val = new System.Windows.Forms.TextBox();
            this.trackBar2val = new System.Windows.Forms.TextBox();
            this.trackBar3val = new System.Windows.Forms.TextBox();
            this.trackBar4val = new System.Windows.Forms.TextBox();
            this.trackBar5val = new System.Windows.Forms.TextBox();
            this.trackBar6val = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.trackBar9val = new System.Windows.Forms.TextBox();
            this.trackBar9 = new System.Windows.Forms.TrackBar();
            this.trackBar8val = new System.Windows.Forms.TextBox();
            this.trackBar8 = new System.Windows.Forms.TrackBar();
            this.trackBar7val = new System.Windows.Forms.TextBox();
            this.trackBar7 = new System.Windows.Forms.TrackBar();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imOriginalView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imProcessedView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar7)).BeginInit();
            this.SuspendLayout();
            // 
            // imOriginalView
            // 
            this.imOriginalView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imOriginalView.Location = new System.Drawing.Point(3, 33);
            this.imOriginalView.Name = "imOriginalView";
            this.imOriginalView.Size = new System.Drawing.Size(480, 360);
            this.imOriginalView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imOriginalView.TabIndex = 2;
            this.imOriginalView.TabStop = false;
            // 
            // imProcessedView
            // 
            this.imProcessedView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imProcessedView.Location = new System.Drawing.Point(489, 33);
            this.imProcessedView.Name = "imProcessedView";
            this.imProcessedView.Size = new System.Drawing.Size(640, 480);
            this.imProcessedView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imProcessedView.TabIndex = 3;
            this.imProcessedView.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1197, 671);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Process";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(376, 412);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 45);
            this.button2.TabIndex = 4;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // shoutBox
            // 
            this.shoutBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.shoutBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoutBox.Location = new System.Drawing.Point(3, 540);
            this.shoutBox.Multiline = true;
            this.shoutBox.Name = "shoutBox";
            this.shoutBox.ReadOnly = true;
            this.shoutBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.shoutBox.Size = new System.Drawing.Size(1126, 164);
            this.shoutBox.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 412);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 45);
            this.button3.TabIndex = 4;
            this.button3.Text = "Load Image";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Original Image:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(486, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Processed Image:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(3, 524);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Output:";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(9, 47);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(180, 45);
            this.trackBar1.TabIndex = 9;
            this.trackBar1.Value = 60;
            this.trackBar1.ValueChanged += new System.EventHandler(this.increaseValue);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(9, 106);
            this.trackBar2.Maximum = 255;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(180, 45);
            this.trackBar2.TabIndex = 9;
            this.trackBar2.Value = 130;
            this.trackBar2.ValueChanged += new System.EventHandler(this.increaseValue);
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(9, 170);
            this.trackBar3.Maximum = 255;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(180, 45);
            this.trackBar3.TabIndex = 9;
            this.trackBar3.ValueChanged += new System.EventHandler(this.increaseValue);
            // 
            // trackBar4
            // 
            this.trackBar4.Location = new System.Drawing.Point(9, 236);
            this.trackBar4.Maximum = 255;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(180, 45);
            this.trackBar4.TabIndex = 9;
            this.trackBar4.Value = 255;
            this.trackBar4.ValueChanged += new System.EventHandler(this.increaseValue);
            // 
            // trackBar5
            // 
            this.trackBar5.Location = new System.Drawing.Point(9, 300);
            this.trackBar5.Maximum = 255;
            this.trackBar5.Name = "trackBar5";
            this.trackBar5.Size = new System.Drawing.Size(180, 45);
            this.trackBar5.TabIndex = 9;
            this.trackBar5.Value = 255;
            this.trackBar5.ValueChanged += new System.EventHandler(this.increaseValue);
            // 
            // trackBar6
            // 
            this.trackBar6.Location = new System.Drawing.Point(9, 362);
            this.trackBar6.Maximum = 255;
            this.trackBar6.Name = "trackBar6";
            this.trackBar6.Size = new System.Drawing.Size(180, 45);
            this.trackBar6.TabIndex = 9;
            this.trackBar6.Value = 18;
            this.trackBar6.ValueChanged += new System.EventHandler(this.increaseValue);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "V";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "S";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "H";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "V";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 284);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "S";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 346);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "H";
            // 
            // trackBar1val
            // 
            this.trackBar1val.Location = new System.Drawing.Point(185, 47);
            this.trackBar1val.Name = "trackBar1val";
            this.trackBar1val.Size = new System.Drawing.Size(33, 20);
            this.trackBar1val.TabIndex = 10;
            this.trackBar1val.Text = "100";
            this.trackBar1val.TextChanged += new System.EventHandler(this.textChanged);
            // 
            // trackBar2val
            // 
            this.trackBar2val.Location = new System.Drawing.Point(185, 106);
            this.trackBar2val.Name = "trackBar2val";
            this.trackBar2val.Size = new System.Drawing.Size(33, 20);
            this.trackBar2val.TabIndex = 10;
            this.trackBar2val.Text = "0";
            this.trackBar2val.TextChanged += new System.EventHandler(this.textChanged);
            // 
            // trackBar3val
            // 
            this.trackBar3val.Location = new System.Drawing.Point(185, 170);
            this.trackBar3val.Name = "trackBar3val";
            this.trackBar3val.Size = new System.Drawing.Size(33, 20);
            this.trackBar3val.TabIndex = 10;
            this.trackBar3val.Text = "0";
            this.trackBar3val.TextChanged += new System.EventHandler(this.textChanged);
            // 
            // trackBar4val
            // 
            this.trackBar4val.Location = new System.Drawing.Point(185, 236);
            this.trackBar4val.Name = "trackBar4val";
            this.trackBar4val.Size = new System.Drawing.Size(33, 20);
            this.trackBar4val.TabIndex = 10;
            this.trackBar4val.Text = "0";
            this.trackBar4val.TextChanged += new System.EventHandler(this.textChanged);
            // 
            // trackBar5val
            // 
            this.trackBar5val.Location = new System.Drawing.Point(185, 300);
            this.trackBar5val.Name = "trackBar5val";
            this.trackBar5val.Size = new System.Drawing.Size(33, 20);
            this.trackBar5val.TabIndex = 10;
            this.trackBar5val.Text = "0";
            this.trackBar5val.TextChanged += new System.EventHandler(this.textChanged);
            // 
            // trackBar6val
            // 
            this.trackBar6val.Location = new System.Drawing.Point(185, 362);
            this.trackBar6val.Name = "trackBar6val";
            this.trackBar6val.Size = new System.Drawing.Size(33, 20);
            this.trackBar6val.TabIndex = 10;
            this.trackBar6val.Text = "0";
            this.trackBar6val.TextChanged += new System.EventHandler(this.textChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(59, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Min HSV range:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(66, 218);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Max HSV range:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.trackBar9val);
            this.panel1.Controls.Add(this.trackBar6val);
            this.panel1.Controls.Add(this.trackBar9);
            this.panel1.Controls.Add(this.trackBar6);
            this.panel1.Controls.Add(this.trackBar8val);
            this.panel1.Controls.Add(this.trackBar5val);
            this.panel1.Controls.Add(this.trackBar8);
            this.panel1.Controls.Add(this.trackBar5);
            this.panel1.Controls.Add(this.trackBar7val);
            this.panel1.Controls.Add(this.trackBar4val);
            this.panel1.Controls.Add(this.trackBar7);
            this.panel1.Controls.Add(this.trackBar4);
            this.panel1.Controls.Add(this.trackBar3val);
            this.panel1.Controls.Add(this.trackBar3);
            this.panel1.Controls.Add(this.trackBar2val);
            this.panel1.Controls.Add(this.trackBar2);
            this.panel1.Controls.Add(this.trackBar1val);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Location = new System.Drawing.Point(1135, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 622);
            this.panel1.TabIndex = 11;
            // 
            // trackBar9val
            // 
            this.trackBar9val.Location = new System.Drawing.Point(185, 559);
            this.trackBar9val.Name = "trackBar9val";
            this.trackBar9val.Size = new System.Drawing.Size(33, 20);
            this.trackBar9val.TabIndex = 10;
            this.trackBar9val.Text = "0";
            // 
            // trackBar9
            // 
            this.trackBar9.Location = new System.Drawing.Point(9, 559);
            this.trackBar9.Maximum = 255;
            this.trackBar9.Name = "trackBar9";
            this.trackBar9.Size = new System.Drawing.Size(180, 45);
            this.trackBar9.TabIndex = 9;
            this.trackBar9.Value = 100;
            this.trackBar9.ValueChanged += new System.EventHandler(this.increaseValue);
            // 
            // trackBar8val
            // 
            this.trackBar8val.Location = new System.Drawing.Point(185, 497);
            this.trackBar8val.Name = "trackBar8val";
            this.trackBar8val.Size = new System.Drawing.Size(33, 20);
            this.trackBar8val.TabIndex = 10;
            this.trackBar8val.Text = "0";
            this.trackBar8val.TextChanged += new System.EventHandler(this.textChanged);
            // 
            // trackBar8
            // 
            this.trackBar8.Location = new System.Drawing.Point(9, 497);
            this.trackBar8.Maximum = 255;
            this.trackBar8.Name = "trackBar8";
            this.trackBar8.Size = new System.Drawing.Size(180, 45);
            this.trackBar8.TabIndex = 9;
            this.trackBar8.Value = 80;
            this.trackBar8.ValueChanged += new System.EventHandler(this.increaseValue);
            // 
            // trackBar7val
            // 
            this.trackBar7val.Location = new System.Drawing.Point(185, 441);
            this.trackBar7val.Name = "trackBar7val";
            this.trackBar7val.Size = new System.Drawing.Size(33, 20);
            this.trackBar7val.TabIndex = 10;
            this.trackBar7val.Text = "0";
            this.trackBar7val.TextChanged += new System.EventHandler(this.textChanged);
            // 
            // trackBar7
            // 
            this.trackBar7.Location = new System.Drawing.Point(9, 437);
            this.trackBar7.Maximum = 255;
            this.trackBar7.Name = "trackBar7";
            this.trackBar7.Size = new System.Drawing.Size(180, 45);
            this.trackBar7.TabIndex = 9;
            this.trackBar7.Value = 150;
            this.trackBar7.ValueChanged += new System.EventHandler(this.increaseValue);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 543);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 13);
            this.label17.TabIndex = 8;
            this.label17.Text = "CannyMax";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 481);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 13);
            this.label16.TabIndex = 8;
            this.label16.Text = "CannyMin";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 418);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "Min Size";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(59, 410);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "[not used] Settings";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1188, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Parameters to tune:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 742);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shoutBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.imProcessedView);
            this.Controls.Add(this.imOriginalView);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Mandarines Quality Check";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imOriginalView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imProcessedView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox imOriginalView;
        private Emgu.CV.UI.ImageBox imProcessedView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox shoutBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.TrackBar trackBar5;
        private System.Windows.Forms.TrackBar trackBar6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox trackBar1val;
        private System.Windows.Forms.TextBox trackBar2val;
        private System.Windows.Forms.TextBox trackBar3val;
        private System.Windows.Forms.TextBox trackBar4val;
        private System.Windows.Forms.TextBox trackBar5val;
        private System.Windows.Forms.TextBox trackBar6val;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox trackBar9val;
        private System.Windows.Forms.TrackBar trackBar9;
        private System.Windows.Forms.TextBox trackBar8val;
        private System.Windows.Forms.TrackBar trackBar8;
        private System.Windows.Forms.TextBox trackBar7val;
        private System.Windows.Forms.TrackBar trackBar7;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label5;
    }
}

