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

namespace MEP.Forms
{
    /// <summary>
    /// Interaction logic for modpage1.xaml
    /// </summary>
    public partial class modpage1 : Window
    {
        //declare all variables
        bool isClickedCombatAnimation = false;
        bool isClickedBlood = false;
        bool isfaceimprovmentclicked = false;
        bool isExpandedHorizonclicked = false;
        bool isColorsclicked = false;
        bool GenerateCombatAnimationtext =false;
        bool GenerateBloodParticles = false;
        bool GenerateFaceImprovmentProject = false;
        bool ExpandedHorizon = false;
        bool Generatecolors = false;
        public modpage1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {


            if (isClickedCombatAnimation == false)
            {
                //button1.Background = new SolidColorBrush(Colors.White);
                button1.Opacity = 0.50;
                isClickedCombatAnimation = true;
                GenerateCombatAnimationtext = true;


            }
            else if (isClickedCombatAnimation == true)
            {
                //button1.Background = new SolidColorBrush(Colors.White);
                button1.Opacity = 1;
                isClickedCombatAnimation = false;
                GenerateCombatAnimationtext = false;


            }
            
                
            }

        private void button1_MouseDown(object sender, MouseButtonEventArgs e)
        {
           

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MEP.Forms.InformationModdisplay.Window1 w1 = new MEP.Forms.InformationModdisplay.Window1();

                w1.ShowDialog();
            }
            catch (Exception f)
            {

                Console.WriteLine(f.ToString());
                MessageBox.Show(f.ToString());
                Code.Logger.Logger.Loggeradd(f.ToString());

            }
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                StreamWriter n4 = new StreamWriter(@"./Install/install.ini", false);
                
                //use this to write wether or not to add a mod,new mods should be 
                //added accordingly
                n4.WriteLine(GenerateCombatAnimationtext.ToString());
                n4.WriteLine(GenerateBloodParticles.ToString());
                n4.WriteLine(GenerateFaceImprovmentProject.ToString());
                n4.WriteLine(ExpandedHorizon.ToString());
                n4.WriteLine(Generatecolors.ToString());
                n4.Close();
                StreamWriter n5 = new StreamWriter(@"./Install/uninstall.ini", false);
                n5.WriteLine("False");
                n5.Close();
                MEP.Forms.AfterModsSelection.ModsConfirmation n = new MEP.Forms.AfterModsSelection.ModsConfirmation();




                this.Close();
                n.ShowDialog();
            }
            catch (Exception f)
            {

                Console.WriteLine(f.ToString());
                MessageBox.Show(f.ToString());
                Code.Logger.Logger.Loggeradd(f.ToString());

            }
            
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (isClickedBlood == false)
            {
                //button1.Background = new SolidColorBrush(Colors.White);
                button2.Opacity = 0.50;
                isClickedBlood = true;
               // GenerateCombatAnimationtext = true;
                GenerateBloodParticles = true;


            }
            else if (isClickedBlood == true)
            {
                //button1.Background = new SolidColorBrush(Colors.White);
                button2.Opacity = 1;
                isClickedBlood = false;
               // GenerateCombatAnimationtext = false;
                GenerateBloodParticles = false;

            }
            
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Forms.InformationModdisplay.Window2 n1 = new InformationModdisplay.Window2();
            n1.ShowDialog();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (isfaceimprovmentclicked == false)
            {
                //button1.Background = new SolidColorBrush(Colors.White);
                button3.Opacity = 0.50;
                isfaceimprovmentclicked = true;
               // GenerateCombatAnimationtext = true;
                GenerateFaceImprovmentProject = true;

                
            }
            else if (isfaceimprovmentclicked == true)
            {
                //button1.Background = new SolidColorBrush(Colors.White);
                button3.Opacity = 1;
                isfaceimprovmentclicked = false;
               // GenerateCombatAnimationtext = false;
                GenerateFaceImprovmentProject = false;

            }
            
        
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            InformationModdisplay.Window3 n1 = new InformationModdisplay.Window3();
            n1.ShowDialog();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (isExpandedHorizonclicked == false)
            {
                //button1.Background = new SolidColorBrush(Colors.White);
                button4.Opacity = 0.50;
                isExpandedHorizonclicked = true;
                // GenerateCombatAnimationtext = true;
                ExpandedHorizon = true;


            }
            else if (isExpandedHorizonclicked == true)
            {
                //button1.Background = new SolidColorBrush(Colors.White);
                button4.Opacity = 1;
                isExpandedHorizonclicked = false;
                // GenerateCombatAnimationtext = false;
                ExpandedHorizon = false;

            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            InformationModdisplay.Window4 n1 = new InformationModdisplay.Window4();
            n1.ShowDialog();
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            if (isColorsclicked == false)
            {
                //button1.Background = new SolidColorBrush(Colors.White);
                button5.Opacity = 0.50;
                isColorsclicked = true;
                // GenerateCombatAnimationtext = true;
                Generatecolors = true;


            }
            else if (isColorsclicked == true)
            {
                //button1.Background = new SolidColorBrush(Colors.White);
                button5.Opacity = 1;
                isColorsclicked = false;
                // GenerateCombatAnimationtext = false;
                Generatecolors = false;

            }
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            Forms.InformationModdisplay.Window1 n1 = new InformationModdisplay.Window1();
            n1.ShowDialog();
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            Forms.InformationModdisplay.Window2 n1 = new InformationModdisplay.Window2();
            n1.ShowDialog();
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            Forms.InformationModdisplay.Window3 n1 = new InformationModdisplay.Window3();
            n1.ShowDialog();
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            Forms.InformationModdisplay.Window4 n1 = new InformationModdisplay.Window4();
            n1.ShowDialog();
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            Forms.InformationModdisplay.Window5 n1 = new InformationModdisplay.Window5();
            n1.ShowDialog();
        }
            
        }

    

    
    }

