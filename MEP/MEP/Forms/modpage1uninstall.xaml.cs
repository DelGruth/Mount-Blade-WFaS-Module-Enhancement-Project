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
    /// Interaction logic for modpage1uninstall.xaml
    /// </summary>
    public partial class modpage1uninstall : Window
    {
        //declare all variables
        bool isClickedCombatAnimation = false;
        bool isClickedBlood = false;
        bool isfaceimprovmentclicked = false;
        bool isExpandedHorizonclicked = false;
        bool isColorsclicked = false;
        bool GenerateCombatAnimationtext = false;
        bool GenerateBloodParticles = false;
        bool GenerateFaceImprovmentProject = false;
        bool ExpandedHorizon = false;
        bool Generatecolors = false;


        public modpage1uninstall()
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MEP.Forms.InformationModdisplay.Window1 w1 = new MEP.Forms.InformationModdisplay.Window1();

            w1.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Hide();
                Directory.customdirectory n19 = new Directory.customdirectory();
                n19.ShowDialog();
                MEP.Code.Binary_Generator.Directory.DetermineDirectory n7 = new Code.Binary_Generator.Directory.DetermineDirectory();
                string filepath = n7.DetermineDirectory1();
                MEP.Forms.Porgress_window.pl p1 = new MEP.Forms.Porgress_window.pl();
              
               
                p1.Show();
                   MessageBox.Show("The following Directory is being used: " + filepath );
                   string GeneratedModuleini = @"./Generated/module.ini";
                   string filePath = GeneratedModuleini;
                    StreamWriter n4 = new StreamWriter(@"./Install/uninstall.ini", false);
              
                //ALl new mods should be added here 
                    n4.WriteLine(GenerateCombatAnimationtext.ToString());
                    n4.WriteLine(GenerateBloodParticles.ToString());
                    n4.WriteLine(GenerateFaceImprovmentProject.ToString());
                    n4.WriteLine(ExpandedHorizon.ToString());
                    n4.WriteLine(Generatecolors.ToString());
                    n4.Close();
                    StreamWriter n5 = new StreamWriter(@"./Install/install.ini", false);
                    n5.WriteLine("False");
                    n5.Close();
                
                
                
                //also add the mods definitions here since we don't use the
                //main loop for the uninstalling
                    MEP.Code.Binary_Generator.Mods.Combat_Animation_Enhancement n1 = new Code.Binary_Generator.Mods.Combat_Animation_Enhancement();
                    MEP.Code.Binary_Generator.Mods.Blood_Particles n2 = new Code.Binary_Generator.Mods.Blood_Particles();
                    MEP.Code.Binary_Generator.Mods.Face_Improvement_Project n3 = new Code.Binary_Generator.Mods.Face_Improvement_Project();
                    MEP.Code.Binary_Generator.Mods.Expaned_Horizons n10 = new Code.Binary_Generator.Mods.Expaned_Horizons();
                    MEP.Code.Binary_Generator.Mods.Realistic_Colors n11 = new Code.Binary_Generator.Mods.Realistic_Colors();

                //if the mods uninstall all at once then add checkers accordingly 
                    StreamReader n6 = new StreamReader(@"./Install/uninstall.ini");
                    string genACE = n6.ReadLine();
                    string genBloodpar = n6.ReadLine();
                    string genfaceimprovments = n6.ReadLine();
                    string expandedhorizons = n6.ReadLine();
                string gencolor=n6.ReadLine();
                    n6.Close();
                    string Reader = File.ReadAllText(filepath + @"/module.ini");
                    File.WriteAllText(@"./Generated/module.ini", Reader);
                    if (genACE == "True")
                    {
                        n1.Editor();
                        File.Delete(filepath + @"/Resource/Skeletons.brf");
                        string searchText = "load_mod_resource = skeletons";
                        string replaceText = "load_resource = skeletons";
                       // File.Copy(GeneratedModuleini, filepath + @"/module.ini", true);

                        ReplaceInFile(filePath, searchText, replaceText);
                        //So far this is the only mod whichs uses the action.txt
                        //remember to add to the end of code execution if
                        //another mod uses actions.txt
                        File.Copy(@"./Generated/actions.txt", filepath + @"/actions.txt", true);

                    }
                    if (genBloodpar == "True")
                    {
                        n2.Editor();
                        //only mod which modifies the particle_systems.txt
                        //if one more mod uses it then add at the end of code
                        //exuection
                        File.Copy(@"./Generated/particle_systems.txt", filepath + @"/particle_systems.txt", true);
                    }
                    if (genfaceimprovments == "True")
                    {
                    n3.Editor();
                    string searchText = "load_resource = textures_face_gen";
                    string replaceText = "load_mod_resource = textures_face_gen";
                    ReplaceInFile(filePath, replaceText, searchText);
                    searchText = "load_resource = materials_face_gen";
                    replaceText = "load_mod_resource = materials_face_gen";
                    ReplaceInFile(filePath, replaceText, searchText);
                    searchText = "load_resource = meshes_face_gen";
                    replaceText = "load_mod_resource = meshes_face_gen";
                    ReplaceInFile(filePath, replaceText, searchText);
                    searchText = "load_resource = beards";
                    replaceText = "load_mod_resource = beards";
                    ReplaceInFile(filePath, replaceText, searchText);
                    searchText = "load_resource = hair";
                    replaceText = "load_mod_resource = hair";
                    ReplaceInFile(filePath, replaceText, searchText);
                        
                    }
                if(expandedhorizons =="True")
                {
                    n10.editor();
                    string searchText = "load_resource = terrain_borders";
                    string replacetext = "load_mod_resource = op_terrain_borders_textures\r\nload_mod_resource = op_terrain_borders_materials";
                    ReplaceInFile(filePath, replacetext, searchText);
                    searchText = "load_resource = terrain_borders_b";
                    replacetext = "load_mod_resource = op_terrain_borders\r\nload_mod_resource = op_terrain_borders_b";
                    ReplaceInFile(filePath, replacetext, searchText);
                }
                if(gencolor =="True")
                {
                    n11.editor();
                    string searchText = "load_resource = grass_meshes";
                    string replacetext = "load_mod_resource = grass_meshes";
                    ReplaceInFile(filePath, replacetext, searchText);
                    searchText = "load_resource = grass_meshes_b";
                    replacetext = "load_mod_resource = grass_meshes_b";
                    ReplaceInFile(filePath, replacetext, searchText);
                    
                }

                    File.Copy(GeneratedModuleini, filepath + @"/module.ini", true);
                                 
                    p1.oncodeFinish();
                    this.Close();
              
            }
            catch (Exception f)
            {
                
                Console.WriteLine(f.ToString());
                MessageBox.Show(f.ToString());
                Code.Logger.Logger.Loggeradd(f.ToString());

            }
            
           
            
        }
        static public void ReplaceInFile(string filePath, string searchText, string replaceText)
        {
            try
            {
                StreamReader reader = new StreamReader(filePath);
                string content = reader.ReadToEnd();
                reader.Close();

                content = System.Text.RegularExpressions.Regex.Replace(content, searchText, replaceText);

                StreamWriter writer = new StreamWriter(filePath, false);
                writer.Write(content);
                writer.Close();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.ToString());
                MessageBox.Show(e.ToString());
                Code.Logger.Logger.Loggeradd(e.ToString());

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
                GenerateBloodParticles = true;

            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Forms.InformationModdisplay.Window2 n1 = new Forms.InformationModdisplay.Window2();
            n1.ShowDialog();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
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

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            InformationModdisplay.Window3 n1 = new InformationModdisplay.Window3();
            n1.ShowDialog();

        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            
            
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (isExpandedHorizonclicked == false)
            {
                //button1.Background = new SolidColorBrush(Colors.White);
                button10.Opacity = 0.50;
                isExpandedHorizonclicked = true;
                // GenerateCombatAnimationtext = true;
                ExpandedHorizon = true;


            }
            else if (isExpandedHorizonclicked == true)
            {
                //button1.Background = new SolidColorBrush(Colors.White);
                button10.Opacity = 1;
                isExpandedHorizonclicked = false;
                // GenerateCombatAnimationtext = false;
                ExpandedHorizon = false;

            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Forms.InformationModdisplay.Window4 n1 = new InformationModdisplay.Window4();
            n1.ShowDialog();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
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

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            Forms.InformationModdisplay.Window5 n1 = new InformationModdisplay.Window5();
            n1.ShowDialog();
        }

       

        

    }
}
