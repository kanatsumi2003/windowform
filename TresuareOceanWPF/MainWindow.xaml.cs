using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TreasureOceanBusinessObjects;
using TreasureOceanService;

namespace TresuareOceanWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ICountryService iCountryServices;
        private readonly ISeaAreaService _seaAreaService;
        public MainWindow()
        {
            InitializeComponent();
                iCountryServices = new CountryService();
                _seaAreaService = new SeaAreasService();
        }

        private void btn_close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            List<Country> countries = iCountryServices.GetCountries();
            txtCountry.ItemsSource = countries;
            txtCountry.DisplayMemberPath = "Name";
            txtCountry.SelectedValuePath = "Id";
            dgv_seaAreas.ItemsSource = _seaAreaService.GetAllSeaAreas();
            dgv_seaAreas.Items.Refresh();
        }

        private void dgv_seaAreas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SeaAreas row_list = (SeaAreas) dgv_seaAreas.SelectedItem;
            if(row_list != null)
            {
                int seaId = row_list.SeaID;
                SeaAreas seaAreas = _seaAreaService.GetSeaAreas(seaId);

                txtSeaID.Text = seaAreas.SeaID.ToString();
                txtFee.Text = seaAreas.Fee.ToString();
                txtSeaName.Text = seaAreas.SeaName.ToString();
                txtTreasure.Text = seaAreas.Treasure.ToString();
                txtCountry.SelectedValue = seaAreas.CountryID;
            }
        }

        private void btnCreate(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(txtCountry.SelectedValue.ToString());
            int seaID = int.Parse(txtSeaID.Text);
            string seaName = txtSeaName.Text;
            int fee = int.Parse(txtFee.Text);
            int treasure = int.Parse(txtTreasure.Text);
            int countryId = int.Parse(txtCountry.SelectedValue.ToString());
            SeaAreas seaAreas = new SeaAreas{
                SeaID = seaID,
                SeaName = seaName,
                CountryID = countryId,
                Fee = fee,
                Treasure = treasure,
            };
            _seaAreaService.CreateSeaAreas(seaAreas);
            dgv_seaAreas.ItemsSource = _seaAreaService.GetAllSeaAreas();
            dgv_seaAreas.Items.Refresh();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            int seaId = int.Parse(txtSeaID.Text);
            _seaAreaService.DeleteSeaAreas(seaId);
            dgv_seaAreas.Items.Refresh();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(txtCountry.SelectedValue.ToString());
            int seaID = int.Parse(txtSeaID.Text);
            string seaName = txtSeaName.Text;
            int fee = int.Parse(txtFee.Text);
            int treasure = int.Parse(txtTreasure.Text);
            int countryId = int.Parse(txtCountry.SelectedValue.ToString());
            SeaAreas seaAreas = new SeaAreas
            {
                SeaID = seaID,
                SeaName = seaName,
                CountryID = countryId,
                Fee = fee,
                Treasure = treasure,
            };
            _seaAreaService.UpdateSeaAreas(seaAreas);
            dgv_seaAreas.ItemsSource = _seaAreaService.GetAllSeaAreas();
            dgv_seaAreas.Items.Refresh();
        }
    }
}
