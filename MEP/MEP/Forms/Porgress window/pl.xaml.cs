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

namespace MEP.Forms.Porgress_window
{
    /// <summary>
    /// Interaction logic for pl.xaml
    /// </summary>
    public partial class pl : Window
    {
       
        public pl()
        {
            // bool t=false;
            InitializeComponent();
            button.IsEnabled = false; 
           // this.Show();
           // text.Text = "The new Binaries are being generated,please be patient.....";
           // button.IsEnabled = false;
           //t =true;
            //text.Text = "The new Binaries are being generated,please be patient.....";
           //utton.IsEnabled = false;
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            //text.Text = "The new Binaries are being generated,please be patient.....";
            //button.IsEnabled = false;
        }
        public void oncodeFinish()
        {
            text.Text = "The new Binaries have been generated and your selected mods installed,have a fun time playing WFaS ^.^";
            button.IsEnabled = true;
            
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
          
            
            

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
          //  text.Text = "The new Binaries are being generated,please be patient.....";
            //button.IsEnabled = false;
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            //t = true;
        }

       private void Grid_Initialized(object sender, EventArgs e)
        {
          //  text.Text = "The new Binaries are being generated,please be patient.....";
            //button.IsEnabled = false;
        }
    }
}
