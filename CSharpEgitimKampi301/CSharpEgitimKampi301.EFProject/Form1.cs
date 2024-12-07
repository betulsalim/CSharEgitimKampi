using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        EgitimKampiEFTravelDbEntities db = new EgitimKampiEFTravelDbEntities();
        Tbl_Guide tbl_Guide = new Tbl_Guide();
        private void BtnListele_Click(object sender, EventArgs e)
        {
            
            var values = db.Tbl_Guide.ToList();
            dataGridView1.DataSource = values;
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            
            tbl_Guide.guide_name = TxtAd.Text;
            tbl_Guide.guide_surname = TxtSoyad.Text;
            db.Tbl_Guide.Add(tbl_Guide);
            db.SaveChanges();
            MessageBox.Show("Rehber Eklendi" , "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = db.Tbl_Guide.ToList();
            dataGridView1.DataSource = values;
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtId.Text);
            var removeValue = db.Tbl_Guide.Find(id);
            db.Tbl_Guide.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Rehber Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = db.Tbl_Guide.ToList();
            dataGridView1.DataSource = values;
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse (TxtId.Text);
            var updateValue = db.Tbl_Guide.Find(id);
            updateValue.guide_name = TxtAd.Text;
            updateValue.guide_surname= TxtSoyad.Text;
            db.SaveChanges();
            MessageBox.Show("Rehber Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = db.Tbl_Guide.ToList();
            dataGridView1.DataSource = values;
        }

        private void BtnIdFilterGetir_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtId.Text);
            var values = db.Tbl_Guide.Where(x => x.guide_id == id).ToList();
            dataGridView1.DataSource = values;

        }
    }
}
