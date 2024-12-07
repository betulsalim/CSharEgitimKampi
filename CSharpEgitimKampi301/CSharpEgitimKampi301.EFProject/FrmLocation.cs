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
    public partial class FrmLocation : Form
    {
        public FrmLocation()
        {
            InitializeComponent();
        }
        EgitimKampiEFTravelDbEntities EgitimKampiEFTravelDbEntities = new EgitimKampiEFTravelDbEntities();
        Tbl_Location Tbl_Location = new Tbl_Location();
        private void BtnListele_Click(object sender, EventArgs e)
        {
            var values = EgitimKampiEFTravelDbEntities.Tbl_Location.ToList();
            dataGridView1.DataSource = values;
        }

        private void FrmLocation_Load(object sender, EventArgs e)
        {
            var values = EgitimKampiEFTravelDbEntities.Tbl_Guide.Select(x => new
            {
                FullName = x.guide_name + " " + x.guide_surname,
                x.guide_id
            }).ToList();
            CmbRehber.DisplayMember = "FullName";
            CmbRehber.ValueMember = "guide_id";
            CmbRehber.DataSource = values;
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            Tbl_Location.location_city = TxtSehir.Text;
            Tbl_Location.location_country = TxtUlke.Text;
            Tbl_Location.location_price = decimal.Parse(TxtFiyat.Text);
            Tbl_Location.location_capacity = byte.Parse(NmcKapasite.Value.ToString());
            Tbl_Location.DayNight = TxtGunGece.Text;
            Tbl_Location.guide_id = int.Parse(CmbRehber.SelectedValue.ToString());
            EgitimKampiEFTravelDbEntities.Tbl_Location.Add(Tbl_Location);
            EgitimKampiEFTravelDbEntities.SaveChanges();
            MessageBox.Show("Tur Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = EgitimKampiEFTravelDbEntities.Tbl_Location.ToList();
            dataGridView1.DataSource = values;
        }

       

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtId.Text);
            var deletedValue = EgitimKampiEFTravelDbEntities.Tbl_Location.Find(id);
            EgitimKampiEFTravelDbEntities.Tbl_Location.Remove(deletedValue);
            EgitimKampiEFTravelDbEntities.SaveChanges();
            MessageBox.Show("Tur Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = EgitimKampiEFTravelDbEntities.Tbl_Location.ToList();
            dataGridView1.DataSource = values;
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtId.Text);
            var updatedValue = EgitimKampiEFTravelDbEntities.Tbl_Location.Find(id);
            updatedValue.location_city = TxtSehir.Text;
            updatedValue.location_country = TxtUlke.Text;
            updatedValue.location_price = decimal.Parse(TxtFiyat.Text);
            updatedValue.location_capacity = byte.Parse(NmcKapasite.Value.ToString());
            updatedValue.DayNight = TxtGunGece.Text;
            updatedValue.guide_id = int.Parse(CmbRehber.SelectedValue.ToString());
            EgitimKampiEFTravelDbEntities.Tbl_Location.Add(Tbl_Location);
            EgitimKampiEFTravelDbEntities.SaveChanges();
            MessageBox.Show("Tur Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = EgitimKampiEFTravelDbEntities.Tbl_Location.ToList();
            dataGridView1.DataSource = values;
        }

        private void BtnIdFilterGetir_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtId.Text);
            var values = EgitimKampiEFTravelDbEntities.Tbl_Location.Where(x => x.location_id == id).ToList();
            dataGridView1.DataSource = values;
        }
    }
}
