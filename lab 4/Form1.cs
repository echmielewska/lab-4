namespace lab_4
{
    public partial class Form1 : Form
    {
        // UI controls added in designer
        private PictureBox pictureBox;
        private Button loadButton;

        private Button onlyGreenButton;

        private Button rotateButton;
        private Button invertButton;
        private Button upsideDownButton;


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

        private void OnlyGreenButton_Click(object? sender, EventArgs e)
        {
            if (currentBitmap == null) return;
            KeepOnlyGreen(currentBitmap);
            pictureBox.Refresh();
        }

        private void KeepOnlyGreen(Bitmap bmp)
        {
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    var c = bmp.GetPixel(x, y);
                    // classify as green if G is strictly greater than R and B
                    if (c.G > c.R && c.G > c.B)
                    {
                        // keep original
                    }
                    else
                    {
                        bmp.SetPixel(x, y, Color.Black);
                    }
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
        private void InvertButton_Click(object? sender, EventArgs e)
        {
            if (currentBitmap == null) return;
            InvertColors(currentBitmap);
            pictureBox.Refresh();
        }

        private void UpsideDownButton_Click(object? sender, EventArgs e)
        {
            if (currentBitmap == null) return;
            currentBitmap.RotateFlip(RotateFlipType.RotateNoneFlipY);
            pictureBox.Refresh();
        }

        private void InvertColors(Bitmap bmp)

        {
            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    var c = bmp.GetPixel(x, y);

                    // classify as green if G is strictly greater than R and B
                    if (c.G > c.R && c.G > c.B)
                    {
                        // keep original
                    }
                    else
                    {
                        bmp.SetPixel(x, y, Color.Black);
                    }

                    var nc = Color.FromArgb(c.A, 255 - c.R, 255 - c.G, 255 - c.B);
                    bmp.SetPixel(x, y, nc);

                }
            }
        }


    }
}
