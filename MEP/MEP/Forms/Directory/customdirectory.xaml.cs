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
using System.Windows.Shapes;

namespace MEP.Forms.Directory
{
    /// <summary>
    /// Interaction logic for customdirectory.xaml
    /// </summary>
    public partial class customdirectory : Window
    {
        public customdirectory()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            selectdirectory n1 = new selectdirectory();
            
            this.Close();
            n1.ShowDialog();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
