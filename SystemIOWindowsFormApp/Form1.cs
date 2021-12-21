using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemIOWindowsFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Global Alan
        VeriIslemleri veriIslemleri = new VeriIslemleri();
        Personel secilenPersonel = null;
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnPersonelGetir.Click += new EventHandler(btnPersonelGetir_Click);

            listBoxPersoneller.DoubleClick += new EventHandler(listBoxPersoneller_DoubleClick);



            btnPersonelKaydet.Click += new EventHandler(btnPersonelKaydet_Click);
            //GroupBox içindeki controllere ulaştık

            foreach (var item in this.Controls) // önce formdaki kontroller
            {
                var theItem = item.GetType();
                if (theItem.Name == "GroupBox"
                    && ((GroupBox)item).Name == "groupBoxPersonelDetay")
                {
                    //Sonra groupboxtakilere ulaştık
                    foreach (var subitems in ((GroupBox)item).Controls)
                    {
                        if (subitems is TextBox)
                        {
                            ((TextBox)subitems).ReadOnly = true;
                        }
                    }
                }
            }
        }

        private void btnPersonelKaydet_Click(object sender, EventArgs e)
        {
            //dosyalYolu
            try
            {
                if (secilenPersonel != null)
                {
                    string kayitOlduguYolBilgisi = string.Empty;
                    bool kontrol = veriIslemleri.PersoneliKaydet("C:\\Elif", secilenPersonel,out kayitOlduguYolBilgisi);
                    if (kontrol)
                    {
                        MessageBox.Show($"{secilenPersonel.ToString()} bilgisayara kayıt oldu... \n yol : {kayitOlduguYolBilgisi}");
                    }
                    else
                    {
                        throw new Exception($"HATA: {secilenPersonel.ToString()} bilgisayara kayıt olamadı....");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen listeden personel seçiniz.");
                    //genel temizlik textler ve listbox
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void listBoxPersoneller_DoubleClick(object sender, EventArgs e)
        {
            // 1.Yöntem
            secilenPersonel = listBoxPersoneller.SelectedItem as Personel;

            txtIsim.Text = secilenPersonel.Isim;
            txtSoyisim.Text = secilenPersonel.Soyisim;
            txtEmail.Text = secilenPersonel.Email;
            txtFirma.Text = secilenPersonel.Firma;
            txtUlke.Text = secilenPersonel.Ulke;

        }

        private void btnPersonelGetir_Click(object sender, EventArgs e)
        {
            listBoxPersoneller.DataSource = veriIslemleri.PersonelleriGetir();
        }
    }
}
