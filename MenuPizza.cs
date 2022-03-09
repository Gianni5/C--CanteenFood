using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentCanteenFood
{   /// <summary>
/// Chid class inheritance from menuItem 
/// </summary>
    public class MenuPizza : MenuItems 
    {
        /// <summary>
        /// this is Topping
        /// </summary>
        public string Topping { get; set; }
        /// <summary>
        /// this is Crust 
        /// </summary>
        public string Crust { get; set; }
        /// <summary>
        /// this is Size
        /// </summary>
        public string Size { get; set; }

        /// <summary>
        /// this is a constructor for MenuPizza 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="topping"></param>
        /// <param name="crust"></param>
        /// <param name="size"></param>
                                                                                                 // inheritance from Menu Items (string name, decimal price)
        public MenuPizza(string name, decimal price,  string topping, string crust, string size): base(name,price)
        {
           
            Topping = topping;
            Crust = crust;
            Size = size;
        }



        /// <summary>
        /// this is a method convert to string 
        /// </summary>
        /// <returns></returns>        
        public override string ToString()
        {
            return $"{Name}, ${Price}, {Topping}, {Crust}, {Size}"; 
        }
    }
}
