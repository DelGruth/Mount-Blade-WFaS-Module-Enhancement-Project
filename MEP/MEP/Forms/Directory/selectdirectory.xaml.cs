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
//using System.Windows.FileDialog;
using System.IO;

namespace MEP.Forms.Directory
{
    /// <summary>
    /// Interaction logic for selectdirectory.xaml
    /// </summary>
    public partial class selectdirectory : Window
    {
        string dirpath;
        bool isenabled;
        bool isenabled2;
        public selectdirectory()
        {
            InitializeComponent();
            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Window_Activated(object sender, EventArgs e)
        {
            
        }

        private void enterdir_TextChanged(object sender, TextChangedEventArgs e)
        {
            dirpath= enterdir.Text.ToString();
            
           // return dirpath;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                isenabled = true;
                
                //this.hide maybe
                //this.Hide();
                t1();
                

               // Console.WriteLine(enterdir.ToString() + "1");
                // return enterdir.ToString();

                // this.Close();
            }
            catch (Exception f)
            {

                MessageBox.Show(f.ToString());
                
            }
        }
        public string t1(){
            try
            {
               
                Console.WriteLine(dirpath);
                if (System.IO.Directory.Exists(dirpath) && dirpath.Contains(@"\Ogniem i Mieczem"))
                {
                    this.Close();
                    StreamWriter n1 = new StreamWriter(@"./Install/Directory.ini");
                    n1.WriteLine(dirpath);
                    n1.Close();
                    return dirpath;

                }
                else
                {
                    enterdir.Text = "Incorrect Directory,retry.";
                    
                }
                //if(System.IO.Directory.Exists(dirpath))
                return null;
                
                
            }
            catch(Exception f)
            {
                Console.WriteLine(f.ToString());
                MessageBox.Show(f.ToString());
                Code.Logger.Logger.Loggeradd(f.ToString());
                Application.Current.Shutdown();

                return dirpath;
            }
    }

    }
}
