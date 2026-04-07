namespace lab_4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Text = "Image Editor";

            // controls
            pictureBox = new PictureBox();
            pictureBox.Location = new Point(220, 12);
            pictureBox.Size = new Size(560, 420);
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            Controls.Add(pictureBox);

            loadButton = new Button();
            loadButton.Text = "Load";
            loadButton.Location = new Point(12, 370);
            loadButton.Size = new Size(180, 40);
            loadButton.Click += LoadButton_Click;
            Controls.Add(loadButton);

            rotateButton = new Button();
            rotateButton.Text = "Rotate";
            rotateButton.Location = new Point(12, 12);
            rotateButton.Size = new Size(180, 40);
            rotateButton.Click += RotateButton_Click;
            Controls.Add(rotateButton);

            invertButton = new Button();
            invertButton.Text = "Invert Colors";
            invertButton.Location = new Point(12, 62);
            invertButton.Size = new Size(180, 40);
            invertButton.Click += InvertButton_Click;
            Controls.Add(invertButton);

            upsideDownButton = new Button();
            upsideDownButton.Text = "Upside Down";
            upsideDownButton.Location = new Point(12, 112);
            upsideDownButton.Size = new Size(180, 40);
            upsideDownButton.Click += UpsideDownButton_Click;
            Controls.Add(upsideDownButton);

            rotate90Radio = new RadioButton();
            rotate90Radio.Text = "90°";
            rotate90Radio.Location = new Point(12, 210);
            rotate90Radio.AutoSize = true;
            Controls.Add(rotate90Radio);

            rotate180Radio = new RadioButton();
            rotate180Radio.Text = "180°";
            rotate180Radio.Location = new Point(12, 235);
            rotate180Radio.AutoSize = true;
            Controls.Add(rotate180Radio);

            rotate270Radio = new RadioButton();
            rotate270Radio.Text = "270°";
            rotate270Radio.Location = new Point(12, 260);
            rotate270Radio.AutoSize = true;
            Controls.Add(rotate270Radio);

            // default selection
            rotate90Radio.Checked = true;


        #endregion
        }
    }
}
