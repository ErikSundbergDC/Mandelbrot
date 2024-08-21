using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projektarbete
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CreateImage()
        {
            //Skapa ett objekt av vår egen klass ImageCreator. 
            //Använd samma storlek som vår PictureBox, dvs 600x600 pixels.
            ImageCreator imageCreator = new ImageCreator(pictureBox1.Width, pictureBox1.Height);
            //Anropa metoden CreateBmpImage() som skapar en bitmap.
            Bitmap bitmap;

            bitmap = imageCreator.CreateBmpImage();

            //Skapa ett grafikobjekt som är kopplat till vår PictureBox.
            Graphics graphics = pictureBox1.CreateGraphics();
            //Rita ut bitmapen på grafikobjektet så att det syns på skärmen.
            graphics.Clear(Color.Black);
            graphics.DrawImage(bitmap, 0, 0);

        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            //När man klickar på knappen anropas metoden CreateImage()
            CreateImage();
        }

    }
}
