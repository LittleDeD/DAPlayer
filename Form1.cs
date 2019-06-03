using NAudio;
using NAudio.Wave.SampleProviders;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;using TagLib;

namespace Music_Player
{
    public partial class Music : Form
    {
        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;

        public Music()
        {
            InitializeComponent();
            labelLoading.Visible = false;
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Salut", "Play", MessageBoxButtons.YesNoCancel);
        }

        private void LibraryButton_Click(object sender, EventArgs e)
        {
            libraryPanel.Controls.Clear();
            libraryPanel.Visible = false;
            labelLoading.Visible = true;
            int i = 1, c = 1;
            string[] filePaths = Directory.GetFiles(@"D:\Music\Trap\TrapNation", "*.mp3", SearchOption.AllDirectories);
            foreach (string fileSong in filePaths)
            {
                var fileSo = TagLib.File.Create(fileSong);

                //SONG PANEL
                FlowLayoutPanel melody = new FlowLayoutPanel
                {
                    Name = "melody" + i,
                    MaximumSize = new Size(980, 50),
                    Size = new Size(955, 50)
                };
                if (c == 1) { melody.BackColor = Color.Gray; c = 0; }
                else { melody.BackColor = Color.Black; c = 1; }

                //SONG TITLE
                var sN = fileSo.Tag.Title;
                Label songName = new Label
                {
                    Text = Convert.ToString(sN),
                    Size = new Size(300, 25),
                    Margin = new Padding(10, 10, 10, 10),
                    ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF"),
                    Font = new Font("Nirmala UI", 12.0F)
                };

                //SONG ARTIST
                var sA = fileSo.Tag.FirstArtist;
                Label songArtist = new Label
                {
                    Text = Convert.ToString(sA),
                    Size = new Size(250, 25),
                    Margin = new Padding(10, 10, 10, 10),
                    ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF"),
                    Font = new Font("Nirmala UI", 12.0F)
                };

                //SONG YEAR
                Label songYear = new Label
                {
                    Text = Convert.ToString(fileSo.Tag.Year),
                    Size = new Size(50, 25),
                    Margin = new Padding(10, 10, 10, 10),
                    ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF"),
                    Font = new Font("Nirmala UI", 12.0F)
                };

                //SONG GENRE
                var sG = fileSo.Tag.FirstGenre;
                Label songGenre = new Label
                {
                    Text = Convert.ToString(sG),
                    Size = new Size(150, 25),
                    Margin = new Padding(10, 10, 10, 10),
                    ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF"),
                    Font = new Font("Nirmala UI", 12.0F)
                };

                //SONG LENGHT
                Mp3FileReader reader = new Mp3FileReader(fileSong);
                TimeSpan duration = reader.TotalTime;
                Label songLenght = new Label
                {
                    Text = Convert.ToString(duration),
                    Size = new Size(70, 25),
                    Margin = new Padding(10, 10, 10, 10),
                    ForeColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF"),
                    Font = new Font("Nirmala UI", 12.0F)
                };

                melody.Controls.Add(songName);
                melody.Controls.Add(songArtist);
                melody.Controls.Add(songYear);
                melody.Controls.Add(songGenre);
                melody.Controls.Add(songLenght);

                melody.Click += (s, a) =>
                {
                    if (outputDevice == null && audioFile == null)
                    {
                        if (outputDevice == null)
                        {
                            outputDevice = new WaveOutEvent();
                            outputDevice.PlaybackStopped += OnPlaybackStopped;
                        }
                        if (audioFile == null)
                        {
                            audioFile = new AudioFileReader(fileSong);
                            outputDevice
                        }
                    }
                };

                libraryPanel.Controls.Add(melody);
            }

            labelLoading.Visible = false;
            libraryPanel.Visible = true;
            
        }

        private void OnPlaybackStopped(object sender, StoppedEventArgs args)
        {
            outputDevice.Dispose();
            outputDevice = null;
            audioFile.Dispose();
            audioFile = null;
        }
    }
}
