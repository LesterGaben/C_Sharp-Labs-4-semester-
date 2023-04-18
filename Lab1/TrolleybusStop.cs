using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab1 {
    public class TrolleybusStop {
        
        public string Name { get; set; }
        public string Address { get; set; }
        public TrolleybusStop(string name, string address) {
            Name = name;
            Address = address;
        }
        public override string ToString() {
            return string.Format(@$"Зупинка: {Name}\n
                Адреса: {Address} \n");
        }

    }
}
