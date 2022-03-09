using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentCanteenFood
{
    public partial class Form1 : Form
    {
         
        //lists printer
        private Printer PrinterManager = new Printer("Invoice.txt");
        
        List<MenuItems> orderItems = new List<MenuItems>();
        //arrey  menu items
        MenuItems[] menuItems = new MenuItems[]
        {
            new MenuItems("Coffee", 4),
            new MenuItems("Water", 4),
            new MenuItems("Sandwich", 8),
            new MenuItems("Pizza", 14),
            new MenuItems("Chicken Roll", 10),
            new MenuItems("Pasta Cheese", 8),
            new MenuItems("Meet Ball", 8),
            new MenuItems("Beef ", 8),
            new MenuItems("Panino", 7),
            new MenuItems("Chips", 4),


        };
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(menuItems);
        }

        // printing to a txt.file the order invoice 
        public void bntInvoice_Click(object sender, EventArgs e)
        {
            PrinterManager.Print(orderItems.ToArray(), CalculatedTotal());
            
            
        }


        public void btnAddItems_Click(object sender, EventArgs e)
        {


            // converted  MenuItems to selectedItem
            MenuItems selectedItem = (MenuItems)comboBox1.SelectedItem;


            /*if (selectedItem != null)*/

            if (selectedItem.Name == "Pizza")
            {
                // newPizza Object give the options to choose the topping,crust and size when select Pizza from MenuItems 
                MenuPizza newPizza = new MenuPizza(selectedItem.Name, selectedItem.Price,
                cmbCrust.SelectedItem.ToString(), cmbTop.SelectedItem.ToString(), cmbSiz.SelectedItem.ToString());

                addOrderItems(newPizza);
            }
            else
            {

                addOrderItems(selectedItem);
            }

            Console.WriteLine(comboBox1.SelectedItem);

        }

        // Adding order 
        private void addOrderItems(MenuItems item )
        {

            listBox1.Items.Add(item);
            listBox2.Items.Add(item.Price);
            orderItems.Add(item);
        }

        // clear the order and total 
        private void UpdateOrderList()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            textBox1.Clear();
        }

        // remove selected item from order list
        private void RemoveOrderItem(MenuItems item)
        {

            listBox1.Items.Remove(item);
            listBox2.Items.Remove(item.Price);
            orderItems.Remove(item);
        }
        // button remvove items
        private void button1_Click(object sender, EventArgs e)
        {

            RemoveOrderItem((MenuItems)listBox1.SelectedItem);
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            
            
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           


        }

        //clearing the List  
        private void bntClear_Click(object sender, EventArgs e)
        {
            UpdateOrderList();
        }

        
        
        // sum the total of the selectedItems because a can not work out how to sum only the "selected.Price from listbox1" I created a new listbox2
        public void bntTotal_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Total: $" + CalculatedTotal();


            Console.WriteLine("Total is:  $" + CalculatedTotal());
        }


        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        // Calculate the Total of selected items
        private decimal CalculatedTotal()
        {
            decimal sum = 0;

            for (int i = 0; i < listBox2.Items.Count; i++)
            {

                sum += Convert.ToDecimal(listBox2.Items[i]);
            }
            return sum;

        }






        
    }
}
