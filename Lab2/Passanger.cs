using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2 {
    public class Passanger {
        public string FullName { get; set; }
        public TrolleybusStop InitialStop { get; set; }
        public TrolleybusStop LastStop { get; set; }
        public int NumOfTrolleybus { get; set; }
        public Passanger() { }
        public Passanger(string fullName, TrolleybusStop initialStop, TrolleybusStop lastStop, int numOfTrolleybus) {
            FullName = fullName;
            InitialStop = initialStop;
            LastStop = lastStop;
            NumOfTrolleybus = numOfTrolleybus;
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"ПІБ: {FullName}");
            sb.AppendLine($"Початкова зупинка: {InitialStop.Name}");
            sb.AppendLine($"Кінцева зупинка: {LastStop.Name}");
            sb.AppendLine($"Номер тролейбуса, яким скористався пасажир: {NumOfTrolleybus}");
            return sb.ToString();
        }
    }
}
