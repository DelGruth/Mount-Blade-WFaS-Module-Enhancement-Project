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
using System.Text.RegularExpressions;
namespace MEP.Forms.AfterModsSelection
{
    /// <summary>
    /// Interaction logic for ModsConfirmation.xaml
    /// </summary>
    public partial class ModsConfirmation : Window
    {
        Porgress_window.pl p1 = new Porgress_window.pl();
        MEP.Code.Binary_Generator.Directory.DetermineDirectory n7 = new Code.Binary_Generator.Directory.DetermineDirectory();
        string gencat;
        string genblood;
        string genFaceImrpovmentProject;
        string expandedHorizon;
        string gencolors;
      
 public  ModsConfirmation(){
            InitializeComponent();
            

            DataGridTextColumn idcol = new DataGridTextColumn();
            DataGridTextColumn Namecol = new DataGridTextColumn();
            DataGridTextColumn Authorcol = new DataGridTextColumn();
            DataGridTextColumn MScol = new DataGridTextColumn();
            DataGridTextColumn Categorycol = new DataGridTextColumn();
            DataGridHyperlinkColumn linkcol = new DataGridHyperlinkColumn();
            idcol.Binding = new Binding("id");
            Namecol.Binding = new Binding("Name");
            Authorcol.Binding = new Binding("Author");
            MScol.Binding = new Binding("MS");
            Categorycol.Binding = new Binding("Category");
            linkcol.Binding = new Binding("link");
            idcol.Header = "ID";
            Namecol.Header = "Name";
            Authorcol.Header = "Author";
            MScol.Header = "Multiplayer/Singleplayer Compatibility";
            Categorycol.Header = "Category";
            linkcol.Header = "Link";
            idcol.Width = 30 ;
            Namecol.Width = 100;
            Authorcol.Width = 100;
            MScol.Width = 300;
            Categorycol.Width = 75;
            linkcol.Width = 50;
            datagridconfirmation.Columns.Add(idcol);
            datagridconfirmation.Columns.Add(Namecol);
            datagridconfirmation.Columns.Add(Authorcol);
            datagridconfirmation.Columns.Add(MScol);
            datagridconfirmation.Columns.Add(Categorycol);
            datagridconfirmation.Columns.Add(linkcol);
            StreamReader s1 = new StreamReader(@"./Install/install.ini");
             gencat = s1.ReadLine();
             genblood = s1.ReadLine();
             genFaceImrpovmentProject = s1.ReadLine();
             expandedHorizon = s1.ReadLine();
             gencolors = s1.ReadLine();
     
             s1.Close();
            
             if (gencat == "True")
             {  
                 DatagridAdderAfterSelection("0", "Combat Animation Enhancement", "Papa Lazarou", "http://forums.taleworlds.com/index.php/topic,134185.0.html", "Animations", "Both");
            
             }
             if (genblood == "True")
             {
                 DatagridAdderAfterSelection("1", "Blood enhancement tweak v0.5", "neil_v", "http://forums.taleworlds.com/index.php/topic,143179.0.html", "Particles", "Both");
             }
           if (genFaceImrpovmentProject == "True")
                 {
                     DatagridAdderAfterSelection("2", "Face Improvement Project", "Iboltax", "http://forums.taleworlds.com/index.php/topic,163242.0.html", "Skin", "Both");
                 }
              if (expandedHorizon == "True")
             {
              DatagridAdderAfterSelection("3", "Expanded Horizon", "Openshaw", "http://forums.taleworlds.com/index.php/topic,145948.0.html", "Billboards", "Both");
              }
              if (gencolors == "True")
          {
              DatagridAdderAfterSelection("4", "Realistic Colors", "Lucke189", "http://forums.taleworlds.com/index.php?topic=120098.0", "Visuals", "Both");
          }
 
 }
      

        

