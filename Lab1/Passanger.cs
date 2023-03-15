using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab1 {
    public class Passanger {
        public string FullName { get; set; }
        public TrolleybusStop InitialStop { get; set; }
        public TrolleybusStop LastStop { get; set; }
        public int NumOfTrolleybus { get; set; }
        public Passanger(string fullName, TrolleybusStop initialStop, TrolleybusStop lastStop, int numOfTrolleybus) {
            FullName = fullName;
            InitialStop = initialStop;
            LastStop = lastStop;
            NumOfTrolleybus = numOfTrolleybus;
        }

        public override string ToString() {
            return string.Format($"ПІБ: {FullName}\n" +
                $"Початкова зупинка: {InitialStop.Name}\n" +
                $"Кінцева зупинка: {LastStop.Name}\n" +
                $"Номер тролейбуса, яким скористався пасажир: {NumOfTrolleybus}\n");
        }
    }
}
