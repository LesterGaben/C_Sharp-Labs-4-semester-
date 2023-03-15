using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab1 {
    public class Route {

        public int RouteNumber { get; set; } 
        public string Name { get; private set; }
        public TrolleybusStop InitialStop { get; set; }
        public TrolleybusStop LastStop { get; set; }
        public int NumOfTrolleybus { get; set; }
        public DateTime? JourneyTime { get; set; }

        public List<int> InventoryNumsOfTrolleybusOnRoute { get; set; }

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
            return string.Format($"Номер: {RouteNumber}\n" +
                $"Назва: {Name}\n" +
                $"Початкова зупинка: {InitialStop.Name}\n" +
                $"Кінцева зупинка: {LastStop.Name}\n" +
                $"К-сть тролейбусів на маршруті: {NumOfTrolleybus}\n" +
                $"Тривалість проїзду маршруту: {JourneyTime.Value.Hour} год. {JourneyTime.Value.Minute}хв.\n" +
                $"Список інвентарних номерів тролейбусів на маршруті: {GetTrList(InventoryNumsOfTrolleybusOnRoute)}\n");
        }

        private string GetTrList(List<int> list) {
            string temp = string.Empty;
            foreach (int i in list) {
                temp += i.ToString() + ", ";
            }
            return temp;
        }
    }
}
