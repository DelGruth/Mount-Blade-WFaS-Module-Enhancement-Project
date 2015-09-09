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
using System.Net;
using MEP.Code.VersionControl;
using System.IO;


namespace MEP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
  
    public partial class MainWindow : Window
    {
        CurrentSoftwareVersion csv = new CurrentSoftwareVersion();
        versionchecker vc = new versionchecker();
        bool UpdateOrContinue = false;
        private string url = "https://bitbucket.org/WFaSmep/m.e.p./wiki/Home";
        
        
        
        public MainWindow()
        {
            try
                //NEXT TO DO IS THE SKIN.TXT 

            {
                InitializeComponent();
            //    ResourceDictionary skin = new ResourceDictionary();
            //    skin.Source = new Uri(@"Themes/Metro/Dark/MetroDark.MSControls.Core.Implicit.xaml", UriKind.Absolute);
            //    App.Current.Resources.MergedDictionaries.Add(skin); 
                if (File.Exists(@"./Generated/module.ini"))
                File.Delete(@"./Generated/module.ini");
                if (File.Exists(@"./Generated/actions.txt"))
                File.Delete(@"./Generated/actions.txt");
                if (File.Exists(@"./Generated/Directory.ini"))
                File.Delete(@"./Install/Directory.ini");
                if (File.Exists(@"./Generated/particle_systems.txt"))// Forms.Directory.selectdirectory n1 = new Forms.Directory.selectdirectory();
                File.Delete(@"./Generated/particle_systems.txt");
                // n1.ShowDialog();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }

        private void updated_Loaded(object sender, RoutedEventArgs e)
        {
            if (File.Exists(@"./Generated/module.ini"))
            File.Delete(@"./Generated/module.ini");
            if (File.Exists(@"./Generated/actions.txt"))
            File.Delete(@"./Generated/actions.txt");
            if (File.Exists(@"./Install/install.ini"))
            File.Delete(@"./Install/install.ini");
            if (File.Exists(@"./Install/uninstall.ini"))
            File.Delete(@"./Install/uninstall.ini");
          
                WebClient wc = new WebClient();
               // string version = wc.DownloadString("https://bbuseruploads.s3.amazonaws.com/WFaSmep/m.e.p./downloads/version.txt?Signature=9PyB5%2BvudgOXWuK7AonGXO0Gx28%3D&Expires=1408064200&AWSAccessKeyId=0EMWEFSGA12Z1HF1TZ82");
                string updateNotes = "";//wc.DownloadString("https://dl.boxcloud.com/bc/4/ead68dd8d835cc8cd6371b5a54c2e765/sChWgfmNIYXJs9NN2cEtqz0fHUEsWaSKAqcTUSgZzIZ1vv0WOxmG185f-LpLykH-dfz-SK1Sm_nHBFE5W7llLC6A4SxcJul5kWvWCcq9R-Rd6dy1DKGQwWXGDLsEczyW0EWsdvUy0gHnDN-hOKqAJRwgG_NNM1pxFsLfq9lpCupAYdcWFyfFN4vE9kEHh_e7gRAS1ZqEloA4GerIQQ47oDqcR1BfmJbV0SZ9sJapB2st-fRgdCKYWwpMHMB-jRaIABxEEbvhUbF6eNk9L_x8fJWKYGsIJinmXsIFAm4wSd288dbGux3DwN3a22dDhfRYlnj6iiqMovyTL16g0h3ytuLzQtpm4oSv0hhK1TNIYhvtIkD56yIhfpPTiodur3mmkRQx1TU9-VpsnyZdXnWthSglIVj51WeMDR7mZro7M9XOfEm7Sev43TP9C5na1uia32Che7gYAyDBedmTujZ_iw7XyurbW52HBaYXueGR6Wdl7XSZ8kj_M5jeGRu7Dp-EkpWPu15daByyUzujlyFi3J1ywNccxOX44iCEkS01U_8CsGmQkyy9JLs5fVoe_ZpMh-hcyYuprx32gUwJLXrrVM8d_GHkOx8zhcc7wkHnGLty8bNBiIhq4YKDuhEPYrT0S4-f-y7Dupz90IPlJkuTZMVztp1kPS7ne4OmXAAunPpyLbAqE_m2qzRsEpzsPy2CsPdMrFICjh_vpWNtDZZCVRLz3el01CK1Wtr4CsEmTjKYcKtIiUogfm4vLHxuA4ASuJKkEzE_Mp62p4-QgqQUyZqrmqisJrcOxDE-0CgCSqYEmRGbRc1yuLAakQ8UTRWqkNsjkwJlJzK5NJORgGBeMgaw9yKpLt1fk9WI7vSN0Icrok5QS2f4k_x177mNH_5VheOet55yDpJ06qViK48teB6w6odtJNvcqNolH7AOR8kRw6g3AjZ7P3-ZRoM7D6fZiykQ-y1vygyWmnp9xCJKXMzqhylFzP4REvWBiXl86fyjc79Op8OJoTeYpxc87UY_BFCkDMzTb1sNNb4An9TReQ0s_J3N3hUE8luq-Wp_nf7Odbs6aYg4qJ1BX6IW1gVU0Iu7ybo3Q1E./");
                string version = "v0110a";
                   updated.Text = ("The latest version is: " + version
                   + "\r\nYour current version is: " + csv.Version + "\r\n\r\n" + version + " Patch Notes: \r\n" + updateNotes);
            
           
        }

        private void buttonUpdatecontinue_Click(object sender, RoutedEventArgs e)
        {
            if(UpdateOrContinue==true){
         //     MEP.Code.UI.Continue1 c1 = new MEP.Code.UI.Continue1();
              //this.Hide();
           //   c1.Continue();
                MEP.Forms.Selection.userSelection c1 = new MEP.Forms.Selection.userSelection();
                this.Close();
                c1.ShowDialog();
                
              



                
            }
            else if (UpdateOrContinue ==false)
            {

                System.Diagnostics.Process.Start("https://bitbucket.org/WFaSmep/m.e.p./wiki/Download");


            }
           
        
           
        }

        private void buttonUpdatecontinue_Loaded(object sender, RoutedEventArgs e)
        {
              bool uon = vc.UptodateorNot();
            if (uon ==true)
            {
                buttonUpdatecontinue.Content = "Continue";
                UpdateOrContinue = true;
            }

            else if (uon==false)
            {
                buttonUpdatecontinue.Content = "Update";
                

            }
            else if(uon!=false && uon!=true){

                Console.WriteLine("Failed to check versions,bool ==null");
                UpdateOrContinue = false;
            }
            else
            {
                updated.Text = ("Connection could not be established....");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown(0);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            System.Diagnostics.Process.Start(url);
        }
        
        
       


    }
}
