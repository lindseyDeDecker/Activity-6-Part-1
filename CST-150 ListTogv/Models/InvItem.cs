using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST_150_ListTogv.Models
{
    /// <summary>
    /// Model class that will structure all my inventory items
    /// </summary>
    internal class InvItem
    {
        //DEfine the Properties
        public string Type { get; set; }

        public InvItem(string type)
        {
            Type = type;
        }

        public string Color { get; set; }  
        public int Qty { get; set; }

        public InvItem(int qty)
        {
            Qty = qty;
        }

        ///<summary>
        /// Model Class Parameterized Constructor
        /// </summary>
        /// <param name="type"></param>
        /// <param name="color"></param>
        /// <param name="qty"></param>
        public InvItem(string type, string color, int qty)
        {
            //Constructor is initializing the properties
            Type = type;
            Color = color;  
            Qty = qty;  
        }
    }
}
