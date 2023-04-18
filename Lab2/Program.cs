using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Lab2 {
    internal class Program {

        public static void Main(string[] args) {

            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            List<TrolleybusStop> trolleybusStops = new List<TrolleybusStop>() {
                new TrolleybusStop("Академмістечко", "бульвар Академіка Вернадського, 88, Київ, 03178"),
                new TrolleybusStop("Святошин", "бульвар Академіка Вернадського, 38А, Київ, 03062"),
                new TrolleybusStop("Нова Пошта №4", "вулиця Верховинна, 69, Київ, 03115"),
                new TrolleybusStop("Сільпо", "проспект Перемоги, 87, Київ, 03115"),
                new TrolleybusStop("Новус №1","вулиця Святошинська, 3, Київ, 03115"),
                new TrolleybusStop("АТБ №1", "вулиця Святошинська, 4, Київ, 03115"),
                new TrolleybusStop("ОККО", "вулиця Святошинська, 34 Б, Київ, 03680"),
                new TrolleybusStop("Новус №2", "вулиця Центральна, 2, Ірпінь, Київська обл., 08200"),
                new TrolleybusStop("Університет державної фіскальної служби України", "вулиця Університетська, 31, Ірпінь, Київська обл., 08200"),
                new TrolleybusStop("Київський політехнічний інститут імені Ігоря Сікорського", "проспект Перемоги, 37, Київ, 03056"),
                new TrolleybusStop("Корпус № 18 КПІ імені Ігоря Сікорського", "вулиця Політехнічна, 41, Київ, 03056"),
                new TrolleybusStop("АТБ №2", "вулиця Політехнічна, 31, Київ, 03056")
            };

            List<Trolleybus> trolleybuses = new List<Trolleybus>() {
                new Trolleybus(10, 1, 25, "ЛК-5", "Червоний"),
                new Trolleybus(10, 8, 26, "ЯТБ-1", "Чорний"),
                new Trolleybus(1, 2, 25, "ЛК-5", "Червоний"),
                new Trolleybus(2, 22, 30, "ЯТБ-2", "Жовтий"),
                new Trolleybus(3, 40, 37, "ЯТБ-4", "Сірий"),
                new Trolleybus(4, 28, 37, "ЯТБ-3", "Сірий"),
                new Trolleybus(1, 29, 37, "ЯТБ-3", "Чорний"),
                new Trolleybus(10, 101, 30, "14Tr", "Білий"),
                new Trolleybus(2, 102, 30, "14Tr", "Білий"),
                new Trolleybus(5, 410, 50, "14TrМ", "Рожевий")
            };

            List<Route> routes = new List<Route>() {
                new Route(10, trolleybusStops[0], trolleybusStops[11], 3, 500, new List<int>() {1, 8, 101}),
                new Route(1, trolleybusStops[2], trolleybusStops[5], 2, 300, new List<int>() {2, 29}),
                new Route(2, trolleybusStops[9], trolleybusStops[8], 2, 1000, new List<int>() {22, 102}),
                new Route(3, trolleybusStops[4], trolleybusStops[7], 1, 250, new List<int>() {40}),
                new Route(4, trolleybusStops[6], trolleybusStops[2], 1, 200, new List<int>() {28}),
                new Route(5, trolleybusStops[0], trolleybusStops[6], 1, 150, new List<int>() {410})
            };

            List<Passanger> passangers = new List<Passanger>() {
                new Passanger("Залужний Валерій Федорович", trolleybusStops[9], trolleybusStops[8], 2),
                new Passanger("Карась Євген Васильович", trolleybusStops[1], trolleybusStops[11], 10),
                new Passanger("Дмитро Олександрович Корчинський", trolleybusStops[6], trolleybusStops[3], 4),
                new Passanger("Муха Ірина Павлівна", trolleybusStops[9],
                trolleybusStops[10], 2),
                new Passanger("Муха Ірина Павлівна", trolleybusStops[10], trolleybusStops[1], 1)
            };

            //Створення файлу за допомогою XmlWriter
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            using (XmlWriter writer = XmlWriter.Create("routes.xml", settings)) {
                writer.WriteStartElement("routes");
                foreach (Route route in routes) {
                    writer.WriteStartElement("route");
                    writer.WriteElementString("routeNumber", route.RouteNumber.ToString());
                    writer.WriteElementString("name", route.Name);
                    writer.WriteStartElement("initialStop");
                    writer.WriteElementString("name", route.InitialStop.Name);
                    writer.WriteElementString("address", route.InitialStop.Address);
                    writer.WriteEndElement();
                    writer.WriteStartElement("lastStop");
                    writer.WriteElementString("name", route.LastStop.Name);
                    writer.WriteElementString("address", route.LastStop.Address);
                    writer.WriteEndElement();
                    writer.WriteElementString("numOfTrolleybus", route.NumOfTrolleybus.ToString());
                    writer.WriteElementString("journeyTime", route.JourneyTime.ToString());
                    writer.WriteStartElement("inventoryNumsOfTrolleybusOnRoute");
                    foreach (int temp in route.InventoryNumsOfTrolleybusOnRoute)
                        writer.WriteElementString("int", temp.ToString());
                    writer.WriteEndElement();
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
            }

            XmlSerializer serializer = new XmlSerializer(typeof(List<Route>));

            using (TextWriter writer = new StreamWriter("routesS.xml")) {
                serializer.Serialize(writer, routes);
            }

            //Десеріалізація файлу
            using (TextReader reader = new StreamReader("routesS.xml")) {

                List<Route> routes1 = (List<Route>)serializer.Deserialize(reader);
                Console.WriteLine("Вміст файлу routesS.xml:\n");
                foreach(var route in routes1) {
                    Console.WriteLine(route);
                }
                Console.WriteLine();

            }


            //LINQ запити
            XDocument data = XDocument.Load("routesS.xml");
            Console.WriteLine("------------------------Запити------------------------");
            // 1. Виведення всіх назв маршрутів 
            var querry1 = from route in data.Descendants("Route")
                          select route.Element("Name").Value;

            Console.WriteLine("1.Виведення всіх назв маршрутів:\n");
            foreach (var querry in querry1) {
                Console.WriteLine(querry);
            }
            Console.WriteLine();


            // 2. Виведення переліку всіх маршрутів, відсортованих по тривалості руху у порядку зростання
            var querry2 = from route in data.Descendants("Route")
                          orderby DateTime.Parse(route.Element("JourneyTime").Value)
                          select new { Name = route.Element("Name").Value, JourneyTime = DateTime.Parse(route.Element("JourneyTime").Value) };

            Console.WriteLine("\n2.Виведення переліку всіх маршрутів, відсортованих по тривалості руху у порядку зростання:\n");
            foreach (var querry in querry2) {
                Console.WriteLine($"Назва маршруту: {querry.Name}\n" +
                    $"Тривалість проїзду маршруту: {querry.JourneyTime.Hour} год. {querry.JourneyTime.Minute}хв.\n");
            }


            // 3. Виведення маршрутів назва яких починається на 'А'
            var querry3 = from route in data.Descendants("Route")
                          where route.Element("Name").Value.StartsWith('А')
                          select route.Element("Name").Value;

            Console.WriteLine("\n3.Виведення маршрутів назва яких починається на 'А':\n");
            foreach (var querry in querry3) {
                Console.WriteLine(querry);
            }
            Console.WriteLine();


            // 4. Згрупувати Маршрути по початковим зупинкам

            var querry4 = trolleybusStops.GroupJoin(data.Descendants("Route"),
                                                    t => t.Name,
                                                    r => r.Element("InitialStop").Element("Name").Value,
                                                    (t, routes1) => new {Name = t.Name, Routes = routes1.Select(r => r.Element("Name").Value)});

            Console.WriteLine("\n4.Згрупувати Маршрути по початковим зупинкам:\n");
            foreach (var querry in querry4) {
                Console.WriteLine("Зупинка: " + querry.Name);
                Console.WriteLine("Маршрути де зупинка є початковою:");
                foreach (var temp in querry.Routes) {
                    Console.WriteLine(temp);
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            // 5.Виведення назви найтривалішого маршруту:

            var querry5 = data.Descendants("Route").Where(r => DateTime.Parse(r.Element("JourneyTime").Value).
                                                    Equals(data.Descendants("Route").Max(r => DateTime.Parse(r.Element("JourneyTime").Value))));

            Console.WriteLine("\n5.Виведення назви найтривалішого маршруту:\n");
            foreach (var querry in querry5) {
                Console.WriteLine(querry.Element("Name").Value);
                var maxRouteDuration = DateTime.Parse(querry.Element("JourneyTime").Value);
                Console.WriteLine($"Тривалість маршруту: {maxRouteDuration.Hour} год. {maxRouteDuration.Minute}хв.\n");
            }


            // 6.Декартовий добуток пасажирів та маршрутів

            var querry6 = from p in passangers
                          from r in data.Descendants("Route")
                          select new { PassangerName = p.FullName, RouteName = r.Element("Name").Value };

            Console.WriteLine("\n6.Декартовий добуток пасажирів та маршрутів:\n");
            foreach (var querry in querry6) {
                Console.WriteLine($"{querry.PassangerName} + {querry.RouteName}\n");
            }


            // 7.Виведення пасажирів відсортованих по тривалості маршруту, яким вони рухалися у порядку зростання

            var querry7 = passangers.Join(data.Descendants("Route"), p => p.NumOfTrolleybus, r => Int32.Parse(r.Element("RouteNumber").Value),
                        (p, r) => new { PassangerFullName = p.FullName, RouteDuration = DateTime.Parse(r.Element("JourneyTime").Value) }).
                        OrderBy(t => t.RouteDuration);

            Console.WriteLine("\n7.Виведення пасажирів відсортованих по тривалості маршруту, яким вони рухалися у порядку зростання:\n");
            foreach (var querry in querry7) {
                Console.WriteLine($"Пасажир: {querry.PassangerFullName}; Тривалість маршруту: {querry.RouteDuration.Hour}год. {querry.RouteDuration.Minute}хв.");
            }
            Console.WriteLine("\n");


            // 8.Перевірка чи всі маршрути мають тривалість >= 200 кількості хвилин

            int minutes = 200;
            DateTime dateTime = new DateTime();
            dateTime = dateTime.AddHours((double)minutes / 60);
            dateTime = dateTime.AddMinutes((double)minutes % 60);

            var queerry8 = data.Descendants("Route").All(r => DateTime.Parse(r.Element("JourneyTime").Value) >= dateTime);
            Console.WriteLine(@"8.Чи у всіх маршрутів тривалість >= {0}хв.? : {1}", minutes, (queerry8 ? "Так" : "Ні"));
            Console.WriteLine();


            // 9.Виведення тролейбусів які закріплені за маршрутами

            var querry9 = trolleybuses.Join(data.Descendants("Route"), t => t.Number, r => Int32.Parse(r.Element("RouteNumber").Value),
                (t, r) => new { RouteName = r.Element("Name").Value, TrolleybusNumber = t.Number, PassangerSits = t.PassengerSeats, Type = t.Type, Colour = t.Colour });

            Console.WriteLine("\n9.Виведення тролейбусів які закріплені за маршрутом:\n");
            foreach(var querry in querry9) {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Назва маршруту: {querry.RouteName};");
                sb.AppendLine($"Номер тролейбусу: {querry.TrolleybusNumber};");
                sb.AppendLine($"К-сть пасажирських місць : {querry.PassangerSits}");
                sb.AppendLine($"Тип: {querry.Type};");
                sb.AppendLine($"Колір: {querry.Colour}");
                Console.WriteLine(sb);
            }


            // 10.Виведення даних про тролейбуси на яких їздила Муха Ірина Павлівна

            var querry10 = from p in passangers
                           where p.FullName.Equals("Муха Ірина Павлівна")
                           join t in trolleybuses on p.NumOfTrolleybus equals t.Number
                           join r in data.Descendants("Route") on t.Number equals Int32.Parse(r.Element("RouteNumber").Value)
                           select new {
                               RouteName = r.Element("Name").Value,
                               Passanger = p.FullName,
                               Number = t.Number,
                               InventoryNumber = t.InventoryNumber,
                               PassangerSeats = t.PassengerSeats,
                               Type = t.Type,
                               Colour = t.Colour
                           };
            Console.WriteLine("\n10.Виведення даних про тролейбуси на яких їздила Муха Ірина Павлівна:\n");
            foreach(var querry in querry10) {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Назва маршруту: {querry.RouteName}");
                sb.AppendLine($"ПІБ пасажира: {querry.Passanger}");
                sb.AppendLine($"Номер: {querry.Number}");
                sb.AppendLine($"Інвентарний номер: {querry.InventoryNumber}");
                sb.AppendLine($"К-сть пасажирських місць: {querry.PassangerSeats}");
                sb.AppendLine($"Тип: {querry.Type}");
                sb.AppendLine($"Колір: {querry.Colour}");
                Console.WriteLine(sb);
            }


            // 11.Виведення суми номерів маршрутів

            var querry11 = data.Descendants("Route").Sum(route => Int32.Parse(route.Element("RouteNumber").Value));

            Console.WriteLine("\n11.Виведення суми номерів маршрутів: " + querry11 + "\n");


            // 12.Виведення назв маршрутів без врахування заданої к-сті маршрутів з кінця

            int num = 2;
            var querry12 = data.Descendants("Route").SkipLast(num);

            Console.WriteLine($"\n12.Виведення назв маршрутів без врахування {num} маршрутів з кінця:\n");
            foreach (var querry in querry12.Elements("Name")) {
                Console.WriteLine(querry.Value);
            }
            Console.WriteLine();


            // 13.Виведення назв маршрутів к-сть букв в назві яких є >= мінімальної к-сті пасажирських місць із списку тролейбусів

            var querry13 = data.Descendants("Route").Elements("Name").Where(r => r.Value.Length >= trolleybuses.Min(t => t.PassengerSeats));

            Console.WriteLine("\n13. Виведення назв маршрутів к-сть букв в назві яких є >= мінімальної к-сті пасажирських місць із списку тролейбусів:\n");
            foreach(var querry in querry13) {
                Console.WriteLine(querry.Value);
            }
            Console.WriteLine();


            // 14.Виведення першого маршруту номер якого >= 10

            var querry14 = (from r in data.Descendants("Route") select r).First(r => Int32.Parse(r.Element("RouteNumber").Value) >= 10);

            Console.WriteLine("\n14.Виведення першого маршруту номер якого >= 10:\n");

            Console.WriteLine($"Назва маршруту: {querry14.Element("Name").Value}\n" +
                              $"Номер маршруту: {querry14.Element("RouteNumber").Value}\n");


            // 15.Перевірка чи є маршрут Академмістечко - АТБ №2 в файлі з маршрутами

            string tempRoute = "Академмістечко - АТБ №2";
            var querry15 = (from r in data.Descendants("Route") select r.Element("Name").Value).Contains(tempRoute);

            Console.WriteLine();
            Console.WriteLine(@"15.Чи є маршрут {0} в файлі з маршрутами? : {1}", tempRoute, (querry15 ? "Так" : "Ні"));

        }
    }
}