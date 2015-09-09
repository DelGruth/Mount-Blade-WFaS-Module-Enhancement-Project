using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
/*Realistic Colors mod by Lucke189 
 * ID:4 
 *Link:http://forums.taleworlds.com/index.php?topic=120098.0
 *Use the module.ini and resource copier
 * */
namespace MEP.Code.Binary_Generator.Mods
{
    class Realistic_Colors
    {
        StreamReader n1 = new StreamReader(@"./Install/uninstall.ini");
        Directory.DetermineDirectory n2 = new Directory.DetermineDirectory();

        string dirpath;
        bool uninstall;

       public void editor()
        {
            //read settings to determine wether or not to uninstall,Mod ID:4 using 0 index
            //Determine directory and assign the dirpath var to it
            dirpath = n2.DetermineDirectory1();
            n1.ReadLine(); //
            n1.ReadLine();
            n1.ReadLine();
            n1.ReadLine();
            string set =n1.ReadLine();
            n1.Close();

            if(set != "True")
            {
                if (!File.Exists(dirpath + "/Resource/grass_meshes.brf"))
                {
                    File.Copy(@".\Assets\Resource\Realistic Colors by Lucke189\CommonRes\grass_meshes.brf", dirpath + "/Resource/grass_meshes.brf");
                }
                if (!File.Exists(dirpath + "/Resource/grass_meshes_b.brf"))
                {
                    File.Copy(@".\Assets\Resource\Realistic Colors by Lucke189\CommonRes\grass_meshes_b.brf", dirpath + "/Resource/grass_meshes_b.brf");
                }
                uninstall = false;
                Copy("bark.dds", uninstall);
                Copy("bark_b.dds", uninstall);
                Copy("bark_c.dds", uninstall);
                Copy("brick_wall.dds", uninstall);
                Copy("building_details.dds", uninstall);
                Copy("building_details_2.dds", uninstall);
                Copy("building_details_3.dds", uninstall);
                Copy("building_details_4.dds", uninstall);
                Copy("building_details_5.dds", uninstall);
                Copy("building_details_6.dds", uninstall);
                Copy("building_details_7.dds", uninstall);
                Copy("bush_a.dds", uninstall);
                Copy("bush_b.dds", uninstall);
                Copy("bush_c.dds", uninstall);
                Copy("bushes.dds", uninstall);
                Copy("bushes_b.dds", uninstall);
                Copy("dry_grass.dds", uninstall);
                Copy("floor_1.dds", uninstall);
                Copy("grape.dds", uninstall);
                Copy("grass.dds", uninstall);
                Copy("ground_earth.dds", uninstall);
                Copy("ground_forest.dds", uninstall);
                Copy("ground_path.dds", uninstall);
                Copy("ground_rocks_a.dds", uninstall);
                Copy("ground_stone1.dds", uninstall);
                Copy("ground_village.dds", uninstall);
                Copy("ground1.dds", uninstall);
                Copy("map_steppe.dds", uninstall);
                Copy("mountain.dds", uninstall);
                Copy("objects.dds", uninstall);
                Copy("plain.dds", uninstall);
                Copy("plank_ship.dds", uninstall);
                Copy("planks.dds", uninstall);
                Copy("planks_2.dds", uninstall);
                Copy("planks_3.dds", uninstall);
                Copy("planks_4.dds", uninstall);
                Copy("planks_5.dds", uninstall);
                Copy("planks_6.dds", uninstall);
                Copy("plant.dds", uninstall);
                Copy("raw_materials.dds", uninstall);
                Copy("rock.dds", uninstall);
                Copy("rock_a.dds", uninstall);
                Copy("rock_b.dds", uninstall);
                Copy("rock_c.dds", uninstall);
                Copy("roof_a.dds", uninstall);
                Copy("roof_plates.dds", uninstall);
                Copy("roof_thatched.dds", uninstall);
                Copy("roof_tiles.dds", uninstall);
                Copy("stone.dds", uninstall);
                Copy("stone_buildings.dds", uninstall);
                Copy("stone_wall_2.dds", uninstall);
                Copy("stone_wall_3.dds", uninstall);
                Copy("stone_wall_5.dds", uninstall);
                Copy("stone_wall_7.dds", uninstall);
                Copy("stone_wall_8.dds", uninstall);
                Copy("stone_wall_9.dds", uninstall);
                Copy("stone_wall_10.dds", uninstall);
                Copy("stucco_2.dds", uninstall);
                Copy("stucco_4.dds", uninstall);
                Copy("stucco_5.dds", uninstall);
                Copy("stucco_6.dds", uninstall);
                Copy("stucco_7.dds", uninstall);
                Copy("tent.dds", uninstall);
                Copy("terrain_grassy.dds", uninstall);
                Copy("terrain_steppe.dds", uninstall);
                Copy("tree_a.dds", uninstall);
                Copy("tree_b.dds", uninstall);
                Copy("tree_c.dds", uninstall);
                Copy("tree_e.dds", uninstall);
                Copy("tree_f.dds", uninstall);
                Copy("tree_new_a.dds", uninstall);
                Copy("tree_new_b.dds", uninstall);
                Copy("tree_new_c.dds", uninstall);
                Copy("trees.dds", uninstall);
                Copy("trees2.dds", uninstall);
                Copy("trunks.dds", uninstall);
                Copy("trunks_height.dds", uninstall);
                Copy("vine.dds", uninstall);
                Copy("wall_snowy.dds", uninstall);
                Copy("wall3.dds", uninstall);
                Copy("wall4.dds", uninstall);
                Copy("wall5.dds", uninstall);
               

            }
            else if(set == "True")
            {
                if (File.Exists(dirpath + "/Resource/grass_meshes.brf"))
                File.Delete(dirpath + "/Resource/grass_meshes.brf");
                if (File.Exists(dirpath + "/Resource/grass_meshes_b.brf"))
                File.Delete( dirpath + "/Resource/grass_meshes_b.brf");
                uninstall = true;
                Copy("bark.dds", uninstall);
                Copy("bark_b.dds", uninstall);
                Copy("bark_c.dds", uninstall);
                Copy("brick_wall.dds", uninstall);
                Copy("building_details.dds", uninstall);
                Copy("building_details_2.dds", uninstall);
                Copy("building_details_3.dds", uninstall);
                Copy("building_details_4.dds", uninstall);
                Copy("building_details_5.dds", uninstall);
                Copy("building_details_6.dds", uninstall);
                Copy("building_details_7.dds", uninstall);
                Copy("bush_a.dds", uninstall);
                Copy("bush_b.dds", uninstall);
                Copy("bush_c.dds", uninstall);
                Copy("bushes.dds", uninstall);
                Copy("bushes_b.dds", uninstall);
                Copy("dry_grass.dds", uninstall);
                Copy("floor_1.dds", uninstall);
                Copy("grape.dds", uninstall);
                Copy("grass.dds", uninstall);
                Copy("ground_earth.dds", uninstall);
                Copy("ground_forest.dds", uninstall);
                Copy("ground_path.dds", uninstall);
                Copy("ground_rocks_a.dds", uninstall);
                Copy("ground_stone1.dds", uninstall);
                Copy("ground_village.dds", uninstall);
                Copy("ground1.dds", uninstall);
                Copy("map_steppe.dds", uninstall);
                Copy("mountain.dds", uninstall);
                Copy("objects.dds", uninstall);
                Copy("plain.dds", uninstall);
                Copy("plank_ship.dds", uninstall);
                Copy("planks.dds", uninstall);
                Copy("planks_2.dds", uninstall);
                Copy("planks_3.dds", uninstall);
                Copy("planks_4.dds", uninstall);
                Copy("planks_5.dds", uninstall);
                Copy("planks_6.dds", uninstall);
                Copy("plant.dds", uninstall);
                Copy("raw_materials.dds", uninstall);
                Copy("rock.dds", uninstall);
                Copy("rock_a.dds", uninstall);
                Copy("rock_b.dds", uninstall);
                Copy("rock_c.dds", uninstall);
                Copy("roof_a.dds", uninstall);
                Copy("roof_plates.dds", uninstall);
                Copy("roof_thatched.dds", uninstall);
                Copy("roof_tiles.dds", uninstall);
                Copy("stone.dds", uninstall);
                Copy("stone_buildings.dds", uninstall);
                Copy("stone_wall_2.dds", uninstall);
                Copy("stone_wall_3.dds", uninstall);
                Copy("stone_wall_5.dds", uninstall);
                Copy("stone_wall_7.dds", uninstall);
                Copy("stone_wall_8.dds", uninstall);
                Copy("stone_wall_9.dds", uninstall);
                Copy("stone_wall_10.dds", uninstall);
                Copy("stucco_2.dds", uninstall);
                Copy("stucco_4.dds", uninstall);
                Copy("stucco_5.dds", uninstall);
                Copy("stucco_6.dds", uninstall);
                Copy("stucco_7.dds", uninstall);
                Copy("tent.dds", uninstall);
                Copy("terrain_grassy.dds", uninstall);
                Copy("terrain_steppe.dds", uninstall);
                Copy("tree_a.dds", uninstall);
                Copy("tree_b.dds", uninstall);
                Copy("tree_c.dds", uninstall);
                Copy("tree_e.dds", uninstall);
                Copy("tree_f.dds", uninstall);
                Copy("tree_new_a.dds", uninstall);
                Copy("tree_new_b.dds", uninstall);
                Copy("tree_new_c.dds", uninstall);
                Copy("trees.dds", uninstall);
                Copy("trees2.dds", uninstall);
                Copy("trunks.dds", uninstall);
                Copy("trunks_height.dds", uninstall);
                Copy("vine.dds", uninstall);
                Copy("wall_snowy.dds", uninstall);
                Copy("wall3.dds", uninstall);
                Copy("wall4.dds", uninstall);
                Copy("wall5.dds", uninstall);
               
            }
              
        }
        void Copy(string objectname,bool iu)
        {
            if (!File.Exists(dirpath + "/Textures/" + objectname) && iu ==false)
                File.Copy(@".\Assets\Resource\Realistic Colors by Lucke189\Textures\"+objectname, dirpath + "/Textures/" + objectname);
            else if(File.Exists(dirpath + "/Textures/" + objectname) && iu ==true)
                File.Delete( dirpath + "/Textures/" + objectname);
        }

    
    }
}
