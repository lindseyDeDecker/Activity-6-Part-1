using CST_150_ListTogv.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST_150_ListTogv.BuisnessLayer
{
    internal class Inventory
    {
        //The purpose of this class is to read the txt file into a List
        //Then pass the list to the FrmInventory.cs

        ///<summary>
        /// Read the inventory txt fo;e amd retuen a ;ost pf type InvItems class
        /// </summary>
        /// <return>
        /// </return>
        public List<InvItem> ReadInventory(List<InvItem> invItems)
        {
            //Enter the location of the file to open
            string dirLoc = Application.StartupPath + "\\Topic6.txt";

                //Open the file with "using"
                //The main goal to use "using:" is to manage resources and release all the 
                //resources automatically when done. (garbage collector)
                using (var str = File.OpenText(dirLoc))
            {
                //Iterate through the text file one line at a time
                foreach(string line in File.ReadLines(dirLoc, Encoding.UTF8))
                {
                    //Split up the line at each comma and don't forget to trim.
                    string[] rowData = line.Split(",");
                    //Now we can add the line to our List<InvItem>
                    //Which is our class model.
                    invItems.Add(new InvItem(rowData[0].ToString().Trim(),
                        rowData[1].ToString().Trim(), Convert.ToInt32(rowData[2])));
                }
            }
            //Return the List
            return invItems;
                
        }

        ///<summary>
        /// Inc Inventory in the list and then return the updated list
        /// </summary>
        ///<param name="invItems"></param>
        ///<param name="selectedRowIndex"></param>
        ///<return></return>
        ///
        public List<InvItem> IncQtyValue(List<InvItem> invItems, int selectedRowIndex)
        {
            //Increment the quantity calue using the property name from the model
            int updatedQty = ++invItems[selectedRowIndex].Qty;

            //Then put the value back into the list so we keep a master list
            invItems[selectedRowIndex].Qty = updatedQty;

            //return the list
            return invItems;

        }

        public void SaveInventory(List<InvItem> invItems)
        {
            string dirLoc = Application.StartupPath + "\\Topic6.txt";

            using (var writer = new StreamWriter(dirLoc, false, Encoding.UTF8))
            {
                foreach (var item in invItems)
                {
                    string line = $"{ item.Type},{ item.Color},{ item.Qty}";
                    writer.WriteLine(line);
                }
            }
        }

    }
}
