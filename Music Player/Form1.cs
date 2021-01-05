using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Player
{
    public partial class MusicPlayerApp : Form
    {
        public MusicPlayerApp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //create global variables of string type array to save the titles or name of the tracks and path of the track

        String[] paths, files;

        private void btnSelectSongs_Click(object sender, EventArgs e)
        {
            //code to select songs
            OpenFileDialog ofd = new OpenFileDialog();
            //code to slect multiple files
            ofd.Multiselect = true;

            if(ofd.ShowDialog() ==System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames; //saves the name of the track
                paths = ofd.FileNames; //saves the paths of the tracks

                //display the music title in the list bos
                
                for(int i =0;i<files.Length;i++)
                {
                    ListBoxSongs.Items.Add(files[i]); //display songs in list box
                }

            }
        }

        private void ListBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            //write code to play music

            axWindowsMediaPlayerMusic.URL = paths[ListBoxSongs.SelectedIndex];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //code to close the app

            this.Close();
        }
    }
}
