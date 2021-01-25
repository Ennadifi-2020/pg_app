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
using System.Data.SqlClient;
using System.Data;
using System.Xaml.Permissions;



namespace G_A
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
     
        }

        

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-OBGBC0O\SQLEXPRESS;Initial Catalog=AttendanceManagement;Integrated Security=True");


                SqlCommand cmd;
                SqlDataAdapter da;
                SqlDataReader dr;
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                conn.Open();
                //SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-OBGBC0O\SQLEXPRESS;Initial Catalog=AttendanceManagement; Integrated Security=True");
                //cmd = new SqlCommand("select * from Users", conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from Users", conn);
                dataAdapter.Fill(ds);
                DGV.ItemsSource = ds.Tables[0].DefaultView;




                //dr = cmd.ExecuteReader();
                //dt.Load(dr);
                //DGV.ItemsSource = dt.DefaultView;
                //conn.Close();
            }
            catch (Exception)
            {

                throw;
            }
            /*this.fillingDataGidUsingDataTable();*/
        }

        private void btn_absent_Click(object sender, RoutedEventArgs e)
        {

        }

        private void dg_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
         
        }

        private void DGV_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}