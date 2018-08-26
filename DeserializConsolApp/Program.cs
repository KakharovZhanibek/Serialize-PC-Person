using ClassLib.Model;
using InviteUser;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace DeserializConsolApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            //BinaryFormatter bf = new BinaryFormatter();

            //using (FileStream fs = new FileStream(@"\\dc\Студенты\ПКО\SMP-172.1\listSerial.txt", FileMode.OpenOrCreate))
            //{
            //    var t = (List<PC>)bf.Deserialize(fs);
            //    Console.WriteLine("Объекты успешно десериализированы");
            //    foreach (PC item in t)
            //    {
            //        Console.WriteLine(item.Mark + "\t" + item.Model + "\t" + item.Price + "\t" + item.SerialNumber);
            //    }
            //}

            ServicePerson.GenerateW();
            ServicePerson.Deserialize();
            
        }
    }
}
