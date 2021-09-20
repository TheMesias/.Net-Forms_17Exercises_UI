using IBM.Cloud.SDK.Core.Authentication.Iam;
using IBM.Watson.TextToSpeech.v1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winapp_TextoVoz
{
    public partial class Form1 : Form
    {
        string key = "";
        string uRl = ""; 
        public Form1()
        {
            
            InitializeComponent();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool dat = false;
       

        private void panel_Superior_MouseDown(object sender, MouseEventArgs e)
        {
            dat = true;
        }

        private void panel_Superior_MouseMove(object sender, MouseEventArgs e)
        {
            if (dat == true)
            {
                this.Location = Cursor.Position;
            }
        }

        private void panel_Superior_MouseUp(object sender, MouseEventArgs e)
        {
            dat = false;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog fileDialog = new SaveFileDialog();
                fileDialog.Filter = "wav Files|*.wav";
                fileDialog.ShowDialog();
                string fname = fileDialog.FileName;

                IamAuthenticator authenticator = new IamAuthenticator(apikey: key);
                TextToSpeechService textToSpeech = new TextToSpeechService(authenticator);
                textToSpeech.SetServiceUrl(uRl);

                var result = textToSpeech.Synthesize
                (
                   text: textBox1.Text,
                   accept: "audio/wav",
                   voice: comboBox1.Text
                );

                using (FileStream fs = File.OpenWrite(fname))
                {
                    result.Result.WriteTo(fs);
                    fs.Close();
                    result.Result.Close();
                }
                MessageBox.Show("Completado");
                axWindowsMediaPlayer1.URL = fname;
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccion el Archivo");
            }
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                IamAuthenticator authenticator = new IamAuthenticator(apikey: key);

                TextToSpeechService textToSpeech = new TextToSpeechService(authenticator);
                textToSpeech.SetServiceUrl(uRl);

                var result = textToSpeech.ListVoices();

                foreach (var voice in result.Result._Voices)
                {
                    comboBox1.Items.Add(voice.Name);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Selecciona la vos");
            }
        }


        
       private void btn_Open_Click(object sender, EventArgs e)
       {
           OpenFileDialog openFileDialog = new OpenFileDialog();
           openFileDialog.Filter = "Text Files|*.txt";
           openFileDialog.ShowDialog();
           string fname = openFileDialog.FileName;

           StreamReader streamReader = new StreamReader(fname);
           textBox1.Text = streamReader.ReadToEnd();
           streamReader.Close();

       }
    }
}
