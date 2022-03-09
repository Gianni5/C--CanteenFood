using System;
using System.IO;

namespace AssignmentCanteenFood
{   /// <summary>
    /// class printer 
    /// </summary>
    public class Printer
    {
        private string Filepath;
       
       
       public  Printer(string filepath)
       {               //local variable
            Filepath = filepath;
          
       }


      



        // method for the printer 
        public bool Print(MenuItems[] selectedItems, decimal Totalcost)
        {
            try
            {
                //Using statement takes care of the closure and garbage collection automatically of the object.
                using (StreamWriter sr = new StreamWriter(Filepath)) 
                {
                    sr.WriteLine("----Welcome to the Canteen.----");
                    foreach (var item in selectedItems)
                    {
                        if (item != null)
                        {
                            sr.WriteLine(item.ToString());
                        }

                    }
                    // total 
                    sr.WriteLine("Tolal $ "+ Totalcost);
                    sr.WriteLine("----Thank you! come back again ----");
                    sr.WriteLine("----Covid-19--Remember Social Distance 1.5 m----");
                    sr.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }



            return true;

        }

    }
}
