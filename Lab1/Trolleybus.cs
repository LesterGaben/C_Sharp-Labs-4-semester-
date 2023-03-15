using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab1 {
    public class Trolleybus {

        public int Number { get; set; }
        public int InventoryNumber { get; set; }

        public int PassengerSeats { get; set; }

        public string Type { get; set; }
        public string Colour { get; set; }

        public Trolleybus(int number, int inventoryNumber, int passengerSeats, string type, string colour) {
            Number = number;
            InventoryNumber = inventoryNumber;
            PassengerSeats = passengerSeats;
            Type = type;
            Colour = colour;
        }

        public override string ToString() {
            return string.Format($"Номер: {Number}\n" +
                $"Інвентарний номер: {InventoryNumber}\n" +
                $"К-сть пасажирських місць: {PassengerSeats}\n" +
                $"Тип: {Type}\n" +
                $"Колір: {Colour}\n");
        }
    }
}
