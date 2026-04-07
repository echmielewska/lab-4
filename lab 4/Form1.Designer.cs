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

            onlyGreenButton = new Button();
            onlyGreenButton.Text = "Only Green";
            onlyGreenButton.Location = new Point(12, 162);
            onlyGreenButton.Size = new Size(180, 40);
            onlyGreenButton.Click += OnlyGreenButton_Click;
            Controls.Add(onlyGreenButton);

        #endregion
        }
    }
}
