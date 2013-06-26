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

namespace BeszallitomSupApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DAL.ProductApi api = new DAL.ProductApi("http://192.168.56.101:8080",tbToken.Text);
            try
            {
                DAL.Product adat = api.GetProduct(tbId.Text);
                tbName.Text = adat.Name;
                tbPrice.Text = adat.Price + " Ft / " + adat.Unit;
                tbSize.Text = adat.Size + " " + adat.Unit;
                tbSupplier.Text = adat.Supplier;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Hiba!");
            }
            
        }
    }
}
