using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Media;

namespace pisti
{
    public partial class Form1 : Form

    {
        private Random random;
        public Form1()
        {
            puan_kullanici = 0;
            puan_rakip = 0;
            kartlar = new List<kart>();
            InitializeComponent();
            random = new Random();
        }
        //Tanımlamalar
        Image resim;
        List<kart> kartlar;
        List<kart> kartlar_aktif;
        List<kart> ortadaki_kartlar;
        kart en_son_atilan_kart;
        int kart_sayisi_toplam;
        int kart_sayisi_kullanici;
        int kart_sayisi_rakip;
        int kart_sayisi_orta;
        bool sira_bende = true;
        int puan_kullanici;
        int puan_rakip;
        Thread th1;
        bool oyun_acik;
        bool is_ben_aldm;
        bool wait;
        Image desen;
        PictureBox anim_kart;
        bool anim_run;
        bool anim_card_run;
        Image back_ground_card;
        Image pisti_a;
        Image pisti_b;
        int a;
        string komut = "devam";
        public static int puan_toplam_kul;
        public static int puan_toplam_pc;
        public static bool devam_veya_cik;
        int el;
        public static int max_el;
        public static int zorluk;
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start(); 
            label1.UseCompatibleTextRendering = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Text = "PİŞTİ OYUNU";
            label1.Padding = new Padding(2);
            label1.AutoSize = false;

            label1.Font = new Font(label1.Font.FontFamily, label1.Font.Size + 20);
            Label shadowLabel = new Label();
            shadowLabel.ForeColor = Color.FromArgb(50, 10, 0, 0); // Siyah renkte bir gölge
            shadowLabel.Font = new Font(label1.Font.FontFamily, 12, FontStyle.Bold);
            shadowLabel.Location = new Point(label1.Left + 2, label1.Top + 2);
            shadowLabel.Size = label1.Size;
            shadowLabel.Text = label1.Text;
            shadowLabel.Padding = label1.Padding;
            shadowLabel.TextAlign = label1.TextAlign;
            shadowLabel.BackColor = Color.Transparent;

            // Gölgelendirme Label'ı form üzerine eklenir
            this.Controls.Add(shadowLabel);
            label1.ForeColor = Color.Red;
            label1.Font = new Font(label1.Font, FontStyle.Bold);
            button1.Font = new Font(button1.Font, FontStyle.Bold);
            button2.Font = new Font(button2.Font, FontStyle.Bold);
           

