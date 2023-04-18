using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2 {
    public class Route {

        public int RouteNumber { get; set; }
        public string Name { get; set; }
        public TrolleybusStop InitialStop { get; set; }
        public TrolleybusStop LastStop { get; set; }
        public int NumOfTrolleybus { get; set; }
        public DateTime JourneyTime { get; set; }

        public List<int> InventoryNumsOfTrolleybusOnRoute { get; set; }

        public Route() { }
        public Route(int routeNumber, TrolleybusStop initialStop, TrolleybusStop lastStop, int numOfTrolleybus, int journeyTimeInMinutes, List<int> inventorynumsOfTrolleybusOnRoute) {
            RouteNumber = routeNumber;
            InitialStop = initialStop;
            LastStop = lastStop;
            Name = $"{InitialStop.Name} - {LastStop.Name}";
            NumOfTrolleybus = numOfTrolleybus;
            JourneyTime = CountJourneyTime(journeyTimeInMinutes);
            InventoryNumsOfTrolleybusOnRoute = inventorynumsOfTrolleybusOnRoute;
        }

        private DateTime CountJourneyTime(int journeyTimeInMinutes) {
            DateTime dateTime = new DateTime();
            dateTime = dateTime.AddHours((double)journeyTimeInMinutes / 60);
            dateTime = dateTime.AddMinutes((double)journeyTimeInMinutes % 60);
            return dateTime;
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Номер: {RouteNumber}");
            sb.AppendLine($"Назва: {Name}");
            sb.AppendLine($"Початкова зупинка: {InitialStop.Name}");
            sb.AppendLine($"Кінцева зупинка: {LastStop.Name}");
            sb.AppendLine($"К-сть тролейбусів на маршруті: {NumOfTrolleybus}");
            sb.AppendLine($"Тривалість проїзду маршруту: {JourneyTime.Hour} год. {JourneyTime.Minute}хв.");
            sb.AppendLine($"Список інвентарних номерів тролейбусів на маршруті: {string.Join(", ", InventoryNumsOfTrolleybusOnRoute)}");
            return sb.ToString();
        }

    }
}
