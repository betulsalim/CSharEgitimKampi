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
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }

        EgitimKampiEFTravelDbEntities EgitimKampiEFTravelDbEntities = new EgitimKampiEFTravelDbEntities();

        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            #region Toplam Lokasyon Sayısı

            LblLocationCount.Text = EgitimKampiEFTravelDbEntities.Tbl_Location.Count().ToString();


            #endregion

            #region Toplam Kapasite

            LblSumCapacity.Text = EgitimKampiEFTravelDbEntities.Tbl_Location.Sum(x => x.location_capacity).ToString();

            #endregion

            #region Toplam Rehber Sayısı

            LblGuideCount.Text = EgitimKampiEFTravelDbEntities.Tbl_Guide.Count().ToString();

            #endregion

            #region Ortalama Kapasite

            LblAverageCapacity.Text = EgitimKampiEFTravelDbEntities.Tbl_Location.Average(x => x.location_capacity).ToString();

            #endregion

            #region Ortalama Tur Fiyatı

            var averagePrice = EgitimKampiEFTravelDbEntities.Tbl_Location
            .Where(y => y.location_price.HasValue)
            .Average(y => y.location_price.Value);

            LblAverageTourPrice.Text = averagePrice.ToString("F2") + " ₺";


            #endregion

            #region Eklenen Son Ülke

            int lastCountryId = EgitimKampiEFTravelDbEntities.Tbl_Location.Max(x => x.location_id);
            LblAddLastCountry.Text = EgitimKampiEFTravelDbEntities.Tbl_Location.Where(x => x.location_id == lastCountryId).Select(y => y.location_country).FirstOrDefault();


            #endregion

            //kapadokyayı sildiğim için milano yaptım
            #region Milano Bazında Kapasite

            LblCapacityCityMilano.Text = EgitimKampiEFTravelDbEntities.Tbl_Location.Where(x => x.location_city == "Milano").Select(y => y.location_capacity).FirstOrDefault().ToString();


            #endregion
            
            #region Türkiye Bazında Ortalama Kapasite
            LblAverageCapacityTurkey.Text = EgitimKampiEFTravelDbEntities.Tbl_Location.Where(x => x.location_country == "Türkiye").Average(y => y.location_capacity).ToString();
            #endregion

            #region Roma Gezisinin Rehberinin İsmi

            var romeGuideId = EgitimKampiEFTravelDbEntities.Tbl_Location.Where(x => x.location_city == "Roma").Select(y => y.guide_id).FirstOrDefault();
            LblNameOfTheRomaTour.Text = EgitimKampiEFTravelDbEntities.Tbl_Guide.Where(x => x.guide_id == romeGuideId).Select(y => y.guide_name + " " + y.guide_surname).FirstOrDefault();

            #endregion

            #region en yüksek kapariteli tur

            var maxCapacity = EgitimKampiEFTravelDbEntities.Tbl_Location.Max(x => x.location_capacity);
            lblMaxCapacityTour.Text = EgitimKampiEFTravelDbEntities.Tbl_Location.Where(x => x.location_capacity == maxCapacity).Select(y => y.location_city).FirstOrDefault().ToString();

            #endregion

            #region en pahalı tur

            var maxPrice = EgitimKampiEFTravelDbEntities.Tbl_Location.Max(x => x.location_price);
            lblMaxPriceTour.Text = EgitimKampiEFTravelDbEntities.Tbl_Location.Where(x => x.location_price == maxPrice).Select(y => y.location_city).FirstOrDefault().ToString();

            #endregion

            #region Ayşegül Çınarın Tur Sayısı

            var guideIdA = EgitimKampiEFTravelDbEntities.Tbl_Guide.Where(x => x.guide_name == "Ayşegül" && x.guide_surname == "Çınar").Select(y => y.guide_id).FirstOrDefault();
            LblAysegulTourCount.Text = EgitimKampiEFTravelDbEntities.Tbl_Location.Where(x => x.guide_id == guideIdA).Count().ToString();

            #endregion

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
