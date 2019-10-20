using System;
using System.Collections.Generic;
using System.Text;

namespace epam.Pronin.SummerPractice.Entities
{
    public class Lot
    {
        public int Id_lot { get; set; }
        public string Name_Lot { get; set; }

        public Lot()
        {

        }

        public Lot(string name)
        {
            Name_Lot = name;           
        }
    }
}
