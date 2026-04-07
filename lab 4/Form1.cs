namespace lab_4
{
    public partial class Form1 : Form
    {
        // UI controls added in designer
        private PictureBox pictureBox;
        private Button loadButton;
        private Button onlyGreenButton;


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

    }
}
