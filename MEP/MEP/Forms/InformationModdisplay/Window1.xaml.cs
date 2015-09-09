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

namespace MEP.Forms.InformationModdisplay
{
    /*Combat Animation Enhancement by Papa Lazarou
     *Link:http://forums.taleworlds.com/index.php/topic,134185.0.html
     *Use the action binaries to edit
     * */


    /*// Hides script errors without hiding other dialog boxes.
private void SuppressScriptErrorsOnly(WebBrowser browser)
{
  // Ensure that ScriptErrorsSuppressed is set to false.
  browser.ScriptErrorsSuppressed = false;

  // Handle DocumentCompleted to gain access to the Document object.
  browser.DocumentCompleted +=
    new WebBrowserDocumentCompletedEventHandler(
      browser_DocumentCompleted);
}

private void browser_DocumentCompleted(object sender, 
  WebBrowserDocumentCompletedEventArgs e)
{
  ((WebBrowser)sender).Document.Window.Error += 
    new HtmlElementErrorEventHandler(Window_Error);
}

private void Window_Error(object sender, 
  HtmlElementErrorEventArgs e)
{
  // Ignore the error and suppress the error dialog box. 
  e.Handled = true;
}*/

    public partial class Window1 : Window
    {
        string fourth = "https://www.youtube.com/watch?v=k3Z5FsDKoxQ";
        string second = "https://www.youtube.com/watch?v=KevL4BH7XlE";
        string third = "https://www.youtube.com/watch?v=a-lZXQsv9ew";
        string first = "https://www.youtube.com/v/yQ7ahozYxIw";
        
        int i=0;    
        public Window1()
        {
            InitializeComponent();
        //    DependencyProperty n = null;
         //   webbrowser.Parent.SetValue(    n , "IE10");
          //  DependencyProperty n;
           // n ;
           
           
   
            
        }

        private void WebBrowser_ContextMenuClosing(object sender, ContextMenuEventArgs e)
        {
            

        }

        private void Window_Closed(object sender, EventArgs e)
        {
            //remember to dispose of all the data bufferred,force close
            webbrowser.Dispose();
        }

        private void Window_Initialized(object sender, EventArgs e)
        {
                       

        }

        private void Window_Activated(object sender, EventArgs e)
        {
            i = 0;
            //webbrowser.NavigateToString("https://www.youtube.com/v/aoVdPf4cnTw");
          
            webbrowser.Navigate(first);
            
            
        }

        private void _continue_Click(object sender, RoutedEventArgs e)
        {
           
            try
            {
                
              //  Console.WriteLine(i.ToString());
               // if (i != 3)
                  //  i = i + 1;
              //  else if (i == 3)
              //  {
               //     i = 0;// Console.WriteLine(i.ToString());
              //  }
                  //  Console.WriteLine(i.ToString());
              //  else
                 //   Console.WriteLine("so fooked");

                //Console.WriteLine(i.ToString());
               // string toNaviagte = "http://btgames.co.za";
               // if (i == 0)
               //     toNaviagte = first;
              //  else if (i == 1)
              //      toNaviagte = second;
             //   else if (i == 2)
              //      toNaviagte = third;
              //  else if (i == 3)
              //      toNaviagte = fourth;
              //  else
              //      Console.WriteLine("something went wrong RUN FOR YOUR LIFE,I AM A TERRIBLE PROGRAMMER +");

                if (webbrowser.Source.AbsoluteUri == first)
                    webbrowser.Navigate(second);
                else if (webbrowser.Source.AbsoluteUri == second)
                    webbrowser.Navigate(third);
                else if (webbrowser.Source.AbsoluteUri == third)
                    webbrowser.Navigate(fourth);
                else if (webbrowser.Source.AbsoluteUri == fourth)
                    webbrowser.Navigate(first);
                //  if (i != 3)
                //   i++;
                // else
                //   i = 0;
            }
            catch (Exception f)
            {

                Console.WriteLine(f.ToString());
                MessageBox.Show(f.ToString());
            }
            
        }

        private void previous_Click(object sender, RoutedEventArgs e)
        {
            try
            {
              //  Console.WriteLine(i.ToString());

             //   if (i != 0)
              //      i--;
              //  else if (i == 0)
              //      i = 3;
              //  else
               //     return;
              //  string toNaviagte = "http://btgames.co.za";
              //  if (i == 0)
               //     toNaviagte = first;
               // else if (i == 1)
               //     toNaviagte = second;
               // else if (i == 2)
               //     toNaviagte = third;
              //  else if (i == 3)
               //     toNaviagte = fourth;
               // else
                if (webbrowser.Source.AbsoluteUri == first)
                    webbrowser.Navigate(fourth);
                else if (webbrowser.Source.AbsoluteUri == second)
                    webbrowser.Navigate(first);
                else if (webbrowser.Source.AbsoluteUri == third)
                    webbrowser.Navigate(second);
                else if (webbrowser.Source.AbsoluteUri == fourth)
                    webbrowser.Navigate(third);
                    Console.WriteLine("something went wrong RUN FOR YOUR LIFE,I AM A TERRIBLE PROGRAMMER -");

                //webbrowser.Navigate(toNaviagte);

            }
            catch (Exception f)
            {

                Console.WriteLine(f.ToString());
                MessageBox.Show(f.ToString());
            }
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            webbrowser.Dispose();
            
            this.Close();
        }
        
    }
}
