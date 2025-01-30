using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelPlaner.Controller;
using TravelPlaner.Model.Classes.Database;
using Timer = System.Windows.Forms.Timer;
using System.IO;
using NAudio.Wave;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace TravelPlaner.View.Forms
{
    public partial class PresentationForm : Form
    {
        private Timer timer;
        private List<string> images;
        private int currentImageIndex = 0;

        private WaveOutEvent waveOut;
        private MediaFoundationReader mediaReader;
        private String songURL;

        public PresentationForm(Trip trip)
        {
            InitializeComponent();
            this.FormClosing += PresentationForm_FormClosing;
            Text = trip.Name + " photo memories";


            images = LoadImages(trip);

            timer = new Timer
            {
                Interval = 5000 // 5 sekund
            };
            timer.Tick += TimerTick;

            if (images.Count > 0)
            {
                photoPresenter.Image = Image.FromFile(images[0]);
                timer.Start();
            }
            else
            {
                MessageBox.Show("Nie znaleziono zdjęć dla wyjazdu.");
            }

            playMusic(trip);
        }

        private void TimerTick(object sender, EventArgs e)
        {
            if (currentImageIndex == (images.Count - 1))
            {
                timer.Stop();
                MessageBox.Show("Koniec pokazu", "Koniec", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                currentImageIndex = (currentImageIndex + 1) % images.Count;
                try
                {
                    photoPresenter.Image = Image.FromFile(images[currentImageIndex]);
                }
                catch
                {

                }
            }

        }

        //Lodaing all photos from a single trip
        private List<string> LoadImages(Trip trip)
        {
            ProgramController controller = new();

            //Getting all tripsegments of a trip
            IEnumerable<int> tripSegmentsOfTrip = controller.GetAllTripSegmentsByTripId(trip.Id).Select(ts => ts.Id);
            List<TripMemory> tripMemories = new List<TripMemory>();


            foreach (int tripSegmentId in tripSegmentsOfTrip)
            {
                tripMemories.AddRange(controller.GetAllTripMemoriesByTripSegmentId(tripSegmentId));
            }


            List<string> tripImages = new List<string>();

            //Get all photos of a trip
            foreach (TripMemory tripMemory in tripMemories)
            {
                if (!string.IsNullOrEmpty(tripMemory.Photo))
                {
                    tripImages.Add(tripMemory.Photo);
                }
            }

            return tripImages;
        }

        private void PresentationForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (images.Count > 0)
            {
                // Reset the index to the first image (0)
                currentImageIndex = 0;

                // Display the first image again
                try
                {
                    photoPresenter.Image = Image.FromFile(images[currentImageIndex]);
                }
                catch
                {
                }

                // Restart the timer
                if (!timer.Enabled)
                {
                    timer.Start();
                }
            }
            else
            {
                MessageBox.Show("Nie znaleziono zdjęć dla wyjazdu.");
            }
        }

        async void playMusic(Trip trip)
        {
            ProgramController controller = new();

            IEnumerable<int> tripSegmentsOfTrip = controller.GetAllTripSegmentsByTripId(trip.Id).Select(ts => ts.Id);
            List<TripMemory> tripMemories = new List<TripMemory>();


            foreach (int tripSegmentId in tripSegmentsOfTrip)
            {
                tripMemories.AddRange(controller.GetAllTripMemoriesByTripSegmentId(tripSegmentId));
            }

            List<string> tripSongs = new List<string>();

            foreach (TripMemory tripMemory in tripMemories)
            {
                if (!string.IsNullOrEmpty(tripMemory.SongURL))
                {
                    tripSongs.Add(tripMemory.SongURL);
                }
            }

            string youtubeUrl = tripSongs.First(); // Replace with your URL
            await PlayYouTubeAudioAsync(youtubeUrl);
        }

        private async Task PlayYouTubeAudioAsync(string videoUrl)
        {
            try
            {
                var youtube = new YoutubeClient();

                // Get the stream manifest
                var streamManifest = await youtube.Videos.Streams.GetManifestAsync(videoUrl);
                var audioStreamInfo = streamManifest.GetAudioOnlyStreams().GetWithHighestBitrate();

                // Download audio to a temp file
                var tempFile = Path.Combine(Path.GetTempPath(), "audio.mp3");
                await youtube.Videos.Streams.DownloadAsync(audioStreamInfo, tempFile);

                // Play audio
                mediaReader = new MediaFoundationReader(tempFile);
                waveOut = new WaveOutEvent();
                waveOut.Init(mediaReader);
                waveOut.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void PresentationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            waveOut?.Stop();
            waveOut?.Dispose();
            mediaReader?.Dispose();
        }
    }
}
