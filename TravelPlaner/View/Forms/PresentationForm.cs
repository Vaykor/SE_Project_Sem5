using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace TravelPlaner.View.Forms
{
    public partial class PresentationForm : Form
    {
        private Timer timer;
        private string[] images;
        private int currentImageIndex = 0;
        private string baseDirectory = AppContext.BaseDirectory;
        private const string IMAGE_FOLDER_NAME = "Images";

        public PresentationForm(string tripName)
        {
            /*InitializeComponent();
            Text = tripName + " photo memories";

            LoadImages();

            timer = new Timer
            {
                Interval = 5000 // 5 sekund
            };
            timer.Tick += TimerTick;

            if (images.Length > 0)
            {
                photoPresenter.Image = Image.FromFile(images[0]);
                timer.Start();
            }
            else
            {
                MessageBox.Show("Nie znaleziono zdjęć dla wyjazdu.");
            }*/
        }

        private void TimerTick(object sender, EventArgs e)
        {
            /*if (currentImageIndex == (images.Length - 1))
            {
                timer.Stop();
                MessageBox.Show("Koniec pokazu","Koniec", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                currentImageIndex = (currentImageIndex + 1) % images.Length;
                photoPresenter.Image = Image.FromFile(images[currentImageIndex]);
            }*/

        }

        private void LoadImages()
        {
            // For now loading images from folder. In future should be replaced with loading images from data strings saved to database.

            //string imageFolderPath = Path.Combine(baseDirectory, IMAGE_FOLDER_NAME);
            //images = System.IO.Directory.GetFiles(imageFolderPath, "*.png");
        }

    }
}
