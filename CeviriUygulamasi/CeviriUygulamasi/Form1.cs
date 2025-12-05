using System;
using System.Windows.Forms;
using GTranslate.Translators; // NuGet'ten indirdiğimiz paket

namespace CeviriUygulamasi
{
    public partial class Form1 : Form
    {
        // Çeviri yapacak nesneyi oluşturuyoruz
        GoogleTranslator translator = new GoogleTranslator();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ComboBox'a dilleri ekleyelim
            cmbDiller.Items.Add("Türkçe");
            cmbDiller.Items.Add("İngilizce");
            cmbDiller.Items.Add("Almanca");
            cmbDiller.Items.Add("Fransızca");
            cmbDiller.Items.Add("İspanyolca");

            // Varsayılan olarak İngilizce seçili gelsin
            cmbDiller.SelectedIndex = 1;
        }

        // ASYNC: İnternet işlemi olduğu için asenkron (eşzamansız) yapıyoruz
        private async void btnCevir_Click(object sender, EventArgs e)
        {
            try
            {
                // Boş mu diye kontrol et
                if (string.IsNullOrWhiteSpace(txtGiris.Text)) return;

                // Hedef dili belirle
                string hedefDilKodu = "en"; // Varsayılan İngilizce

                switch (cmbDiller.SelectedItem.ToString())
                {
                    case "Türkçe": hedefDilKodu = "tr"; break;
                    case "İngilizce": hedefDilKodu = "en"; break;
                    case "Almanca": hedefDilKodu = "de"; break;
                    case "Fransızca": hedefDilKodu = "fr"; break;
                    case "İspanyolca": hedefDilKodu = "es"; break;
                }

                // Butonu geçici olarak kapat (üst üste basılmasın)
                btnCevir.Text = "Çevriliyor...";
                btnCevir.Enabled = false;

                // ÇEVİRİ İŞLEMİ BURADA YAPILIYOR
                // Kaynak dili otomatik algılar, hedef dile çevirir.
                var sonuc = await translator.TranslateAsync(txtGiris.Text, hedefDilKodu);

                // Sonucu yazdır
                txtCikis.Text = sonuc.Translation;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu. İnternet bağlantını kontrol et.\nHata: " + ex.Message);
            }
            finally
            {
                // İşlem bitince butonu eski haline getir
                btnCevir.Text = "Çevir";
                btnCevir.Enabled = true;
            }
        }
    }
}