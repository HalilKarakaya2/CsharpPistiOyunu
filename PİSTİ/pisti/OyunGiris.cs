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
    public partial class Form2 : Form// "Form2" adında bir formun tanımını içerir.
    {
        public Form2()
        {
            InitializeComponent();//Forms uygulamasının bileşenlerini başlatan ve yerleşik oluşturucuyu çalıştıran bir metotdur
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1geciz = new Form1();//Form1 sınıfından bir nesne oluşturmayı sağlar.
            form1geciz.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {
           
           Rutbeler rutbelergeciz = new Rutbeler();
            rutbelergeciz.Show();
        }
    }
}