            a = Convert.ToInt32(pcb_pisti.Tag);
           pcb_pisti.Visible = false;
            string file_n = "";
            try
            {
                file_n = "pisti_1.png"; //file_n değişkenine "pisti_1.png" değeri atanır. Bu, yüklemek istediğiniz görüntü dosyasının adını temsil eder.Metodu, belirtilen dosya yolundaki görüntüyü Image nesnesi olarak döndürür.
                pisti_a = Image.FromFile(@"pisti_1.png");
                file_n = "pisti_2.png";
                pisti_b = Image.FromFile(@"pisti_2.png");//file_n değişkenine "pisti_2.png" değeri atanır. Bu, yüklemek istediğiniz görüntü dosyasının adını temsil eder.Metodu, belirtilen dosya yolundaki görüntüyü Image nesnesi olarak döndürür.
                this.WindowState = FormWindowState.Maximized;
                file_n = "cards.png";//file_n değişkenine "cards.png" değeri atanır. Bu, yüklemek istediğiniz görüntü dosyasının adını temsil eder.Metodu, belirtilen dosya yolundaki görüntüyü Image nesnesi olarak döndürür.
                back_ground_card = Image.FromFile(@"cards.png");
                wait = false;
                file_n = "desen.jpg";//file_n değişkenine "desen.jpg" değeri atanır. Bu, yüklemek istediğiniz görüntü dosyasının adını temsil eder.Metodu, belirtilen dosya yolundaki görüntüyü Image nesnesi olarak döndürür.
                back_ground_card = Image.FromFile(@"cards.png");
                desen = Image.FromFile(@"desen.jpg");
                timer1.Start();
                file_n = "";
                Control.CheckForIllegalCrossThreadCalls = false;//başka bir thread üzerinden denetimlere erişimde hata oluşması engellenir. 
                file_n = "kartlar.png";////file_n değişkenine "kartlar.png" değeri atanır. Bu, yüklemek istediğiniz görüntü dosyasının adını temsil eder.Metodu, belirtilen dosya yolundaki görüntüyü Image nesnesi olarak döndürür.
                resim = Image.FromFile(@"kartlar.png");
                pcb_cards.BackgroundImage = desen;
                file_n = "";
            }
            catch(Exception ex)
            {
                if (file_n != "")                                   //
                {
                    MessageBox.Show(file_n + " Dosyası bulunamadı");// Bu kod bloğu, file_n değişkeninin durumunu kontrol eder ve buna bağlı olarak kullanıcıya uygun bir mesaj gösterir. 
                }
                else                                                //
                {
                    MessageBox.Show(ex.Message);                    //
                }
            }
        }
        public void rakip_kontrol()
        {
            while (true)
            {
                
                    Application.DoEvents();     //
                    if (komut == "bekle")      //
                    {
                        Application.DoEvents();//
                        Thread.Sleep(700);     // Bu kod bloğu, belirli durumlarda işlemi duraklatmak ve olayları işlemek için kullanılır. 
                    pcb_pisti.Visible = false; //
                    }
                    else if (komut == "sayi")  //
                    {
                        Thread.Sleep(300);     //
                    }
                    
                    komut = "a";
                    if (sira_bende == false && anim_run == false && wait == false) //Bu kod, komut değişkeninin değerini kontrol eder ve belirli bir koşulu kontrol ederek işlem yapar.
                {
                        bool kart_atti = false;           //   Bu kod, panel3 adındaki bir panele sahip olan denetimleri döngüyle dolaşarak belirli bir işlem yapmayı sağlar.
                    foreach (Control s in panel3.Controls)//
                        {
                            int num = Convert.ToInt32(s.Tag.ToString().Split(';')[0]);//
                            if (en_son_atilan_kart.numara == num)                     // Bu kodlar, bir denetimin etiketinden alınan değeri parçalayarak bir sayı elde eder. Ardından, en_son_atilan_kart adında bir nesnenin numara özelliğiyle elde edilen sayıyı karşılaştırır.
                        {
                                PictureBox resimd = (PictureBox)s; //
                                resimd.Location = new Point(0, 0); //  Bu kodlar s değişkeninin bir PictureBox nesnesine dönüştürülmesini sağlar. Daha sonra, resimd adında bir PictureBox değişkenine bu dönüştürülmüş nesne atanır.
                            panel3.Controls.Remove(resimd);    // 

                                resimd.BringToFront();                //Bu kodlar iki işlemi gerçekleştirir
                            resimd.Image = resimd.BackgroundImage;//


                                kart_atti = true;             //
                                kart_sayisi_rakip--;         //Bu kodlar  değişkenleri günceller, bir metod çağırır ve döngüyü sonlandırarak belirli bir durumu veya işlemi yönetmeyi amaçlar
                            wait = true;                // 
                                animasyon(ref resimd, new Point(panel3.Location.X + resimd.Size.Width, panel3.Location.Y));//
                                break;
                            }
                        }
                        if (kart_atti == true)// Koşul doğru ise belirli bir kod bloğunu çalıştırır.
                    {
                            continue;
                        }
                        else
                        {
                            Random rast = new Random();
                            int ax = rast.Next(0, panel3.Controls.Count);//Rastgele bir tam sayı üretir
                        PictureBox resimd = (PictureBox)panel3.Controls[ax];//indeksteki kontrolü PictureBox türüne dönüştürmek ve daha sonra bu kontrolü resimd değişkeninde kullanmak için kullanılır.
                        resimd.Location = new Point(0, 0);// resimd kontrolünün konumunu (0, 0) koordinatlarına ayarlamak için kullanılır.
                        panel3.Controls.Remove(resimd);// Panel3.Controls koleksiyonundan resimd kontrolünü çıkarmak için kullanılır.

                        resimd.BringToFront();                        // Bu kodlar Resimd kontrolünü diğer kontrollerin önüne getirir ve ardından kontrolün görüntüsünü arka plan görüntüsüyle aynı hale getirir.
                        resimd.Image = resimd.BackgroundImage;    //


                            kart_atti = true;               //
                            kart_sayisi_rakip--;           //Bu kodlar kartın atıldığını belirtmek, rakibin elindeki kart sayısını azaltmak, beklemeyi başlatmak ve animasyonlu bir şekilde kartı hedef konuma taşımak gibi işlemleri gerçekleştirir.
                        wait = true;                   //
                            animasyon(ref resimd, new Point(panel3.Location.X + resimd.Size.Width, panel3.Location.Y));//

                        }
                    }
                
            }
        }
        private void animasyon(ref PictureBox kart, Point konum)
        {
            anim_run = true;          //
            kart.Location = konum;  //
            pnl_arka.Controls.Add(kart); // Bu kodlar animasyonun başlaması için gerekli ayarları yapar ve kartın belirli bir hedef konuma animasyonlu olarak taşınmasını sağlar.
            anim_kart = kart;         //
            timer2.Start();         //
        }
        private int puanla(bool is_oyun_acik = true)
        {
            int puan = 0;
            
                if (is_oyun_acik == false) // Oyunun başlatılmasına veya başlatma durumuna bağlı olarak belirli bir kod bloğunu çalıştırmanızı sağlar.
            {
                    puan = puan + 3;
                }
                if (ortadaki_kartlar.Count == 2 && (ortadaki_kartlar[0].numara == ortadaki_kartlar[1].numara))//
                {
                    komut = "bekle";                        //
                    if (ortadaki_kartlar[0].numara == 11)  //
                    { 
                        ortayı_temizle();                  //
                        return puan+20;                    //Bu kod blokları, kart oyunu veya benzeri bir senaryoda kullanılabilir. İki kartın aynı numaraya sahip olduğu durumu kontrol ederek, eylemin gerçekleştirmenizi sağlar.
                }
                    pcb_pisti.Visible = true;              //
                    
                    ortayı_temizle();                      //
                    return puan+10;                        //
                }
                else
                {
                    komut = "sayi";
                    foreach (var item in ortadaki_kartlar)//
                    {
                        if (item.numara == 1)//
                        {
                            puan++; //
                        }
                        else if (item.numara == 11) //
                        {
                            puan++;                          //Bu kodlar" ortadaki_kartlar "koleksiyonundaki kartların özelliklerine göre puanlama yapmak için kullanılır.
                    }
                        else if (item.numara == 2 && item.sembol == 0)//
                        {
                            puan = puan + 2;//
                        }
                        else if (item.numara == 10 && item.sembol == 3)//
                        {
                            puan = puan + 3;//
                        }
                    }

                }
                
                ortayı_temizle();
         

            return puan;
        }
        private void ortayı_temizle()
        {
            if (ortadaki_kartlar != null)//Bu kod ortadaki_kartlar değişkeninin null olup olmadığını kontrol eder.
            {
                ortadaki_kartlar.Clear(); //ortadaki_kartlar.Clear() kodu, ortadaki_kartlar listesini temizler. Yani, listedeki tüm öğeleri kaldırır ve liste boş bir duruma getirir.
            }
            panel2.Controls.Clear(); //Bu kodu kullanarak panel2 kontrolü altındaki tüm öğeleri temizleyebilir ve kontrolü boş bir duruma getirebiliriz.
            panel2.BackgroundImage = null; //Bu kodu kullanarak panel2 kontrolünün arka plan görüntüsünü sıfırlayabilir ve kontrolün arka planını temizleyebiliriz. 
            en_son_atilan_kart = new kart();//Bu kodu kullanarak en_son_atilan_kart değişkenine yeni bir kart atayabilir ve daha sonra bu kartı kullanabiliriz.
            en_son_atilan_kart.numara = -1;//Bu kodu kullanarak en_son_atilan_kart nesnesinin numara özelliğine -1 değerini atayabilir ve bu değeri daha sonra kullanabiliriz.
        }
        public void kiside_kart_yok()
        {
            if (panel3.Controls.Count == 0 && panel1.Controls.Count == 0)//Bu kod her iki panelin de boş olduğu bir durumu kontrol etmek için kullanılabilir ve belirli bir eylem veya işlemi gerçekleştirmeniz gereken durumları işaretleyebilir.
            {
                kartlari_dagıt();
            }
        }
        public void oyun_bitir()
        { 
        
        }
        public void kartlari_parcala()
        {
            Bitmap bmp_res = new Bitmap(resim);
            int w = 73;
            int h = 98;
            for (int x = 0; x < 13; x++) // Bu döngü, belirli bir aralıkta veya belirli bir sayıda tekrarlanması gereken işlemleri gerçekleştirmek için kullanılır.
            {
                for (int y = 0; y < 4; y++)
                {
                    kart yeni_kart = new kart();        //
                    yeni_kart.numara = x + 1;           // Bu kod blokları, bir kartın numarası, sembolü ve resmiyle ilişkilendirilerek yeni bir kart nesnesinin oluşturulmasını sağlar. 
                    yeni_kart.sembol = y;               //
                    yeni_kart.resmi = bmp_res.Clone(new Rectangle(x * w, y * h, w, h), resim.PixelFormat);//
                    kartlar.Add(yeni_kart); //
                }
            }

        }
        public void yeni_oyun()
        {
            giris q = new giris(); //
            q.ShowDialog();        //  Bu kod blokları, bir giriş formunun gösterilmesi, oyunun başlatılması ve gerekli listelerin oluşturulması gibi işlemleri gerçekleştirir.
            oyun_acik = true;      //
            ortadaki_kartlar = new List<kart>(); //
            kartlar_aktif = new List<kart>(); //
            for (int i = 0; i < kartlar.Count; i++)
            {
                kartlar_aktif.Add(kartlar[i]);
            }
            kart_sayisi_toplam = 52;//Toplam kart sayısı 52e eşit olacak
            kartlari_dagıt();
        }
        public void kartlari_dagıt()
        {
            if (kartlar_aktif.Count != 0)//Bu kod bloğu kartlar_aktif adında bir koleksiyonun eleman sayısının sıfır olup olmadığını kontrol eder.
            {
                Random rast = new Random();         //
                PictureBox resimf = new PictureBox();//Bu kod blokları random sınıfından rast adında bir nesne oluşturur ve PictureBox sınıfından resimf adında bir nesne oluşturur.
                if (kartlar_aktif.Count == 52)
                {
                    for (int i = 0; i < 4; i++)
                    {

                        int a = 0;
                        a = rast.Next(0, kartlar_aktif.Count - 1);
                        resimf = new PictureBox();            //
                        resimf.Image = kartlar_aktif[a].resmi;// Bu kod blokları, resimf isimli PictureBox kontrolünü oluşturur, resmini ve ilgili etiket (tag) bilgisini ayarlar
                        resimf.Tag = kartlar_aktif[a].numara + ";" + kartlar_aktif[a].sembol;
                        kartlar_aktif.RemoveAt(a); 
                        resimf.Size = resimf.Image.Size;//Bu kod bloğu, seçilen bir kartın kartlar_aktif listesinden çıkarılması ve PictureBox nesnesinin boyutunun resmin boyutuna göre ayarlanması işlemlerini gerçekleştirir.
                        resimf.Location = new Point(0, 0);//Bu kodu kullanarak, PictureBox nesnesinin formda veya diğer bir konteynerdeki konumunu belirleyebiliriz
                        en_son_atilan_kart = kartlar_aktif[a];//Bu işlemle, kartlar_aktif listesindeki belirli bir indise sahip olan kartın bilgilerini başka bir değişkende saklayabilir ve daha sonra bu değişkeni kullanarak kartın bilgilerine erişebilirsiniz
                        ortadaki_kartlar.Add(kartlar_aktif[a]);//Bu işlemle, ortadaki_kartlar listesi veya koleksiyonunda, o an seçilen kartları tutabilirsiniz.
                        panel2.Controls.Add(resimf);//Bu işlemle, belirli bir panelin içine kontrol veya bileşenleri ekleyerek, kullanıcı arayüzünde düzenleme yapabilirsiniz.

                    }
                }
                resimf.BringToFront();
                for (int i = 0; i < 4; i++)
                {

                    int a = 0;
                    a = rast.Next(0, kartlar_aktif.Count);//Rast nesnesi üzerinden Next metodunu kullanarak, 0 ve kartlar_aktif.Count arasında bir rastgele sayı üretir ve bu sayıyı a değişkenine atar. Bu sayede a değişkeni, kartlar_aktif listesinde rastgele bir indeksi temsil eder.
                    PictureBox resime = new PictureBox();//Bu nesneyi kullanarak, form üzerinde veya başka bir konteynerde görüntülerin gösterilmesi, resimlerin yüklenmesi veya manipülasyonu gibi işlemler gerçekleştirebilirsiniz.
                    resime.Image = kartlar_aktif[a].resmi;//Bu kod satırı, resime adlı PictureBox nesnesinin Image özelliğine bir resim atar.
                    resime.Tag = kartlar_aktif[a].numara + ";" + kartlar_aktif[a].sembol;//Bu satır, resime adlı PictureBox nesnesinin Tag özelliğine veri atar.
                    kartlar_aktif.RemoveAt(a);//Bu kod satırı, kartlar_aktif listesinden belirli bir indise sahip olan elemanı kaldırır.
                    resime.Size = resime.Image.Size;//Bu satır, resime adlı PictureBox nesnesinin boyutunu resmin boyutuna göre ayarlar.
                    resime.Location = new Point(8+30 * i, 8);//Bu kod satırı, resime adlı PictureBox nesnesinin konumunu belirler.
                    resime.DoubleClick += new EventHandler(resim_Click);//Bu kod satırı, resime adlı PictureBox nesnesine çift tıklama olayı için bir olay işleyici ekler.
                    resime.MouseHover += new EventHandler(resime_MouseEnter);//Bu kod satırı, resime adlı PictureBox nesnesine fare üzerine gelme olayı için bir olay işleyici ekler.
                    resime.MouseLeave += new EventHandler(resime_MouseLeave);//Bu kod satırı, resime adlı PictureBox nesnesine fare çıkışı olayı için bir olay işleyici ekler.
                    panel1.Controls.Add(resime);//Bu kod satırı, resime adlı PictureBox nesnesini panel1 adlı bir Panel kontrolüne ekler.
                }
                for (int i = 0; i < 4; i++)
                {

                    int a = rast.Next(0, kartlar_aktif.Count);//Bu kod, rastgele bir sayı üretir ve bunu a değişkenine atar. 
                    PictureBox resime = new PictureBox();//Resime adında bir PictureBox nesnesi oluşturur ve ona bir referans atar.
                    resime.Image = desen;//Desen adında bir resmi resime adlı PictureBox nesnesinin görüntüsü olarak atar.
                    resime.BackgroundImage = kartlar_aktif[a].resmi;// Belirli bir resmin arka planını değiştirmek veya başka bir resimle değiştirmek için kullanılabilir.
                    resime.SizeMode = PictureBoxSizeMode.StretchImage;//Bir PictureBox nesnesinin boyutlandırma modunu StretchImage olarak ayarlar.
                    resime.Tag = kartlar_aktif[a].numara + ";" + kartlar_aktif[a].sembol;//Resime nesnesine, kartın numarası ve sembolünü temsil eden bir değer atanmasını sağlar
                    kartlar_aktif.RemoveAt(a);//Belirli bir indeksteki bir öğenin koleksiyondan kaldırılmasını sağlar
                    resime.Size = new Size(73, 98);//Boyut ayarlaması, resimlerin veya kontrolün kendisinin görüntülenmesini değiştirmek veya sınırlamak için kullanılır.
                    resime.Location = new Point(8+30 * i, 8);// PictureBox nesnesinin konumunu belirli bir X ve Y koordinatıyla ayarlar.
                    panel3.Controls.Add(resime);//Panel nesnesine (panel3) bir kontrolü (resime) ekler.
                }

                kart_sayisi_kullanici = 4;
                kart_sayisi_rakip = 4;
            }
            pcb_cards.Refresh();
        }

