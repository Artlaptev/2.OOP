using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingLibraryDLL
{
    public class Building
    {
        public static int lastCreatedBuilding;


        private string _id;
        private int _qtyFloor;
        private int _qtySection;
        private int _qtyFlatsOnTheFloor=3;
        private int _heightOfFloor = 2700;
        
        
        public Building(int qtyFloor,int qtysection)
        {

            SetID();
            _qtyFloor= qtyFloor;
            _qtySection= qtysection;
        }
        private void SetID()
        {
            lastCreatedBuilding++;
            _id = lastCreatedBuilding.ToString().PadLeft(4,'0');
        }
        private void SetQtyFloor(int qty)
        {
            if(qty>0)
                _qtyFloor = qty;
            else
                throw new Exception("Колличество должно быть положительным");
        }
        private void SetQtySection(int qty)
        {
            if (qty > 0)
                _qtySection = qty;
            else
                throw new Exception("Колличество должно быть положительным");
        }
        public int GetQtyFlatsInBiulding()
        {
            return  GetQtyFlatsInSection()* _qtySection;
        }
        public int GetQtyFlatsInSection()
        {
            return _qtyFloor * _qtyFlatsOnTheFloor;
        }
        public int GetHeight()
        {
            return 2700 * _qtyFloor + 1900 + 1200;
        }

        public string GetId()
        {
            return _id;
        }

        public override string ToString()
        {
            return "Здание: "+_id + ", Количество этажей: "+_qtyFloor+", Количество подъездов: " +_qtySection+", Всего квартир: "+GetQtyFlatsInBiulding()+", Высота: "+GetHeight();
        }
    }
   
}
