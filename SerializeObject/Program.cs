using ClassLib.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SerializeObject
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<PC> pcList = new List<PC>();

            pcList.Add(new PC("pentium", "mark1", Guid.NewGuid().ToString(), 500000) {Id= 1});
            pcList.Add(new PC("Acer", "mark1", Guid.NewGuid().ToString(), 800000) { Id = 2 });
            pcList.Add(new PC("Lenovo", "mark1", Guid.NewGuid().ToString(), 300000) { Id = 3 });
            pcList.Add(new PC("Apple", "mark1", Guid.NewGuid().ToString(), 900000) { Id = 4 });

            BinaryFormatter bf = new BinaryFormatter();

            using (FileStream fs = new FileStream(@"\\dc\Студенты\ПКО\SMP-172.1\listSerial.txt", FileMode.OpenOrCreate))
            {
                bf.Serialize(fs,pcList);
                Console.WriteLine("Объекты успешно сериализированы");
            }
        }   
    }
}