        void resime_MouseLeave(object sender, EventArgs e)
        {
            PictureBox[] pbd = new PictureBox[4];//4 adet PictureBox nesnesini tutabilen bir dizi oluşturur.
            foreach (PictureBox pb in panel1.Controls)//Panel1 kontrolünün içindeki PictureBox türündeki tüm kontrol öğelerine döngü yoluyla erişmeyi sağlar.
            {
                int d = pb.Location.X/30;// PictureBox nesnesinin X koordinatının 30 birime bölünmesi sonucunda elde edilen tam sayı değerini d değişkenine atar.
                pbd[d] = pb;//pb değişkeninin değerini pbd dizisindeki belirli bir indekse atar.
            }
            for (int i = 0; i < pbd.Length; i++)//pbd dizisinin uzunluğu kadar bir döngü oluşturur.
            {
                if (pbd[i] != null)//pbd dizisinin belirli bir indeksindeki elemanın null olup olmadığını kontrol eder.
                {
                    pbd[i].SendToBack();//pbd dizisindeki belirli bir indeksteki PictureBox nesnesini en arkaya taşır.
                }
            }
        }

        void resime_MouseEnter(object sender, EventArgs e)
        {
            (sender as PictureBox).BringToFront();//Olayın tetiklendiği PictureBox kontrolünü en öne taşır.
        }

