namespace lab_4
{
    public partial class Form1 : Form
    {
        // UI controls added in designer
        private PictureBox pictureBox;
        private Button loadButton;
        private Button rotateButton;

        private RadioButton rotate90Radio;
        private RadioButton rotate180Radio;
        private RadioButton rotate270Radio;



        private Bitmap? currentBitmap;

        public Form1()
        {
            InitializeComponent();
        }

        private void LoadButton_Click(object? sender, EventArgs e)
        {
            using var ofd = new OpenFileDialog();
            ofd.Filter = "Bitmap files (*.bmp)|*.bmp|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var bmp = (Bitmap)Image.FromFile(ofd.FileName);
                    currentBitmap?.Dispose();
                    currentBitmap = new Bitmap(bmp);
                    pictureBox.Image = currentBitmap;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load image: " + ex.Message);
                }
            }
        }

        private void RotateButton_Click(object? sender, EventArgs e)
        {
            if (currentBitmap == null) return;
            if (rotate90Radio.Checked)
                currentBitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
            else if (rotate180Radio.Checked)
                currentBitmap.RotateFlip(RotateFlipType.Rotate180FlipNone);
            else if (rotate270Radio.Checked)
                currentBitmap.RotateFlip(RotateFlipType.Rotate270FlipNone);

            pictureBox.Image = currentBitmap;
            pictureBox.Refresh();
        }

    }
}
