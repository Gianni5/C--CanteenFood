using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentCanteenFood
{/// <summary>
/// parent class MenuItems
/// </summary>
    public class MenuItems
    {
        /// <summary>
        /// this is Name 
        /// </summary>
        public string  Name { get; set; }
        /// <summary>
        /// this is Price
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// this is the constructor for MenuItems
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        public MenuItems(string name, decimal price)
        {
            
            Name = name;
            Price = price;
            


        }
        /// <summary>
        /// this method convert to string 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Name} - ${Price}";
        }
        /// <summary>
        /// this method writes the specified string value to the standard output
        /// </summary>
        public void Print()
        {
            Console.WriteLine("Items:   " + Name);
            Console.WriteLine("Price:   " + Price);
        }

    }
   


}

