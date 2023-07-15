using IlacTakipSistemi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IlacTakipSistemi
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void btnIlacEkle_Click(object sender, EventArgs e)
        {
            /* İlaç Ekle butonuna basıldığında IlacEkle framesinin nesnesini oluşturur */
            IlacEkle ilacEkle = new IlacEkle(this);
            ilacEkle.Visible = true;/* Oluşturulan nesneyi görünür yapar */
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            /* Sayfa yüklendiğinde getirilmesi gereken verileri getiren metotlar */
            bilgileriAl(); /* Giriş yapan kullancının bilgilerini getirir */
            ilaclariGetir(); /*Giriş yapan kullanıcıya ait ilaçları getirir */
            gecmisGetir(); /* Giriş yapan kullanıcının ilaç geçmişi */ 
        }

        public void bilgileriAl()/* Bu metot sisteme giriş yapan kullanıcının
                                  bilgilerini gerekli labellere yerleştiriyor.*/
        {
            using (var modelctx = new ModelContext())//Database ile bağlantı kuruluyor
            {
                var kod = "slm15";
                var tc = (from k in modelctx.Kullanicilar
                          where k.kullaniciGirisKodu == kod.ToString()
                          select k.kullaniciTcNo.ToString()).FirstOrDefault();
                /* tc değişkenine databasedeki kullanıcının giriş koduyla eşleşen T.C. numarasını atıyor*/
                var ad = (from k in modelctx.Kullanicilar
                          where k.kullaniciGirisKodu == kod.ToString()
                          select k.kullaniciAdSoyad.ToString()).FirstOrDefault();
                /* ad değişkenine databasedeki kullanıcının giriş koduyla eşleşen adı atıyor*/
                var yas = (from k in modelctx.Kullanicilar
                           where k.kullaniciGirisKodu == kod.ToString()
                           select k.kullaniciYas.ToString()).FirstOrDefault();
                /* yas değişkenine databasedeki kullanıcının giriş koduyla eşleşen yaşı atıyor*/
                var cinsiyet = (from k in modelctx.Kullanicilar
                                where k.kullaniciGirisKodu == kod.ToString()
                                select k.kullaniciCinsiyet.ToString()).FirstOrDefault();
                /*cinsiyet değişkenine databasedeki kullanıcının giriş koduyla eşleşen cinsiyet atıyor*/

                lblSetTcNo.Text = tc;//T.C. kimlik numarasının labeline tc değişkeninin değerini atıyor
                lblSetAdSoyad.Text = ad;//Ad labeline ad değişkeninin değerini atıyor
                lblSetAge.Text = yas;//Yaş labeline yas değişkeninin değerini atıyor
                lblSetCinsiyet.Text = cinsiyet;/*Cinsiyet labeline cinsiyet değişkeninin değerini atıyor*/
            }
        }


        private void btnIlacAl_Click(object sender, EventArgs e)
        {
            ilacAl();
        }

        private void btnIlacSil_Click(object sender, EventArgs e)
        {
            ilacSil();/* Seçilen ilacı sildirir */
            cmbxIlac.SelectedItem = 0; /* Comboboxta seçilen itemi 0. indexe atar, yani boş değere atar*/
            cmbxIlac.Items.Clear(); /* Comboboxtaki tüm ilaçları temizliyor */
            ilaclariGetir();/* Tüm ilaçları yeniden getirtiyorum çünkü 2 satır önce bir ilaç sildik */
        }

        public void ilaclariGetir()/*Kullanıcıya ait tüm ilaçları getiren metot */
        {
            using (var modelctx = new ModelContext())//Database ile bağlantı kuruluyor
            {
                var ilaclar = modelctx.Ilaclar.ToList();/* Databasedeki tüm ilaçları getirerek 
                                                        ilaclar değişkenine atıyor*/

                foreach (var ilac in ilaclar)/*Foreach sayesinde ilaclar değişkeni içerisindeki
                                             tüm ilaçlar taranıyor*/ 
                {
                    cmbxIlac.Items.Add(ilac.ilacAdi.ToString());/*Taranan ilaçlar
                                                                 combobox içerisine ekleniyor*/
                }

                if (ilaclar.Count == 0)
                {
                    /*Databasede hiç ilaç bulunamazsa MessageBox içerisindeki
                    hata mesajını kullanıcıya gösteriyor. */
                    MessageBox.Show("İlaç Bulunamadı");
                }
            }
        }

        public void ilacAl()/* Kullanıcının ilaç almasına yarayan metot */
        {
            try
            {
                using (var modelctx = new ModelContext())//Database ile bağlantı kuruluyor
                {
                    IlacTakip ilac = new IlacTakip();/* Kullanıcı her seferinde yeni ilaç alacağı için
                                             her seferinde yeni bir IlacTakip nesnesi oluşturuyorum */

                    ilac.ilacAdı = cmbxIlac.SelectedItem.ToString();/* Combobox içerisinden
                                          seçilen itemin adını ilacAdı değişkenine atıyorum */
                    ilac.Tarih = DateTime.Now;/* ilac nesnesinin bir propertysi olan Tarih
                                               alanına mevcut olan zamanı atıyorum */
                    if (ilac != null)/*Ilac boş dönmezse*/
                    {
                        /* İlaç boş dönmezse databaseye alınan bu bilgileri insert ediyorum */
                        modelctx.IlacTakip.Add(ilac);//Databasedeki IlacTakip tablosuna insert ediyor
                        int ekle = modelctx.SaveChanges();/* Eklemenin başarılı olup olmadığını
                                                           kontrol ediyorum */

                        if (ekle > 0)/* Ekleme başarılıysa */
                        {
                            MessageBox.Show("Eklendi!");/* Başarı mesajı */
                            gecmisGetir();/* Yeni bir veri eklendiği için DataGridView'i yenilemek
                                           için yeniden tüm alınan ilaç geçmişini çağırıyorum */
                        }
                        else
                        {
                            MessageBox.Show("Eklenmedi!");/* İlaç al başarısız olduğundaki
                                                           hata mesajı */
                        }
                    }
                    else
                    {
                        MessageBox.Show("Null Geldi!");/* Hiçbir ilaç seçilmeden butona basıldığında
                                                        çıkacak hata mesajı */
                    }

                }
            }
            catch (Exception ex)/* Databaseye ekleme yapılırken herhangi bir 
                                 hata çıkarsa burası yakalıyor */
            {
                MessageBox.Show(ex.Message);/* Yakalanan hatanın mesajı MessageBox ile gösteriliyor */
            }
        }

        public void gecmisGetir()/* Tüm İlaç Geçmişini Getiriyor */
        {
            try
            {
                using (var modelctx = new ModelContext())//Database ile bağlantı kuruluyor
                {
                    var data = modelctx.IlacTakip.ToList();/* Getirilen tüm veriler 
                                                            data değişkenine atılıyor */

                    ilacBilgiView.DataSource = data; /* DataGridView'in DataSource yapısına
                                              data değişkenindeki veriler ekleniyor */
                }
            }
            catch (Exception ex)/* Databaseye ekleme yapılırken herhangi bir 
                                 hata çıkarsa burası yakalıyor */
            {
                MessageBox.Show(ex.Message);/* Yakalanan hatanın mesajı MessageBox ile gösteriliyor */
            }
        }
        public void ilacSil()/* Seçilen ilacı silmeye yarayan metot */
        {
            try
            {
                using (var dbContext = new ModelContext())//Database ile bağlantı kuruluyor
                {
                    var silinecekVeri = dbContext.Ilaclar.
                        FirstOrDefault(ilac => ilac.ilacAdi == cmbxIlac.SelectedItem.ToString());
                    /* Comboboxtan seçilen itemin adına göre databasede tarama yapılıyor
                    ve bulunan veri silinecekVeri adlı değişkenin içerisine atılıyor */
                    if (silinecekVeri != null)/* silinecekVeri Null Dönmezse */
                    {
                        dbContext.Ilaclar.Remove(silinecekVeri);/*Databasedeki tablodan bu veriyi
                                                                kaldırıyorum */
                        dbContext.SaveChanges();/* Yapılan değişiklikleri kaydediyorum */
                        MessageBox.Show("İlaç Silindi!");/* İlacın silindiğine dair başarı mesajı */
                    }
                    else
                    {
                        MessageBox.Show("İlaç Silinmedi!");/*İlacın silinemediğine dair hata mesajı */
                    }
                }

            }
            catch (Exception ex)/* Databaseye ekleme yapılırken herhangi bir 
                                 hata çıkarsa burası yakalıyor */
            {
                MessageBox.Show(ex.Message);/* Yakalanan hatanın mesajı MessageBox ile gösteriliyor */
            }
        }
    }


}
