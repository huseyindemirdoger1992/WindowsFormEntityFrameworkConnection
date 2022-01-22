using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormEntityFrameworkConnection.Models; // Referans alabilmek için Bu yapıyı projemize ekliyor ve tanıtıyoruz.

namespace WindowsFormEntityFrameworkConnection
{
    public partial class Form1 : Form
    {
        // Veri tabanından referans alıyoruz.
        WindowsFormEntityFrameworkConnectionDbEntities db = new WindowsFormEntityFrameworkConnectionDbEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Veri tabanına personelleri basıyoruz.
            dataGridViewPersonel.DataSource = db.Personel.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Personel tipinde yeni nesne türetiyoruz
            Personel p = new Personel();

            // Bilgi atamalarını yapıyoruz.
            p.Name = txtAd.Text;
            p.LastNmae = txtSoyad.Text;
            p.Telefon = txtTelefon.Text;

            //Veri tabanında bulunan tabloya aynı tipteki değeri ekliyoruz.
            db.Personel.Add(p);

            //Değişiklikleri kaydediyoruz.
            db.SaveChanges();

            // Veri tabanına personelleri basıyoruz.
            dataGridViewPersonel.DataSource = db.Personel.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Değişecek personeli dataGridViewPersonel üzerinden yakalıyoruz
            int id = int.Parse(dataGridViewPersonel.CurrentRow.Cells[0].Value.ToString());

            // Personel tipinde yakalanan id ye ait personeli türetiyoruz
            Personel p = db.Personel.FirstOrDefault(x => x.PersonelId == id);

            // Bilgi atamalarını yapıyoruz.
            p.Name = txtAd.Text;
            p.LastNmae = txtSoyad.Text;
            p.Telefon = txtTelefon.Text;

            //Değişiklikleri kaydediyoruz.
            db.SaveChanges();

            // Veri tabanına personelleri basıyoruz.
            dataGridViewPersonel.DataSource = db.Personel.ToList();
        }

        private void dataGridViewPersonel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridViewPersonel tıklandığında tıklanan satırdaki bilgileri ilgili nesnelere basıyoruz.
            txtAd.Text = dataGridViewPersonel.CurrentRow.Cells[1].Value.ToString();
            txtSoyad.Text = dataGridViewPersonel.CurrentRow.Cells[2].Value.ToString();
            txtTelefon.Text = dataGridViewPersonel.CurrentRow.Cells[3].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Silinecek personeli dataGridViewPersonel üzerinden yakalıyoruz
            int id = int.Parse(dataGridViewPersonel.CurrentRow.Cells[0].Value.ToString());

            // Personel tipinde yeni nesne türetiyoruz
            Personel p = db.Personel.FirstOrDefault(x => x.PersonelId == id);

            //Soru cevap oluşturuyoruz.
            DialogResult sor = new DialogResult();

            //Oluşturulan soru cevabın mesaj kutusu aracı ile kullanıcıdan cevap almasını sağlıyoruz.
            sor = MessageBox.Show($@"{p.Name} {p.LastNmae} Personeli Silinecek Personeli kalıcı olarak silmek istediğinizden emin misiniz?","Kalıcı Olarak Silinecek", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            //(Daha Eğitimini vermedim ama vereceğim) Karar yapısı ile gelen cevaba göre işlem yaptırıyoruz.
            if (sor == DialogResult.Yes)
            {
                //Eğer koşulla sağlanır ise (Cevap Evet İse) silme işlemini yapıyoruz.
                db.Personel.Remove(p);

                //Değişiklikleri kaydediyoruz
                db.SaveChanges();

                // Veri tabanına personelleri basıyoruz.
                dataGridViewPersonel.DataSource = db.Personel.ToList();

                // Kullanıcının data girdiği nesneleri temizliyoruz.
                txtAd.Text = txtSoyad.Text = txtTelefon.Text = null;
            }
        }
    }
}
