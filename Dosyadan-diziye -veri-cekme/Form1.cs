using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dosyadan_diziye__veri_cekme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Dosya yolunu tanımlayın
            string dosyaYolu = "ogrenciler.txt";

            // Öğrenci listesini tutacak bir dizi oluştur
            string[] ogrenciler;

            try
            {
                // Dosyadan öğrencileri oku ve diziye aktar
                ogrenciler = File.ReadAllLines(dosyaYolu);

                // ListBox'ı temizle (tekrar eden girişleri önlemek için)
                listBox1.Items.Clear();

                // foreach döngüsü ile dizideki her öğrenciyi ListBox'a ekle
                foreach (string ogrenci in ogrenciler)
                {
                    listBox1.Items.Add(ogrenci);
                }
            }
            catch (FileNotFoundException)
            {
                // Dosya bulunamazsa kullanıcıya mesaj göster
                MessageBox.Show("ogrenciler.txt dosyası bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Diğer hatalar için genel hata mesajı
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
