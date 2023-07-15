using IlacTakipSistemi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IlacTakipSistemi
{
    public partial class IlacEkle : Form
    {
        private AnaSayfa anaSayfa;/* AnaSayfa framesinin private bir nesnesini oluşturdum */
        public IlacEkle(AnaSayfa anaSayfa)
        {
            InitializeComponent();
            /*Dependency Injection yaparak IlacEkle formunu AnaSayfa formuna bağımlı hale getirdim,
             * böylelikle AnaSayfa formu içerisindeki nesnelere de ulaşabiliyorum */
            this.anaSayfa = anaSayfa;   
        }

        private void btnIlacEkle_Click(object sender, EventArgs e)
        {
            ilacEkle();
        }

        public void ilacEkle()/* Yeni bir ilaç ekleyen metot */
        {
            try
            {
                using (var modelctx = new ModelContext())//Database ile bağlantı kuruluyor
                {
                    Ilac ilac = new Ilac();/* Databaseye yeni bir ilaç ekleneceği için
                                            yeni bir Ilac nesnei oluşturuluyor */
                    ilac.ilacAdi = txtIlacAdi.Text;/* Ilacın adı textboxtan alınıyor */
                    ilac.gunlukAdet = int.Parse(cmbxGunlukAlim.SelectedItem.ToString());/* Ilacın adı 
                                                                                         comboboxtan alınıyor */
                    ilac.ilacTuru = cmbxIlacTuru.SelectedItem.ToString();/* Ilacın adı comboboxtan alınıyor */
                    ilac.kullaniciID = 1;
                    if (ilac != null)/* Ilac null dönmezse*/
                    {
                        modelctx.Ilaclar.Add(ilac);/* Databaseye ilaç ekleniyor */
                        int sonuc = modelctx.SaveChanges();/* Yapılan değişiklikler kaydediliyor */
                        if (sonuc > 0)/* Databaseye kayıt başarılı olursa sorgudan dönen değer 0dan büyük oluyor*/
                        {
                            MessageBox.Show("İlaç Eklendi!");/* Başarı Mesajı */
                        }
                        else
                        {
                            MessageBox.Show("İlaç Eklenemedi!");/* Hata Mesajı */
                        }
                    }
                }
            }
            catch (Exception ex) /* Databaseye ekleme yapılırken herhangi bir 
                                 hata çıkarsa burası yakalıyor */
            {
                MessageBox.Show(ex.Message); /* Yakalanan hatanın mesajı MessageBox ile gösteriliyor */
            }
        }

        private void IlacEkle_FormClosed(object sender, FormClosedEventArgs e)/* IlacEkle formu kapandığında çalışır */
        {
            anaSayfa.cmbxIlac.Items.Clear(); /* AnaSayfa framesindeki comboboxın itemlerini temizliyorum */
            anaSayfa.ilaclariGetir(); /* Tüm ilaçları getiren metodu çağırıyorum*/
        }
    }
}