         void DatagridAdderAfterSelection(string _id,string _name,string _author,string _link ,string _category,string _ms){

          

            datagridconfirmation.Items.Add(new Item() {id=_id ,Name=_name,Author=_author,link=_link,Category= _category,MS= _ms });





        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            return ;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MEP.Code.UI.Continue1 c1 = new MEP.Code.UI.Continue1();
         
            this.Close();
            c1.Continue();
              
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                //Hides the current data table from view
                this.Hide();
                Directory.customdirectory n19 = new Directory.customdirectory();
                n19.ShowDialog();
                //filepath1 is the directories location to native
                string filepath1 = n7.DetermineDirectory1();
                
                //this shows the generating window where the user is told to wait
                p1.Show();
                MessageBox.Show("The following Directory is being used: "+filepath1);
               
                //this makes a string which contains the path to the new module.ini
                string GeneratedModuleini = @"./Generated/module.ini";
             
                //this calls the mainloop of code to begin 
                Code.Binary_Generator.MainLoop n1 = new Code.Binary_Generator.MainLoop();
                      //this.Show(); ????????
           
                //this reads all of the text from the original native module.ini
                //into the variable Reader
                string Reader = File.ReadAllText(filepath1 + @"/module.ini");
               
                //Write all of it to the generated folder
                File.WriteAllText(GeneratedModuleini, Reader);                              
                string filePath = GeneratedModuleini;     
         
                //This searches for the old skeletons.brf and replaces it with the
                //new one,if the user selected the Combat animation enhancment mod 
                if (gencat == "True")
                {
                    string searchText = "load_resource = skeletons";
                    string replaceText = "load_mod_resource = skeletons";
                    ReplaceInFile(filePath, searchText, replaceText);
                }
                //if the user wants the face imrovment project installed this will  
                //be done
                if (genFaceImrpovmentProject =="True")
                {
                    string searchText = "load_resource = textures_face_gen";
                    string replaceText = "load_mod_resource = textures_face_gen";
                    ReplaceInFile(filePath, searchText, replaceText);
                    searchText = "load_resource = materials_face_gen";
                    replaceText = "load_mod_resource = materials_face_gen";
                    ReplaceInFile(filePath, searchText, replaceText);
                    searchText = "load_resource = meshes_face_gen";
                    replaceText = "load_mod_resource = meshes_face_gen";
                    ReplaceInFile(filePath, searchText, replaceText);
                    searchText = "load_resource = beards";
                    replaceText = "load_mod_resource = beards";
                    ReplaceInFile(filePath, searchText, replaceText);
                    searchText = "load_resource = hair";
                    replaceText = "load_mod_resource = hair";
                    ReplaceInFile(filePath, searchText, replaceText);
                }
               //if the user wants to install the expanded horizon mod
                if (expandedHorizon =="True")
                {
                    string searchText = "load_resource = terrain_borders_b";
                   string  replacetext = "load_mod_resource = op_terrain_borders\r\nload_mod_resource = op_terrain_borders_b";
                    ReplaceInFile(filePath, searchText, replacetext);
                    searchText = "load_resource = terrain_borders";
                    replacetext ="load_mod_resource = op_terrain_borders_textures\r\nload_mod_resource = op_terrain_borders_materials";
                    ReplaceInFile(filePath, searchText, replacetext);
                   
                }
                if (gencolors == "True")
                {
                    string searchText = "load_resource = grass_meshes";
                    string replacetext = "load_mod_resource = grass_meshes";
                    ReplaceInFile(filePath, searchText, replacetext);
                    searchText = "load_resource = grass_meshes_b";
                    replacetext = "load_mod_resource = grass_meshes_b";
                    ReplaceInFile(filePath, searchText, replacetext);
                }

                ReplaceInFile(filePath, "scan_module_textures = 0", "scan_module_textures = 1");



                //copies all of the binaries which exist into the native wfas module
            if(File.Exists(GeneratedModuleini))
                File.Copy(GeneratedModuleini, filepath1 + @"/module.ini", true);
            if (File.Exists(@"./Generated/actions.txt"))
                File.Copy(@"./Generated/actions.txt", filepath1 + @"/actions.txt", true);
            if (File.Exists(@"./Generated/particle_systems.txt"))
                File.Copy(@"./Generated/particle_systems.txt", filepath1 + @"/particle_systems.txt", true);
            if(gencat =="True")
                
                File.Copy(@"./Assets/Resource/Combat Animation Enhancement by Papa Lazarou/skeletons.brf", filepath1 + @"/Resource/skeletons.brf",true);
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

                content = Regex.Replace(content, searchText, replaceText);

                StreamWriter writer = new StreamWriter(filePath, false);
                writer.Write(content);
                writer.Close();
            }
            catch (Exception f)
            {

                Console.WriteLine(f.ToString());
                MessageBox.Show(f.ToString());
                Code.Logger.Logger.Loggeradd(f.ToString());

            }           
        }        
    }
    public class Item
    {
        public string id { get; set; }        
        public string Name { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public string MS { get; set; }
        public string link { get; set; }

    }
}