        public void resim_Click(object sender, EventArgs e)
        {
            if (sira_bende == true && anim_run == false)//Eğer sira_bende değişkeni true değerine eşitse ve anim_run değişkeni false değerine eşitse, içindeki bloğa giren bir kod bloğu yürütülür.
            {
                PictureBox resimd = (sender as PictureBox);// Olayın tetiklendiği kontrolü PictureBox türünde bir değişkene atar.
                resimd.Location = new Point(0, 0);//resimd adlı PictureBox nesnesinin konumunu (0, 0) koordinatına ayarlar.
                panel1.Controls.Remove(resimd);//panel1 adlı bir konteynerden (Panel) resimd adlı PictureBox nesnesini kaldırır.
                animasyon(ref resimd, new Point(panel1.Location.X + resimd.Size.Width, panel1.Location.Y));//Animasyon  metodu çağırırken resimd değişkenini referans olarak geçer ve ikinci parametre olarak panel1 konumunun X koordinatına resimd kontrolünün genişliği eklenmiş bir Point değeri kullanır.
                resimd.BringToFront();//resimd adlı PictureBox kontrolünü en öne taşır.


                kart_sayisi_kullanici--;

                //Ses efekti ekleme kodları
                System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
                ses.SoundLocation = "depositphotos_552298394-track-playing-cards-game-casino-sound.wav";
                ses.Play();
                //
            }
        }
        public bool degerlendir(int kart_numarasi, int sembol)
        {
            kart new_kart = kartlar[(kart_numarasi - 1) * 4 + sembol];//Kartlar dizisinden belirli bir indeksle erişilen bir elemanı new_kart adlı kart değişkenine atar.
            ortadaki_kartlar.Add(new_kart);//new_kart değişkenini ortadaki_kartlar adlı bir liste veya koleksiyonun sonuna ekler.
            if (ortadaki_kartlar.Count != 0)//ortadaki_kartlar adlı bir koleksiyonun eleman sayısının 0 olup olmadığını kontrol eder.
            {

                if (kart_numarasi == en_son_atilan_kart.numara)//Kart_numarasi değişkeninin en_son_atilan_kart nesnesinin numara özelliğiyle eşit olup olmadığını kontrol eder.
                {
                    
                    return true;
                }
                else if (kart_numarasi == 11 && ortadaki_kartlar.Count > 1)//Bir önceki koşulun sağlanmadığı durumda, kart_numarasi değişkeninin 11'e eşit olduğunu ve aynı zamanda ortadaki_kartlar koleksiyonunun eleman sayısının 1'den büyük olduğunu kontrol eder.
                {
                    return true;
                }
                else
                {



                }
                en_son_atilan_kart = new_kart;//en_son_atilan_kart değişkenine new_kart değişkeninin değerini atar.
            }
            return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void oyun_bitti_mi()
        {
            if (kartlar_aktif.Count == 0 && kart_sayisi_kullanici == 0 && kart_sayisi_rakip == 0 && oyun_acik)//kartlar_aktif listenin boş olduğunu, kart_sayisi_kullanici ve kart_sayisi_rakip değişkenlerinin sıfır olduğunu ve oyun_acik değişkeninin true olduğunu kontrol eder.
            {
                th1.Abort();//th1 adlı bir Thread (iş parçacığı) nesnesini sonlandırır veya iptal eder.
                oyun_acik = false;//yun_acik adlı bir boolean değişkenin değerini false olarak ayarlar.
                int puan = puanla(false);//Puanla fonksiyonunu çağırarak dönen değeri puan adlı bir integer değişkene atar.
                if (is_ben_aldm == true)//is_ben_aldm adlı bir boolean değişkenin değerini kontrol eder.
                {
                    puan_kullanici += puan;//puan_kullanici adlı bir değişkenin değerini, puan adlı bir değişkenin değeriyle artırır.
                }
                else
                {
                    puan_rakip += puan;//puan_rakip adlı bir değişkenin değerini, puan adlı bir değişkenin değeriyle artırır.
                }
                puan_toplam_kul += puan_kullanici;//puan_toplam_kul değişkenine puan_kullanici değişkeninin değerini ekleyerek toplam puanı güncellemek için kullanılır
                puan_toplam_pc += puan_rakip;
                Son sn = new Son(puan_kullanici, puan_rakip);//Verilen kod satırı, "Son" adında bir sınıftan bir nesne oluşturmayı sağlar. Nesne oluşturulurken "puan_kullanici" ve "puan_rakip" adında iki parametre kullanılır.
                sn.ShowDialog();
                if (devam_veya_cik)
                {
                    dataGridView1.Rows.Add(puan_kullanici, puan_rakip);// bir kontrolde yeni bir satır eklemek için kullanılır.
                    el++;
                    el_bitir();
                }
                else 
                {
                    puan_toplam_kul = 0;
                    puan_toplam_pc = 0;
                    el = 1;
                }
                lbl_toplam_puan_kulla.Text = puan_toplam_kul.ToString();//lbl_toplam_puan_kulla" adlı bir etiketin metin değerini güncellemek için kullanılır. "puan_toplam_kul" adlı bir değişkenin değeri, etiketin metin olarak görüntülenmesini sağlamak için "ToString()" yöntemiyle bir metin dönüşümüne tabi tutulur.
                lbl_toplam_puan_rakip.Text = puan_toplam_pc.ToString();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)//timer1_Tick olayı, bir Timer kontrolünün belirli bir süre sonunda tetiklenen bir olaydır. Bu olay, timer1 adlı Timer kontrolü için bir zamanlayıcı işlevi görür.
        {
            label2.Text = DateTime.Now.ToString();//Bu kod, mevcut tarih ve saati içeren bir dizeyi alır ve "label2.Text" adlı bir etikete atar. Önceden tanımlanmış bir "label2" nesnesinin metin özelliğine, geçerli tarihi ve saati içeren bir dize yazılır
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)//orm1_FormClosed adındaki bu olay işleyicisi (event handler), bir Windows Form'unu kapattığınızda çalışan bir kod parçasını temsil eder.
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (th1 != null)//Bu kod parçası, "th1" değişkeninin null olup olmadığını kontrol eder. Eğer "th1" değişkeni null değilse, yani bir değere sahipse, kod içinde yer alan işlemler veya koşullar yararlı olabilir.
            {
                th1.Abort();//"th1.Abort();" ifadesi, bir Thread (İş Parçacığı) nesnesinin çalışmasını sonlandırmak için kullanılır.
            }
            Application.Exit();//Application.Exit();" ifadesi, Windows Forms veya WPF tabanlı bir uygulamanın kapatılmasını sağlar
        }

        private void timer2_Tick(object sender, EventArgs e)//
        {
            
            if (a<5)//"if (a < 5)" ifadesi, "a" adlı bir değişkenin 5'ten küçük olup olmadığını kontrol eder.
            {
                a++;
                pcb_pisti.Image = pisti_a;
                
            }
            else if (a < 10)
            {
                pcb_pisti.Image = pisti_b;
                a++;
            }
            else 
            {
                a = 0;
            }
            if (anim_run)
            {
                anim_kart.BringToFront();
                if (anim_kart.Location.Y == panel2.Location.Y + panel2.Size.Height / 2 || (anim_kart.Location.Y + anim_kart.Size.Height > panel2.Location.Y + panel2.Size.Height / 2 && anim_kart.Location.Y + anim_kart.Size.Height < panel2.Location.Y + panel2.Size.Height / 2+10))
                {
                    anim_run = false;//nim_run = false; ifadesi, bir programlama dilinde değişkenin değerini false olarak atamak için kullanılan bir ifadedir
                    panel2.Controls.Add(anim_kart);//Verilen ifade, bir programlama dilinde bir panelin kontrollerine (Controls) bir kontrol öğesi (anim_kart) eklemek için kullanılan bir ifadedir.
                    anim_kart.BringToFront();//anim_kart.BringToFront(); ifadesi, bir programlama dilinde bir kontrol öğesini (anim_kart), diğer kontrol öğelerinin önüne getirmek için kullanılan bir ifadedir.
                    if (sira_bende == true)//sira_bende adlı bir boolean (mantıksal) değişkenin değerini kontrol etmektir.
                    {

                        if (degerlendir(Convert.ToInt32(anim_kart.Tag.ToString().Split(';')[0]), Convert.ToInt32(anim_kart.Tag.ToString().Split(';')[1])))//Bu ifade, bir fonksiyon çağrısını temsil etmektedir
                        {
                            puan_kullanici += puanla();
                            is_ben_aldm = true;
                            lbl_puan_kullanici.Text = puan_kullanici.ToString();//Bu ifade, lbl_puan_kullanici adlı bir etiketin metin özelliğini günceller. 
                        }
                        sira_bende = false;
                    }
                    else
                    {
                        if (degerlendir(Convert.ToInt32(anim_kart.Tag.ToString().Split(';')[0]), Convert.ToInt32(anim_kart.Tag.ToString().Split(';')[1])))
                        {
                            puan_rakip += puanla();
                            is_ben_aldm = false;//değişkeni tanımlamak için kullanılır
                            lbl_puan_rakip.Text = puan_rakip.ToString();
                            panel2.Controls.Clear();
                        }
                        sira_bende = true;
                    }
                    if (ortadaki_kartlar.Count > 1)
                    {
                        panel2.BackgroundImage = back_ground_card;//Bu kod, bir panelin arka plan görüntüsünü değiştirmek için kullanılır
                    }
                    anim_kart.Location = new Point(0, 0);//Bu kod, anim_kart adlı bir nesnenin Location özelliğini (0, 0) koordinatlarına ayarlar.
                    oyun_bitti_mi();
                    kiside_kart_yok();

                }
                else if (anim_kart.Location.Y > panel2.Location.Y + panel2.Size.Height / 2)//Kodun tamamına bakıldığında, bir animasyon kartının belirli bir konumda (anim_kart.Location.Y) bulunduğu ve eğer bu konum, belirli bir panelin (panel2) konumunun üstünde ise bu bloğun çalıştırılacağı anlaşılıyor.
                {
                    anim_kart.Location = new Point(anim_kart.Location.X, anim_kart.Location.Y - 5);
                }
                else if (anim_kart.Location.Y < panel2.Location.Y + panel2.Size.Height / 2)
                {
                    anim_kart.Location = new Point(anim_kart.Location.X, anim_kart.Location.Y + 5);
                }
            }
            else 
            {
                wait = false;//Bu ifade, bir değişkenin (wait) değerini false olarak ayarlar.
            }
        }

        private void pnl_arka_Paint(object sender, PaintEventArgs e)//Genel olarak, pnl_arka_Paint yöntemi, bir panelin çizim olayını ele alarak, panele özel çizim işlemlerini uygulamak için kullanılır.
        {
            SolidBrush firca= new SolidBrush(Color.White);// Bu sınıf, bir fırçayı belirli bir renkle oluşturmak veya dolgu yapmak için kullanılır.
            e.Graphics.FillRectangle(firca, new Rectangle(0, 0, pnl_arka.Width, 17));//Bu kod parçası, bir Graphics nesnesi üzerinde bir dikdörtgeni doldurmak için kullanılır. 
            e.Graphics.FillRectangle(firca, new Rectangle(0, 0, 17, pnl_arka.Height));
            e.Graphics.FillRectangle(firca, new Rectangle(pnl_arka.Width-17, 0,17,pnl_arka.Height ));
            e.Graphics.FillRectangle(firca, new Rectangle(0, pnl_arka.Height-17, pnl_arka.Width, 17));
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush firca = new SolidBrush(Color.White);
            e.Graphics.FillRectangle(firca, new Rectangle(0, 0, panel3.Width, 8));
            e.Graphics.FillRectangle(firca, new Rectangle(0, 0, 8, panel3.Height));
            e.Graphics.FillRectangle(firca, new Rectangle(panel3.Width - 8, 0, 8, panel3.Height));
            e.Graphics.FillRectangle(firca, new Rectangle(0, panel3.Height - 8, panel3.Width, 8));
        }

        private void pcb_cards_Paint(object sender, PaintEventArgs e)// Bu olay, bir kontrolün üzerine çizim yapmanızı veya görüntülemek için özel bir görüntü oluşturmanızı sağlar.
        {
            if (kartlar_aktif != null)
            {
                if (kartlar_aktif.Count > 0)
                {
                    pcb_cards.Visible = true;
                    SolidBrush kalem = new SolidBrush(Color.Black);// sınıfı, belirtilen renkteki düz renk fırçalarını temsil eder. 
                    e.Graphics.DrawString(kartlar_aktif.Count.ToString(), new Font(this.Font.FontFamily, 25, FontStyle.Bold, GraphicsUnit.Pixel), kalem, new PointF(pcb_cards.Width / 3, pcb_cards.Height / 2));
                }
                else
                {
                    pcb_cards.Visible = false;//bileşeninin görünürlüğünü devre dışı bırakır veya gizler.
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)//Windows Forms uygulamasında bir düğmeye (button) tıklandığında gerçekleştirilecek işlemleri tanımlamak için kullanılır.
        {
            el_bitir();
            puan_toplam_kul = 0;
            puan_toplam_pc = 0;
            lbl_toplam_puan_rakip.Text = "";
            lbl_toplam_puan_kulla.Text = "";
            dataGridView1.Rows.Clear();
        }
        public void el_bitir()//duruma göre elin bitip bitmemesini tetikler
        {
            if (max_el >= el)
            {
                panel2.BackgroundImage = null;//bir panelin arka plan resmini (background image) kaldırmak için kullanılır.
                yeni_oyun_hazirlik();
                panel2.BackgroundImage = back_ground_card;//Bu kod satırı, bir Windows Forms uygulamasında bir panelin arka plan resmini ayarlamak için kullanılır
                kartlari_parcala();
                yeni_oyun();
                th1 = new Thread(rakip_kontrol);//Bu kod satırı, çoklu iş parçacığı (thread) kullanarak rakip_kontrol adlı bir metodu çalıştırmak için kullanılır.
                th1.IsBackground = true;
                th1.Start();
                pcb_cards.Refresh();// PCB (Printed Circuit Board) üzerinde bulunan kartların yenilenmesini sağlayan bir işlevi çağırır.
            }
            else
            {
                MessageBox.Show("Güzel Oyundu");//programlama dilinde kullanılan bir iletişim kutusu (message box) göstermek için kullanılır.
            }
        }
        private void yeni_oyun_hazirlik()// bir sınıf içinde tanımlanan bir metodun başlangıç noktasını ifade eder. Bu metodun işlevi, adından da anlaşılacağı gibi, yeni bir oyunun hazırlık aşamasını gerçekleştirmektir.
        {
            ortayı_temizle();
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            panel3.Controls.Clear();
            if (kartlar_aktif != null)
            {
                kartlar_aktif.Clear();//kartlar_aktif adlı nesnenin içeriğini temizlemek için kullanılır.
            }
            if (kartlar != null)
            {
                kartlar.Clear();
            }
            puan_kullanici = 0;
            puan_rakip = 0;
            lbl_puan_kullanici.Text = "0";
            lbl_puan_rakip.Text = "0";
            panel2.BackgroundImage = null;
            pcb_cards.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)//button2_Click metodu, bir butona tıklandığında gerçekleştirilecek işlevleri belirtmek için kullanılan bir olay işleyicisidir.
        {
            Application.Exit();//bir Windows Forms uygulamasını kapatmak için kullanılır. Bu kod, uygulamayı sonlandırır ve tüm açık olan pencereleri kapatır.
        }

        private void pnl_arka_MouseHover(object sender, EventArgs e)
        {

        }
       

        
        Color RastgeleRenk()
        {
            //0-255 arasında rastgele sayı üretecek;
            Random random = new Random();

            int kirmizi = random.Next(0, 255);//Bu ifade, random adlı Random nesnesini kullanarak 0 ile 255 (dahil değil) arasında bir rastgele tamsayı üretir ve bu değeri kirmizi adlı bir değişkene atar.
            int yesil = random.Next(0, 255);
            int mavi = random.Next(0, 255);

            Color color = Color.FromArgb(kirmizi, yesil, mavi);

            return color;
        }

        private void label1_Click(object sender, EventArgs e)//Bu kod parçası, bir Windows Forms uygulamasında label1 adlı bir etikete tıklama olayını işler.
        {
            label1.Font = new Font(label1.Font, FontStyle.Bold);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Color randomColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));//Bu satır, rastgele bir renk oluşturmak için kullanılır.
            label1.ForeColor = randomColor;//Bu satır, label1 adlı bir etiketin metin rengini randomColor olarak belirler.
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer ses = new System.Media.SoundPlayer();//Windows işletim sistemlerinde ses çalmak için kullanılır
            ses.SoundLocation = "Cay-icip-ses-ckartan-cocuk-_mp3cut.net_.wav";
            ses.Play();
        }
    }
}
