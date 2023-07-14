using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pisti
{
    public partial class giris : Form
    {
        public enum DifficultyLevel
        {
            Acemi,
            Kolay,
            Orta,
            Zor,
            Usta
        }
        public giris()
        {

            InitializeComponent();
        }
        private DifficultyLevel currentDifficulty;

        public void SetDifficulty(DifficultyLevel difficulty)//SetDifficulty metodu, bir zorluk seviyesi belirlemek için kullanılan bir fonksiyondur.
        {
            currentDifficulty = difficulty;//Bu ifade, bir programlama dilinde değişken atamasını ifade eder. 
        }



        private void button1_Click(object sender, EventArgs e)
            //        BÖLÜMLER (ZORLUK SEVİYELERİ)
        {

            Form1.max_el = Convert.ToInt32(textBox1.Text);
            this.Close();
        }

        private void mainGameTimer(object sender, EventArgs e)
        {
            switch (currentDifficulty)
            {
                case DifficultyLevel.Acemi:
                    // Acemi seviye için oyun ayarları
                    break;
                case DifficultyLevel.Kolay:
                    // Kolay seviye için oyun ayarları
                    break;
                case DifficultyLevel.Orta:
                    // Orta seviye için oyun ayarları
                    break;
                case DifficultyLevel.Zor:
                    // Zor seviye için oyun ayarları
                    break;
                case DifficultyLevel.Usta:
                    // Usta seviye için oyun ayarları
                    break;

            }
        }

        private void giris_Load(object sender, EventArgs e)//Bu kod parçası, bir Windows Forms uygulamasındaki bir formun yüklenme olayını (event) işler
        {

            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
            ses.SoundLocation = "relaxing-birds-and-piano-music-137153.wav";
            ses.Play();
        }
    }
}
