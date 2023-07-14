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
    public partial class Rutbeler : Form//"Rutbeler" adlı sınıf, bir Windows Forms uygulamasının bir parçasıdır. 
    {
        public Rutbeler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();// pencere veya diğer kullanıcı arayüzü bileşenlerinin kapatılması veya yok edilmesi amacıyla kullanılır.
        }
    }
}
