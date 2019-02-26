using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace LogIn
{
    /// <summary>
    /// Lógica de interacción para Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {

        SqlConnection sqlCon = new SqlConnection(@"Data Source=desktop-55cvci7\tew_sqlexpress;Initial Catalog=LoginDB; Integrated Security=True;");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;

        public Dashboard()
        { 
            InitializeComponent();
            showdata();
            this.DataContext = new WindowViewModel(this);
        }
        public ApplicationPages CurrentPage { get; set; } = ApplicationPages.LogIn;

        public void showdata()
        {
            adpt = new SqlDataAdapter("SELECT * FROM LoginDB",  sqlCon);
            dt = new DataTable();
            adpt.Fill(dt);
           tabla.ItemsSource = dt.DefaultView;
        }
    }
}
