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
using System.IO;

namespace MEP.Forms.Selection
{
    /// <summary>
    /// Interaction logic for userSelection.xaml
    /// </summary>
    public partial class userSelection : Window
    {
        public userSelection()
        {
            InitializeComponent();
            optwfas.IsEnabled = false;
            this.Closing += new System.ComponentModel.CancelEventHandler(MainWindow_Closing);
        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (File.Exists(@"./Generated/module.ini"))
                File.Delete(@"./Generated/module.ini");
            if (File.Exists(@"./Generated/actions.txt"))
                File.Delete(@"./Generated/actions.txt");
            if (File.Exists(@"./Install/Directory.ini"))
                File.Delete(@"./Install/Directory.ini");
            if (File.Exists(@"./Generated/particle_systems.txt"))// Forms.Directory.selectdirectory n1 = new Forms.Directory.selectdirectory();
                File.Delete(@"./Generated/particle_systems.txt");
            if (File.Exists(@"./Install/install.ini"))
                File.Delete(@"./Install/install.ini");
            if (File.Exists(@"./Install/uninstall.ini"))
                File.Delete(@"./Install/uninstall.ini");
          //  if (File.Exists(@"./Install/Directory.ini"))
           //     File.de
            Application.Current.Shutdown(0);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MEP.Code.UI.Continue1 c1 = new MEP.Code.UI.Continue1();
            //this.Hide();
            c1.Continue();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            modpage1uninstall c1 = new modpage1uninstall();
            //this.Hide();
            c1.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown(0);
        }

        private void optwfas_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Please include the logs.txt when reporting bugs,it can be found in the application directory");
            System.Diagnostics.Process.Start("https://bitbucket.org/WFaSmep/m.e.p./issues/new");
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://bitbucket.org/WFaSmep/m.e.p./wiki/Home");

        }
    }
}
