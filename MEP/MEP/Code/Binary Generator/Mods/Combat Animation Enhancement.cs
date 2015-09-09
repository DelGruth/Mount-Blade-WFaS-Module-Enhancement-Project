using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
/*Combat Animation Enhancement by Papa Lazarou
 *Link:http://forums.taleworlds.com/index.php/topic,134185.0.html
 *Use the action binaries to edit
 * */

namespace MEP.Code.Binary_Generator.Mods
{
    class Combat_Animation_Enhancement
    {
        string Orignal;
       string New;
       ActionModuleTextGenerator.Main ATG = new ActionModuleTextGenerator.Main();
       
       // StreamReader n2 = new StreamReader(@"./Install/uninstall.ini");
    
       //string set;
       StreamReader n1 =new StreamReader (@"./Install/install.ini");
    public void Generator(string _1st,string _2de)
       {
         
           StreamReader n2 = new StreamReader(@"./Install/uninstall.ini");
           string set = n2.ReadLine();
       

           

        if (set != "True")
        {
         
            ATG.ActionTextGenerator1(_1st, _2de);
          //  Console.WriteLine("uninstall not true");
        }
        else if (set == "True")
        {
            Console.WriteLine("uninstalling");
            ATG.ActionTextGenerator1(_2de, _1st);
            //Console.WriteLine("uninstall is true");
        }
       // else
          //  ATG.ActionTextGenerator1(_1st, _2de);
     //   else if (set =="false "|| set ==null)
      //      ATG.ActionTextGenerator1(_1st)

        n2.Close();
       }
  
   
       public void Editor()
    {
        try
        {
            Console.WriteLine("editor entered");
            // ATG.dir();
            //*****************STATIC 1h ANIMATIONS*****************************\\
            //Beggining of the low blocks Animations
            Orignal = "0.750000 defend_forward_onehanded 20 41 4 0 0.0 0.0 0.0 0.0";
            New = "0.750000 1h_lowblock_11.9.10 20 41 4 0 0.0 0.0 0.0 0.0 ";
            Generator(Orignal, New);
            Orignal = "  5.000000 defend_onehanded 15 70 268435460 0 0.0 0.0 0.0 0.0 ";
            New = "  5.000000 1h_lowblock_11.9.10 15 70 268435460 0 0.0 0.0 0.0 0.0 ";
            Generator(Orignal, New);
            Orignal = "  0.600000 defend_onehanded 75 85 2 0 0.0 0.0 0.0 0.0 ";
            New = "  0.600000 1h_lowblock_11.9.10 75 85 2 0 0.0 0.0 0.0 0.0 ";
            Generator(Orignal, New);
            Orignal = "  0.600000 defend_onehanded 75 85 2 0 0.0 0.0 0.0 0.0 ";
            New = "  0.600000 1h_lowblock_11.9.10 75 85 2 0 0.0 0.0 0.0 0.0 ";
            Generator(Orignal, New);
            Orignal = "  0.800000 defend_onehanded 75 85 2 0 0.0 0.0 0.0 0.0 ";
            New = "  0.800000 1h_lowblock_11.9.10 75 85 2 0 0.0 0.0 0.0 0.0 ";
            //End of low block Animations

            //Beggining of the Upper block animations
            Orignal = "  0.750000 defend_up_onehanded 9 25 4 0 0.0 0.0 0.0 0.0 ";
            New = "  0.750000 1h_highblock_11.9.10 9 25 4 0 0.0 0.0 0.0 0.0 ";
            Generator(Orignal, New);
            Orignal = "  2.800000 defend_up_onehanded_keep 1 87 268435460 0 0.0 0.0 0.0 0.0 ";
            New = "  2.800000 1h_highblock_11.9.10 1 87 268435460 0 0.0 0.0 0.0 0.0 ";
            Generator(Orignal, New);
            //END **NOTE DID NOT EDIT THE 3 PARRIES**

            //Beggining of Right block
            Orignal = "  0.750000 defend_right_onehanded 14 31 4 0 0.0 0.0 0.0 0.0 ";
            New = "  0.750000 1h_rightblock_11.9.10 14 31 4 0 0.0 0.0 0.0 0.0 ";
            Generator(Orignal, New);
            Orignal = "  2.500000 defend_right_onehanded_keep 0 79 268435462 0 0.0 0.0 0.0 0.0 ";
            New = "  2.500000 1h_rightblock_11.9.10 0 79 268435462 0 0.0 0.0 0.0 0.0 ";
            Generator(Orignal, New);
            //END **NOTE DID NOT EDIT THE 3 PARRIES**
            //Beggining of Left block
            Orignal = "  0.750000 defend_left_onehanded 12 28 4 0 0.0 0.0 0.0 0.0 ";
            New = "  0.750000 1h_leftblock_11.9.10 12 28 4 0 0.0 0.0 0.0 0.0 ";
            Generator(Orignal, New);
            Orignal = "  2.200000 defend_left_onehanded_keep 1 71 268435460 0 0.0 0.0 0.0 0.0 ";
            New = "  2.200000 1h_leftblock_11.9.10 1 71 268435460 0 0.0 0.0 0.0 0.0 ";
            //END **NOTE DID NOT EDIT THE 3 PARRIES*
            //***********END OF STATIC 1h ANIMATIONS*****************************\\



            //**************************BEGGINING OF 1h ATTACK ANIMATIONS******************\\
            //Beggining of cuts from above
            Generator(Orignal, New);
            Orignal = "  0.350000 attacks_single_overswing 5 16 7 0 0.0 0.0 0.0 0.0 ";
            New = "  0.350000 1h_overswing_28.9.10 5 16 7 0 0.0 0.0 0.0 0.0 ";
            Generator(Orignal, New);
            Orignal = "  0.600000 attacks_single_overswing 16 37 6 0 0.0 0.0 0.0 0.0 ";
            New = "  0.600000 1h_overswing_28.9.10 16 37 6 0 0.0 0.0 0.0 0.0 ";
            Generator(Orignal, New);
            Orignal = "  0.200000 attacks_single_overswing 37 40 2 0 0.0 0.0 0.0 0.0 ";
            New = "  0.200000 1h_overswing_28.9.10 37 40 2 0 0.0 0.0 0.0 0.0 ";
            //END

            //Beggining of Slashes from left
            Generator(Orignal, New);
            Orignal = "  0.350000 attacks_single_lefttoright 4 11 7 0 0.0 0.0 0.0 0.0 ";
            New = "  0.350000 1h_slashleft_13.9.10 4 11 7 0 0.0 0.0 0.0 0.0 ";
            Generator(Orignal, New);
            Orignal = "  0.610000 attacks_single_lefttoright 11 29 6 0 0.0 0.0 0.0 0.0 ";
            New = "  0.610000 1h_slashleft_13.9.10 11 29 6 0 0.0 0.0 0.0 0.0 ";
            Generator(Orignal, New);
            Orignal = "  0.400000 attacks_single_lefttoright 29 43 2 0 0.0 0.0 0.0 0.0 ";
            New = "  0.400000 1h_slashleft_13.9.10 29 43 2 0 0.0 0.0 0.0 0.0 ";
            Generator(Orignal, New);  //END

            //Beggining of slashes from right

            Orignal = "  0.350000 attacks_single_righttoleft 2 5 7 0 0.0 0.0 0.0 0.0 ";
            New = "  0.350000 1h_slashright_13.9.10 2 5 7 0 0.0 0.0 0.0 0.0 ";
            Generator(Orignal, New);
            Orignal = "  0.600000 attacks_single_righttoleft 5 28 6 0 0.0 0.0 0.0 0.0 ";
            New = "  0.600000 1h_slashright_13.9.10 5 28 6 0 0.0 0.0 0.0 0.0 ";
            Generator(Orignal, New);
            Orignal = "  0.400000 attacks_single_righttoleft 28 44 2 0 0.0 0.0 0.0 0.0 ";
            New = "  0.400000 1h_slashright_13.9.10 28 44 2 0 0.0 0.0 0.0 0.0 ";
            Generator(Orignal, New);

            //END

            //Beggining of thrusts
            Orignal = "  0.350000 attacks_thrust_onehanded 5 13 7 0 0.0 0.0 0.0 0.0 ";
            New = "  0.350000 1h_low_thrust_30.9.10 5 13 7 0 0.0 0.0 0.0 0.0 ";
            Generator(Orignal, New);
            Orignal = "  0.620000 attacks_thrust_onehanded 12 32 6 0 0.0 0.0 0.0 0.0 ";
            New = "  0.620000 1h_low_thrust_30.9.10 12 32 6 0 0.0 0.0 0.0 0.0 ";
            Generator(Orignal, New);
            Orignal = "  0.300000 attacks_thrust_onehanded 32 54 2 0 0.0 0.0 0.0 0.0 ";
            New = "  0.300000 1h_low_thrust_30.9.10 32 54 2 0 0.0 0.0 0.0 0.0 ";
            Generator(Orignal, New);
            Orignal = "  0.600000 anim_human 28515 28513 6 0 0.0 0.0 0.0 0.0 ";
            New = "  0.600000 parry_single_lefttoright 28515 28513 6 0 0.0 0.0 0.0 0.0 "; //maybe remove
            Generator(Orignal, New);
            Orignal = "  0.700000 anim_human 28515 28513 6 0 0.0 0.0 0.0 0.0 ";
            New = "  0.700000 parry_single_lefttoright 28515 28513 6 0 0.0 0.0 0.0 0.0 "; //maybe remove
            Generator(Orignal, New);
            //END

            //*************************END OF 1h ATTACK ANIMATIONS******************************\\

            //******************************BEGGINING OF THE 1h SPEAR ANIMATIONS******************\\
            Orignal = "  0.350000 thrust_onehanded_lance_hb 5 8 7 0 0.0 0.0 0.0 0.0 ";
            New = "  0.350000 1h_low_thrust_30.9.10 5 8 7 0 0.0 0.0 0.0 0.0 ";
            Generator(Orignal, New);
            Orignal = "  0.620000 thrust_onehanded_lance_hb 8 33 6 0 0.0 0.0 0.0 0.0 ";
            New = "  0.620000 1h_low_thrust_30.9.10 8 33 6 0 0.0 0.0 0.0 0.0 ";
            Generator(Orignal, New);
            Orignal = "  0.100000 thrust_onehanded_lance_hb 33 45 2 0 0.0 0.0 0.0 0.0 ";
            New = "  0.100000 1h_low_thrust_30.9.10 33 45 2 0 0.0 0.0 0.0 0.0 ";
            Generator(Orignal, New);
            //******************************END OF THE 1h SPEAR ANIMATIONS******************\\

            //*******************************BEGGINING OF POLEARMS ANIMATIONS*****************\\
            /*
            
            //Begging polearms overswing
        Orignal = "  0.350000 attacks_staff_uptodown 9 26 7 0 0.0 0.0 0.0 0.0 ";
        New = "  0.350000 Polearm_overswing_15.10.10 9 26 7 0 0.0 0.0 0.0 0.0 ";
        Generator(Orignal, New);
        Orignal = "  0.600000 attacks_staff_uptodown 26 61 6 0 0.0 0.0 0.0 0.0 ";
        New = "  0.600000 Polearm_overswing_15.10.10 26 61 6 0 0.0 0.0 0.0 0.0 ";
        Generator(Orignal, New);
        Orignal = "  0.300000 attacks_staff_uptodown 61 68 2 0 0.0 0.0 0.0 0.0 ";
        New = "  0.300000 Polearm_overswing_15.10.10 61 68 2 0 0.0 0.0 0.0 0.0 ";
            //End of polearm overswing

            //Beggining of Polearm thrust
           
        Generator(Orignal, New);
        Orignal = "  0.350000 attacks_staff_thrust 14 21 7 0 0.0 0.0 0.0 0.0 ";
        New = "  0.350000 Polearm_thrust_3.10.10 14 21 7 0 0.0 0.0 0.0 0.0 ";
        Generator(Orignal, New);
        Orignal = "  0.600000 attacks_staff_thrust 21 40 6 0 0.0 0.0 0.0 0.0 ";
        New = "  0.600000 Polearm_thrust_3.10.10 21 40 6 0 0.0 0.0 0.0 0.0 ";
        Generator(Orignal, New);
        Orignal = "  0.600000 attacks_staff_thrust 40 58 6 0 0.0 0.0 0.0 0.0 ";
        New = "  0.600000 Polearm_thrust_3.10.10 40 58 6 0 0.0 0.0 0.0 0.0 ";
        Generator(Orignal, New);
        //END
            

        //beggining of polearm slash left 
      
        Orignal = "  0.350000 attacks_staff_lefttoright 10 16 7 0 0.0 0.0 0.0 0.0 ";
        New = "  0.350000 Polearm_slashleft_19.10.10 10 16 7 0 0.0 0.0 0.0 0.0 ";
        Generator(Orignal, New);
        Orignal = "  0.600000 attacks_staff_lefttoright 16 44 6 0 0.0 0.0 0.0 0.0 ";
        New = "  0.7500000 Polearm_slashleft_19.10.10 16 44 6 0 0.0 0.0 0.0 0.0 ";
        Generator(Orignal, New);
        Orignal = "  0.300000 attacks_staff_lefttoright 44 55 2 0 0.0 0.0 0.0 0.0 ";
        New = "  0.100000 Polearm_slashleft_19.10.10 44 55 2 0 0.0 0.0 0.0 0.0 ";
        Generator(Orignal, New);
         //END

            //beggining of polearm slash right
        Orignal = "  0.350000 attacks_staff_righttoleft 6 16 7 0 0.0 0.0 0.0 0.0 ";
        New = "  0.350000 Polearm_slashright_ready_27.9.10 6 16 7 0 0.0 0.0 0.0 0.0 ";
        Generator(Orignal, New);
        Orignal = "  0.600000 attacks_staff_righttoleft 16 40 6 0 0.0 0.0 0.0 0.0 ";
        New = "  0.7500000 Polearm_slashright_release_27.9.10 16 40 6 0 0.0 0.0 0.0 0.0 ";
        Generator(Orignal, New);
        Orignal = "  0.400000 attacks_staff_righttoleft 40 48 2 0 0.0 0.0 0.0 0.0 ";
        New = "  0.1500000 Polearm_slashright_cont_27.9.10 40 48 2 0 0.0 0.0 0.0 0.0 ";
        Generator(Orignal, New);
            //END

            //Begging of polearm blocks
        Orignal = "  0.750000 defend_staff 0 5 4 0 0.0 0.0 0.0 0.0 ";
        New = "  0.750000 Polearm_lowblock_keep_27.9.10 0 5 4 0 0.0 0.0 0.0 0.0 ";
        Generator(Orignal, New);
        Orignal = "  2.000000 defend_staff 5 5 268435460 0 0.0 0.0 0.0 0.0 ";
        New = "  2.000000 Polearm_lowblock_keep_27.9.10 5 5 268435460 0 0.0 0.0 0.0 0.0 ";
        Generator(Orignal, New);
        Orignal = "  0.600000 defend_staff 56 70 2 0 0.0 0.0 0.0 0.0 ";
        New = "  0.600000 Polearm_lowblock_beat_27.9.10 56 70 2 0 0.0 0.0 0.0 0.0 ";
        Generator(Orignal, New);
        Orignal = "  0.600000 defend_staff 56 70 2 0 0.0 0.0 0.0 0.0 ";
        New = "  0.600000 Polearm_lowblock_beat_27.9.10 56 70 2 0 0.0 0.0 0.0 0.0 ";
        Generator(Orignal, New);
        Orignal = "  0.600000 defend_staff 56 70 2 0 0.0 0.0 0.0 0.0 ";
        New = "  0.600000 Polearm_lowblock_beat_27.9.10 56 70 2 0 0.0 0.0 0.0 0.0 ";
        Generator(Orignal, New);
        Orignal = "  0.750000 anim_human 37110 37120 4 0 0.0 0.0 0.0 0.0 ";
        New = "  0.750000 Polearm_highblock_27.9.10 37110 37120 4 0 0.0 0.0 0.0 0.0 ";
        Generator(Orignal, New);
        Orignal = "  2.000000 anim_human 37120 37120 268435460 0 0.0 0.0 0.0 0.0 ";
        New = "  2.000000 Polearm_highblock_27.9.10 37120 37120 268435460 0 0.0 0.0 0.0 0.0 ";
        Generator(Orignal, New);
        Orignal = "  0.600000 anim_human 37121 37130 2 0 0.0 0.0 0.0 0.0 ";
        New = "  0.600000 Polearm_highblock_27.9.10 37121 37130 2 0 0.0 0.0 0.0 0.0 ";
        Generator(Orignal, New);
        Orignal = "  0.600000 anim_human 37121 37130 2 0 0.0 0.0 0.0 0.0 ";
        New = "  0.600000 Polearm_highblock_27.9.10 37121 37130 2 0 0.0 0.0 0.0 0.0 ";
        Generator(Orignal, New);
        Orignal = "  0.800000 anim_human 37121 37130 2 0 0.0 0.0 0.0 0.0 ";
        New = "  0.800000 Polearm_highblock_27.9.10 37121 37130 2 0 0.0 0.0 0.0 0.0 ";
        Generator(Orignal, New);
        Orignal = "  0.750000 anim_human 37210 37220 4 0 0.0 0.0 0.0 0.0 ";
        New = "  0.750000 Polearm_blockright_27.9.10 37210 37220 4 0 0.0 0.0 0.0 0.0 ";
        Generator(Orignal, New);
        Orignal = "  2.000000 anim_human 37220 37220 268435460 0 0.0 0.0 0.0 0.0 ";
        New = "  2.000000 Polearm_blockright_27.9.10 37220 37220 268435460 0 0.0 0.0 0.0 0.0 ";
        Generator(Orignal, New);
        Orignal = "  0.600000 anim_human 37221 37230 2 0 0.0 0.0 0.0 0.0 ";
        New = "  0.600000 Polearm_blockright_27.9.10 37221 37230 2 0 0.0 0.0 0.0 0.0 ";
        Generator(Orignal, New);
        Orignal = "  0.600000 anim_human 37221 37230 2 0 0.0 0.0 0.0 0.0 ";
        New = "  0.600000 Polearm_blockright_27.9.10 37221 37230 2 0 0.0 0.0 0.0 0.0 ";
        Generator(Orignal, New);
        Orignal = "  0.800000 anim_human 37221 37230 2 0 0.0 0.0 0.0 0.0 ";
        New = "  0.800000 Polearm_blockright_27.9.10 37221 37230 2 0 0.0 0.0 0.0 0.0 ";
        Generator(Orignal, New);
        Orignal = "  0.750000 anim_human 37310 37320 4 0 0.0 0.0 0.0 0.0 ";
        New = "  0.750000 Polearm_leftblock_27.9.10 37310 37320 4 0 0.0 0.0 0.0 0.0 ";
        Generator(Orignal, New);
        Orignal = "  2.000000 anim_human 37320 37320 268435460 0 0.0 0.0 0.0 0.0 ";
        New = "  2.000000 Polearm_leftblock_27.9.10 37320 37320 268435460 0 0.0 0.0 0.0 0.0 ";
        Generator(Orignal, New);
        Orignal = "  0.600000 anim_human 37321 37330 2 0 0.0 0.0 0.0 0.0 ";
        New = "  0.600000 Polearm_leftblock_27.9.10 37321 37330 2 0 0.0 0.0 0.0 0.0 ";
        Generator(Orignal, New);
        Orignal = "  0.600000 anim_human 37321 37330 2 0 0.0 0.0 0.0 0.0 ";
        New = "  0.600000 Polearm_leftblock_27.9.10 37321 37330 2 0 0.0 0.0 0.0 0.0 ";
        Generator(Orignal, New);
        Orignal = "  0.800000 anim_human 37321 37330 2 0 0.0 0.0 0.0 0.0 ";
        New = "  0.800000 Polearm_leftblock_27.9.10 37321 37330 2 0 0.0 0.0 0.0 0.0 ";
        Generator(Orignal, New);
            //END 
            */
            //**********************END OF POLEARM ANIMATIONS*****************************************\\

            //*************************BEGGINING OF ARCHERY ANIMATIONS********************************\\
            /////////////////////ARCHERY ANIM NOT COMPATIBLE WITH WFAS\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

            // Orignal = "  1.500000 anim_human 20500 20530 519 28707 0.0 0.0 0.0 0.0 ";
            // New = "  1.500000 Archery_full_30.10.10 20500 20530 519 28707 0.0 0.0 0.0 0.0 ";
            //  Generator(Orignal, New);
            //  Orignal = "  0.300000 anim_human 20530 20532 3 0 0.0 0.0 0.0 0.0 ";
            //  New = "  0.300000 Archery_full_30.10.10 20530 20532 3 0 0.0 0.0 0.0 0.0 ";
            // Generator(Orignal, New);
            //*************************END OF ARCHERY ANIMATIONS**************************************\\

            //*************************BEGGING OF 2h ANIMATIONS**************************************\\
            //Beggining of 2h slash right animations

            Orignal = "  0.350000 slashright_twohanded 10 18 7 0 0.0 0.0 0.0 0.0 ";
            New = "  0.350000 2h_slashright_7.11.10b 10 18 7 0 0.0 0.0 0.0 0.0 ";
            Generator(Orignal, New);
            Orignal = "  0.610000 slashright_twohanded 18 38 6 0 0.0 0.0 0.0 0.0 ";
            New = "  0.610000 2h_slashright_7.11.10b 18 38 6 0 0.0 0.0 0.0 0.0 ";
            Generator(Orignal, New);
            Orignal = "  0.500000 slashright_twohanded 38 61 2 0 0.0 0.0 0.0 0.0 ";
            New = "  0.500000 2h_slashright_7.11.10b 38 61 2 0 0.0 0.0 0.0 0.0 ";
            Generator(Orignal, New);
            //END

            //Beggining of 2h slash left animations
            Orignal = "  0.350000 slashleft_twohanded 12 16 7 0 0.0 0.0 0.0 0.0 ";
            New = "  0.350000 2h_slashleft_9.11.10b 12 16 7 0 0.0 0.0 0.0 0.0 ";
            Generator(Orignal, New);
            Orignal = "  0.610000 slashleft_twohanded 16 38 6 0 0.0 0.0 0.0 0.0 ";
            New = "  0.610000 2h_slashleft_9.11.10b 16 38 6 0 0.0 0.0 0.0 0.0 ";
            Generator(Orignal, New);
            Orignal = "  0.500000 slashleft_twohanded 38 52 2 0 0.0 0.0 0.0 0.0 ";
            New = "  0.500000 2h_slashleft_9.11.10b 38 52 2 0 0.0 0.0 0.0 0.0 ";
            Generator(Orignal, New);
            //END

            /*
        //Beggining of 2h thrust animations
        Orignal = "  0.350000 anim_human 26000 26010 7 0 0.0 0.0 0.0 0.0 ";
        New = "  0.350000 2h_sword_thrust_full_3.11.10 26000 26010 7 0 0.0 0.0 0.0 0.0 ";
        Generator(Orignal, New);
        Orignal = "  0.610000 anim_human 26010 26031 6 0 0.0 0.0 0.0 0.0 ";
        New = "  0.610000 2h_sword_thrust_full_3.11.10 26010 26031 6 0 0.0 0.0 0.0 0.0 ";
        Generator(Orignal, New);
        Orignal = "  0.100000 anim_human 26031 26040 2 0 0.0 0.0 0.0 0.0 ";
        New = "  0.100000 2h_sword_thrust_full_3.11.10 26031 26040 2 0 0.0 0.0 0.0 0.0 ";
            //END
            

            //Beggining of 2h Overswing animations
           
        Generator(Orignal, New);
        Orignal = "  0.350000 attacks_twohanded_overswing 11 26 7 0 0.0 0.0 0.0 0.0 ";
        New = "  0.350000 2h_overswing_full_7.11.10 11 26 7 0 0.0 0.0 0.0 0.0 ";
        Generator(Orignal, New);
        Orignal = "  0.610000 attacks_twohanded_overswing 26 55 6 0 0.0 0.0 0.0 0.0 ";
        New = "  0.610000 2h_overswing_full_7.11.10 26 55 6 0 0.0 0.0 0.0 0.0 ";
        Generator(Orignal, New);
        Orignal = "  0.500000 attacks_twohanded_overswing 55 66 2 0 0.0 0.0 0.0 0.0 ";
        New = "  0.300000 2h_overswing_full_7.11.10 55 66 2 0 0.0 0.0 0.0 0.0 ";
        Generator(Orignal, New);
            //END*/


            //Beggining of 2h block animations
            /* last
        Orignal = "  0.750000 defend_twohanded 0 20 4 0 0.0 0.0 0.0 0.0 ";
        New = "  0.750000 2h_low_beat_12.11.10 0 20 4 0 0.0 0.0 0.0 0.0 ";
        Generator(Orignal, New);
        Orignal = "  2.000000 defend_twohanded 170 170 268435460 0 0.0 0.0 0.0 0.0 ";
        New = "  2.000000 2h_low_beat_12.11.10 170 170 268435460 0 0.0 0.0 0.0 0.0 ";
        Generator(Orignal, New);
        Orignal = "  0.600000 defend_twohanded 350 367 2 0 0.0 0.0 0.0 0.0 ";
        New = "  0.600000 2h_low_beat_12.11.10 350 367 2 0 0.0 0.0 0.0 0.0 ";
        Generator(Orignal, New);
        Orignal = "  0.600000 defend_twohanded 350 367 2 0 0.0 0.0 0.0 0.0 ";
        New = "  0.600000 2h_low_beat_12.11.10 350 367 2 0 0.0 0.0 0.0 0.0 ";
        Generator(Orignal, New);
        Orignal = "  0.600000 defend_twohanded 350 367 2 0 0.0 0.0 0.0 0.0 ";
        New = "  0.600000 2h_low_beat_12.11.10 350 367 2 0 0.0 0.0 0.0 0.0 ";
        Generator(Orignal, New);
             */
            Orignal = "  0.750000 anim_human 35403 35410 4 0 0.0 0.0 0.0 0.0 ";
            New = "  0.750000 2h_highblock_26.9.10 35403 35410 4 0 0.0 0.0 0.0 0.0 ";
            Generator(Orignal, New);
            Orignal = "  2.000000 anim_human 35410 35410 268435460 0 0.0 0.0 0.0 0.0 ";
            New = "  2.000000 2h_highblock_26.9.10 35410 35410 268435460 0 0.0 0.0 0.0 0.0 ";
            Generator(Orignal, New);
            Orignal = "  0.600000 anim_human 35411 35418 2 0 0.0 0.0 0.0 0.0 ";
            New = "  0.600000 2h_highblock_26.9.10 35411 35418 2 0 0.0 0.0 0.0 0.0 ";
            Generator(Orignal, New);
            Orignal = "  0.600000 anim_human 35411 35418 2 0 0.0 0.0 0.0 0.0 ";
            New = "  0.600000 2h_highblock_26.9.10 35411 35418 2 0 0.0 0.0 0.0 0.0 ";
            Generator(Orignal, New);
            Orignal = "  0.800000 anim_human 35411 35418 2 0 0.0 0.0 0.0 0.0 ";
            New = "  0.800000 2h_highblock_26.9.10 35411 35418 2 0 0.0 0.0 0.0 0.0 ";
            Generator(Orignal, New);
            /*
        Orignal = "  0.750000 anim_human 35510 35520 4 0 0.0 0.0 0.0 0.0 ";
        New = "  0.750000 2h_right_left_blocks_3.11.10 35510 35520 4 0 0.0 0.0 0.0 0.0 ";
        Generator(Orignal, New);
        Orignal = "  2.000000 anim_human 35520 35520 268435460 0 0.0 0.0 0.0 0.0 ";
        New = "  2.000000 2h_right_left_blocks_3.11.10 35520 35520 268435460 0 0.0 0.0 0.0 0.0 ";
        Generator(Orignal, New);
        Orignal = "  0.600000 anim_human 35521 35528 2 0 0.0 0.0 0.0 0.0 ";
        New = "  0.600000 2h_right_left_blocks_3.11.10 35521 35528 2 0 0.0 0.0 0.0 0.0 ";
        Generator(Orignal, New);
        Orignal = "  0.600000 anim_human 35521 35528 2 0 0.0 0.0 0.0 0.0 ";
        New = "  0.600000 2h_right_left_blocks_3.11.10 35521 35528 2 0 0.0 0.0 0.0 0.0 ";
        Generator(Orignal, New);
        Orignal = "  0.800000 anim_human 35521 35528 2 0 0.0 0.0 0.0 0.0 ";
        New = "  0.800000 2h_right_left_blocks_3.11.10 35521 35528 2 0 0.0 0.0 0.0 0.0 ";
        Generator(Orignal, New);
            */


            Orignal = "  0.750000 anim_human 35610 35620 4 0 0.0 0.0 0.0 0.0 ";
            New = "  0.750000 2h_right_left_blocks_3.11.10 35610 35620 4 0 0.0 0.0 0.0 0.0 ";
            Generator(Orignal, New);
            Orignal = "  2.000000 anim_human 35620 35620 268435460 0 0.0 0.0 0.0 0.0 ";
            New = "  2.000000 2h_right_left_blocks_3.11.10 35620 35620 268435460 0 0.0 0.0 0.0 0.0 ";
            Generator(Orignal, New);
            Orignal = "  0.600000 anim_human 35620 35630 2 0 0.0 0.0 0.0 0.0 ";
            New = "  0.600000 2h_right_left_blocks_3.11.10 35620 35630 2 0 0.0 0.0 0.0 0.0 ";
            Generator(Orignal, New);
            Orignal = "  0.600000 anim_human 35620 35630 2 0 0.0 0.0 0.0 0.0 ";
            New = "  0.600000 2h_right_left_blocks_3.11.10 35620 35630 2 0 0.0 0.0 0.0 0.0 ";
            Generator(Orignal, New);
            Orignal = "  0.800000 anim_human 35620 35630 2 0 0.0 0.0 0.0 0.0 ";
            New = "  0.800000 2h_right_left_blocks_3.11.10 35620 35630 2 0 0.0 0.0 0.0 0.0 ";
            Generator(Orignal, New);

            //END

            //***********************ENDING OF 2h ANIMATIONS********************************\\

            Console.WriteLine("editor finished");

            n1.Close();
        }
        catch (Exception e)
        {
            Logger.Logger.Loggeradd(e.ToString());
        }


   }

       
    }
}

