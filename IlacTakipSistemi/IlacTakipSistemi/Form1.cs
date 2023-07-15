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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {

            using (var dbctx = new ModelContext())/*Database ile oluşturulan model 
                                                   arasındaki bağı kurmak için oluşturdum.*/
            {
                var sorgu = from k in dbctx.Kullanicilar 
                            where k.kullaniciGirisKodu == txtKullaniciKodu.Text select k;
                /*Databasedeki kullanıcılar tablosundaki kullanıcının giriş kodu ile textboxa
                girilen veriyi eşliyor*/
                var listOfKullanici = sorgu.FirstOrDefault();//Sorguyla eşlesen ilk kullanıcıyı getiriyor.
                if (listOfKullanici != null)/* Kullanıcı Null dönmezse 
                                             IF bloğu içerisine giriyor*/
                {
                    AnaSayfa anaSayfa = new AnaSayfa();/*AnaSayfa Framesinin nesnesini oluşturuyor*/
                    anaSayfa.Visible = true;/*Oluşturulan nesneyi görünür yaparak,
                                             ekrana getirtiyor*/         
                }
                else
                {
                    /*Kullanıcı Null gelirse ELSE bloğu içerisine giriyor 
                    ve bu MessageBoxtaki mesajı kullanıcıya gösteriyor. */
                    MessageBox.Show("Giriş Kodu Yanlıştır! \n Lütfen Tekrar Deneyiniz!");
                }
            }
            
        }
        
    }

}
