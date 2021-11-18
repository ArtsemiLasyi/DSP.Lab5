using DSP.Lab5.Api;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSP.Lab5.Presentation
{
    public partial class MainForm : Form
    {
        private bool fragmentLoaded = false;
        private bool originalLoaded = false;

        private Bitmap fragment;
        private Bitmap original;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            Point point = ImageCorrelation.GetCoincidencePoint(fragment, original);
            DrawRectangle(
                new Rectangle(
                    point.X,
                    point.Y,
                    fragment.Width,
                    fragment.Height
                )
            );
        }

        private void FragmentLoadButton_Click(object sender, EventArgs e)
        {
            if (BitmapOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                fragment = new Bitmap(BitmapOpenFileDialog.FileName);
                FragmentPictureBox.Image = fragment;
                FragmentPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

                fragmentLoaded = true;
            }
            CheckLoadings();
        }

        private void OriginalLoadButton_Click(object sender, EventArgs e)
        {
            if (BitmapOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                original = new Bitmap(BitmapOpenFileDialog.FileName);
                OriginalPictureBox.Image = original;
                OriginalPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

                originalLoaded = true;
            }
            CheckLoadings();
        }

        private void CheckLoadings()
        {
            if (originalLoaded && fragmentLoaded)
            {
                CalculateButton.Enabled = true;
            }
        }

        private void DrawRectangle(Rectangle rectangle)
        {
            Graphics graphics = OriginalPictureBox.CreateGraphics();
            graphics.DrawRectangle(
                new Pen(
                    new SolidBrush(Color.Red)
                ),
                rectangle
            );
        }
    }
}
