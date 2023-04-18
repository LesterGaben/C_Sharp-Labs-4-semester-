using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2 {
    public class Trolleybus {

        public int Number { get; set; }
        public int InventoryNumber { get; set; }

        public int PassengerSeats { get; set; }

        public string Type { get; set; }
        public string Colour { get; set; }

        public Trolleybus() { }
        public Trolleybus(int number, int inventoryNumber, int passengerSeats, string type, string colour) {
            Number = number;
            InventoryNumber = inventoryNumber;
            PassengerSeats = passengerSeats;
            Type = type;
            Colour = colour;
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Номер: {Number}");
            sb.AppendLine($"Інвентарний номер: {InventoryNumber}");
            sb.AppendLine($"К-сть пасажирських місць: {PassengerSeats}");
            sb.AppendLine($"Тип: {Type}");
            sb.AppendLine($"Колір: {Colour}");
            return sb.ToString();
        }
    }
}
