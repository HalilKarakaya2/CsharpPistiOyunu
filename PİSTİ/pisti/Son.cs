using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;

namespace pisti
{
    public partial class Son : Form// bir Windows Forms uygulamasında kullanılan bir sınıfın tanımını göstermektedir. Bu ifade, Son adında bir sınıfın, Form sınıfından türetildiğini belirtir.
    {
        int puan_kull;
        int puan_pcc;
        public Son(int puan_kul,int puan_pc)//genellikle sınıfın özelliklerini (veri alanlarını) başlatmak için kullanılır.
        {
            puan_kull = puan_kul;
            puan_pcc = puan_pc;
            InitializeComponent();
        }

        private void Son_Load(object sender, EventArgs e)// Son_Load adlı bir yöntem, Son adlı bir Form (form) yüklenirken (load) tetiklenir.
        {
            lbl_puan_kul.Text ="Senin Puan: " + puan_kull.ToString();//Bu kod, bir metin kutusuna "Senin Puan: " metnini ve ardından bir değişkenin değerini eklemek için kullanılır.
            lbl_puan_pc.Text = "Rakip Puan: " + puan_pcc.ToString();
            lbl_toplam_puan_kul.Text = Form1.puan_toplam_kul.ToString();
            lbl_toplam_puan_pc.Text = Form1.puan_toplam_pc.ToString();
            //Oyun Kazanıldığında Rütbe görünürlük ayarları
            pictureBox6.Visible = false;//programlama dilinde bir PictureBox nesnesini görünmez hale getirmek için kullanılır.
            pictureBox7.Visible = false;
            label5.Visible = false;
            //Oyun kaybedildiğinda rütbe görünürlük ayarları
                label6.Visible = false;
                pictureBox8.Visible = false;
                pictureBox5.Visible = false;
            label4.Visible = false;
            if (puan_kull > puan_pcc)
            {
                lbl_sonuc.Text = "Bu Eli Kazandın"; 
                lbl_sonuc.ForeColor = Color.Green;
                pictureBox7.Visible = true;// PictureBox nesnesini görünür hale getirmek için kullanılır.
                pictureBox6.Visible =true;
                label5.Visible = true;

                System.Media.SoundPlayer ses = new System.Media.SoundPlayer();//Windows işletim sistemlerinde ses çalmak için kullanılır
                ses.SoundLocation = "Alkış-Sesi.wav";
                ses.Play();
            }
            else if (puan_kull == puan_pcc)//Bu ifade, bir programın belirli bir koşulun sağlanıp sağlanmadığını kontrol etmek için kullanılır.
            {
                lbl_sonuc.Text = "Bu El Berabere";
                lbl_sonuc.ForeColor = Color.LightYellow;
            }
            else
            {
                lbl_sonuc.Text = "Tekrar Dene Rakip Kazandı ";//etkileşimli bir kullanıcı arayüzünde yer alan bir etiketin (label) metin değerini değiştirmek için kullanılmaktadır.
                lbl_sonuc.ForeColor = Color.Red;
                label6.Visible = true;
                label4.Visible = true;
                pictureBox8.Visible = true;
                pictureBox5.Visible = true;

                System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
                ses.SoundLocation = "uzuntulu-muzik-ses-efekti_-_Kopya.wav";
                ses.Play();
            }
        
        }

        private void pictureBox3_Click(object sender, EventArgs e)//Bu kod parçası, bir Windows Forms uygulamasında pictureBox3 adlı bir resim kutusu (PictureBox) öğesine tıklama olayını işlemek için kullanılır.
        {
            Form1.devam_veya_cik = true;//Form1.devam_veya_cik = true; ifadesi, "Form1" adlı bir nesnenin "devam_veya_cik" adlı bir özelliğini true (doğru) değerine atayan bir kod satırıdır.
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)//"pictureBox4" adlı bir PictureBox nesnesi tıklanıldığında gerçekleştirilecek işlemleri tanımlar.
        {
            Form1.devam_veya_cik = false;
            this.Close();
        }

      
    }
}
