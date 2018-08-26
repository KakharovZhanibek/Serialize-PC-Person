using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Model
{
    [Serializable]
    public class PC
    {
        public PC()
        {

        }
        public PC(string model, string mark, string serialNumber, double price)
        {
            this.SerialNumber = serialNumber;
            this.Mark = mark;
            this.Price = price;
            this.Model = model;
        }
        public string Mark { get; set; }
        public string SerialNumber { get; set; }
    
        public string Model { get; set; }
        public double Price { get; set; }
        
        [NonSerialized]
        public int Id;

    }
}
