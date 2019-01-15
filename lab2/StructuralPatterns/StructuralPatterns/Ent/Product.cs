using StructuralPatterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Ent
{
    public class Product : IProduct
    {
        public string Name { get; set;} 
        public DateTime DoP { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }

        public void ShowData()
        {
            Console.WriteLine($"Nume: {Name}");
            Console.WriteLine($"Data productiei: {DoP}");
            Console.WriteLine($"Pret: {Price}");
            Console.WriteLine($"Descriere: {Description}");

        }


        //Additional info which is hiden from clients when shown as a model:
        //
        //
        //




    }
}
