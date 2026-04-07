namespace lab_4
{
    public partial class Form1 : Form
    {
        // UI controls added in designer
        private PictureBox pictureBox;
        private Button loadButton;


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
    }
}
