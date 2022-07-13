using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingLibrary
{
    public static class Creator
    {
        public static Hashtable HTbuildings = new Hashtable();
        public static string CreateBuild(int qtyFloor, int qtysection)
        {
                Building building = new Building(qtyFloor,qtysection);
                HTbuildings.Add(building.GetId(), building);
                return building.ToString();
        }
    }
}
