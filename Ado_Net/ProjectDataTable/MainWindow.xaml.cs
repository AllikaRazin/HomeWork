using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
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
using System.Configuration;

namespace ProjectDataTable
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SqlDataReader reader;
        private DataTable table;
        private SqlConnection conn;

        string cs = "";
        public MainWindow()
        {
            InitializeComponent();
            conn = new SqlConnection();
            cs = ConfigurationManager.
            ConnectionStrings["MyConnString"].
            ConnectionString;
            conn.ConnectionString = cs;
        }

        private void Exec_Click(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
