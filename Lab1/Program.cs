using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1 {
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

            /// <summary>
            /// 1) Виведення всіх тролейбусних зупинок
            /// </summary>
            //GetAllTrolleybusStop(trolleybusStops);
            
            /// <summary>
            /// 2) Виведення зупинок, назва яких починається на 'А'
            /// </summary>
            //GetTrStopWhereAIsFirst(trolleybusStops);
            
            /// <summary>
            /// 3) Виведення переліку всіх маршрутів, відсортованих по тривалості руху у порядку зростання
            /// </summary>
            //GetRoutesSortedByJourneyTime(routes);
            
            /// <summary>
            /// 4) Виведення пасажирів заданого тролейбусу
            /// </summary>
            //GetTrPassangers(passangers, 3);
            
            /// <summary>
            /// 5) Виведення ПІБ пасажира, назви його кінцевої зупинки та її адреси
            /// </summary>
            //GetPassangersLastStopAndAdress(passangers, trolleybusStops);
            
            /// <summary>
            /// 6) Виведення даних про тролейбуси на яких їздила Муха Ірина Павлівна
            /// </summary>
            //GetTrolleybusWhereWasMucha(passangers, trolleybuses);
            
            /// <summary>
            /// 7) Виведення кількості тролейбусів заданого кольору
            /// </summary>
            //GetCountTrByColour(trolleybuses, "Червоний");
            
            /// <summary>
            /// 8) Виведення даних про найтриваліший маршрут
            /// </summary>
            //GetLongestRoute(routes);
            
            /// <summary>
            /// 9) Групування пасажирів по номеру тролейбуса
            /// </summary>
            //GetGroupPassangerByTrNum(passangers);
            
            /// <summary>
            /// 10) Виведення даних про зупинки без врахування заданої к-сті зупинок з кінця
            /// </summary>
            //GetStopsWithoutLastNums(trolleybusStops, 10);
            
            /// <summary>
            /// 11) Виведення першого в списку тролейбусу з інвентарним номером, який >= сумі номерів тролейбусів
            /// </summary>
            //Task11(trolleybuses);
            
            /// <summary>
            /// 12)Декартовий добуток пасажирів та маршрутів
            /// </summary>
            //Task12(passangers, routes);
            
            /// <summary>
            /// 13) Виведення ПІБ пасажирів зі списку
            /// </summary>
            //Task13(passangers);
            
            /// <summary>
            /// 14) Перевірка чи є хтось з пасажирів хто прямумав до сільпо
            /// </summary>
            //Task14(passangers);
            
            /// <summary>
            /// 15) Перевірка чи є задана зупинка в списку зупинок
            /// </summary>
            //Task15(trolleybusStops, "Сільпо");
            
            /// <summary>
            /// 16) Виведення пасажирів к-сть букв в ПІБ яких є >= мінімальної к-сті пасажирських місць із списку тролейбусів
            /// </summary>
            //Task16(passangers, trolleybuses);
            
            /// <summary>
            /// 17) Виведення пасажирів відсортованих по тривалості маршруту, яким вони рухалися у порядку зростання
            /// </summary>
            //Task17(passangers, routes);
            
            /// <summary>
            /// 18) Перевірка чи всі маршрути мають тривалість >= заданої кількості хвилин
            /// </summary>
            //Task18(routes, 200);
            
            /// <summary>
            /// 19) Виведення тролейбусів які закріплені за маршрутами
            /// </summary>
            //Task19(trolleybuses, routes);
            
            /// <summary>
            /// 20) Виведення пасажирів чий ПІБ закінчується на задану букву 
            /// </summary>
            //Task20(passangers, 'ч');
            
            /// <summary>
            /// 21) Згрупувати Маршрути по початковим зупинкам
            /// </summary>
            Task21(routes, trolleybusStops);
        }

        //Всі запити:

        //Додатковий запит в якому я показав як працює багато-до-багатьох на прикладі зупинки "Академмістечко"
        /// <summary>
        /// 21) Згрупувати Маршрути по початковим зупинкам
        /// </summary>
        /// <param name="routes"></param>
        /// <param name="trolleybusStops"></param>
        public static void Task21(List<Route> routes, List<TrolleybusStop> trolleybusStops) {

            var result = trolleybusStops.GroupJoin(routes, t => t,
                                                   r => r.InitialStop,
                                                   (t, routes) => new { Name = t.Name, Routes = routes });
            Console.WriteLine("\n21)Згрупувати Маршрути по початковим зупинкам:");
            foreach (var r in result) {
                Console.WriteLine("Зупинка: " + r.Name);
                Console.WriteLine("Маршрути де зупинка є початковою:");
                foreach (var temp in r.Routes) {
                    Console.WriteLine(temp.Name);
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// 1) Виведення всіх тролейбусних зупинок
        /// </summary>
        /// <param name="trolleybusStopList"></param>
        public static void GetAllTrolleybusStop(List<TrolleybusStop> trolleybusStopList) {

            var result = from stop in trolleybusStopList 
                         select stop;

            Console.WriteLine("\n1)Виведення всіх тролейбусних зупинок:\n");
            foreach (var stop in result) {
                Console.WriteLine(stop);
            }
        }

        /// <summary>
        /// 2) Виведення зупинок, назва яких починається на 'А'
        /// </summary>
        /// <param name="trolleybusStopList"></param>
        public static void GetTrStopWhereAIsFirst(List<TrolleybusStop> trolleybusStopList) {

            var result = trolleybusStopList.Where(t => t.Name.StartsWith('А'));

            Console.WriteLine("\n2)Виведення зупинок, назва яких починається на 'А':");
            foreach (var stop in result) {
                Console.WriteLine(stop);
            }
        }

        /// <summary>
        /// 3) Виведення переліку всіх маршрутів, відсортованих по тривалості руху у порядку зростання
        /// </summary>
        public static void GetRoutesSortedByJourneyTime(List<Route> routes) {

            var result = from route in routes
                         orderby route.JourneyTime
                         select route;
            Console.WriteLine("\n3)Виведення переліку всіх маршрутів, відсортуваних по тривалості руху у порядку зростання:");
            foreach (var route in result) {
                Console.WriteLine(route);
            }
        }

        /// <summary>
        /// 4) Виведення пасажирів заданого тролейбусу
        /// </summary>
        /// <param name="passangers"></param>
        public static void GetTrPassangers(List<Passanger> passangers, int NumOfTrolleybus) {
            
            var result = from passanger in passangers
                         where passanger.NumOfTrolleybus == NumOfTrolleybus
                         select passanger;
            Console.WriteLine($"\n4) Виведення пасажирів {NumOfTrolleybus}го тролейбусу:");
            foreach (var passanger in result) {
                Console.WriteLine(passanger);
            }
             
        }

        /// <summary>
        /// 5) Виведення ПІБ пасажира, назви його кінцевої зупинки та її адреси
        /// </summary>
        /// <param name="passangers"></param>
        /// <param name="trolleybusStops"></param>
        public static void GetPassangersLastStopAndAdress(List<Passanger> passangers, List<TrolleybusStop> trolleybusStops) {

            var result = from passanger in passangers
                         join trolleybusStop in trolleybusStops on passanger.LastStop equals trolleybusStop
                         select new { FullName = passanger.FullName, LastStop = passanger.LastStop, Address = trolleybusStop.Address };
            Console.WriteLine("\n5)Виведення ПІБ пасажира, назви його кінцевої зупинки та її адреси:");
            foreach (var temp in result) {
                Console.WriteLine(temp);
            }
        }

        /// <summary>
        /// 6) Виведення даних про тролейбуси на яких їздила Муха Ірина Павлівна
        /// </summary>
        /// <param name="passangers"></param>
        public static void GetTrolleybusWhereWasMucha(List<Passanger> passangers, List<Trolleybus> trolleybuses) {

            var result = passangers.Where(p => p.FullName.Equals("Муха Ірина Павлівна"))
                                   .Join(trolleybuses, p => p.NumOfTrolleybus, t => t.Number,
                                   (p, t) => new { Passanger = p.FullName, Number = t.Number,
                                   InventoryNumber = t.InventoryNumber, PassangerSeats = t.PassengerSeats, Type = t.Type, Colour = t.Colour });

            Console.WriteLine("\n6)Виведення даних про тролейбуси на яких їздила Муха Ірина Павлівна:");
            foreach (var temp in result) {
                Console.WriteLine($"ПІБ пасажира: {temp.Passanger}\n" +
                $"Номер: {temp.Number}\n" +
                $"Інвентарний номер: {temp.InventoryNumber}\n" +
                $"К-сть пасажирських місць: {temp.PassangerSeats}\n" +
                $"Тип: {temp.Type}\n" +
                $"Колір: {temp.Colour}\n");
            }
        }

        /// <summary>
        /// 7) Виведення кількості тролейбусів заданого кольору
        /// </summary>
        /// <param name="trolleybuses"></param>
        /// <param name="colour"></param>
        public static void GetCountTrByColour(List<Trolleybus> trolleybuses, string colour) {

            var result = trolleybuses.Count(t => t.Colour == colour);

            Console.WriteLine($"\n7)Кількість тролейбусів з кольором {colour}: {result}");
        }

        /// <summary>
        /// 8) Виведення даних про найтриваліший маршрут
        /// </summary>
        /// <param name="routes"></param>
        public static void GetLongestRoute(List<Route> routes) {

            var result = routes.Where(r => r.JourneyTime.Equals(routes.Max(r => r.JourneyTime)));
            Console.WriteLine("\n8)Виведення даних про найтриваліший маршрут:");
            foreach (var route in result) {
                Console.WriteLine(route);
            }
        }

        /// <summary>
        /// 9) Групування пасажирів по номеру тролейбуса
        /// </summary>
        /// <param name="passangers"></param>
        public static void GetGroupPassangerByTrNum(List<Passanger> passangers) {

            var result = from passanger in passangers
                         group passanger by passanger.NumOfTrolleybus;

            Console.WriteLine("\n9)Групування пасажирів по номеру тролейбуса:\n");
            foreach (var temp in result) {
                Console.WriteLine($"Номер тролейбусу: {temp.Key}\nПасажири:");
                foreach(var passanger in temp) {
                    Console.WriteLine(passanger.FullName);
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// 10) Виведення даних про зупинки без врахування заданої к-сті зупинок з кінця
        /// </summary>
        /// <param name="trolleybusStops"></param>
        /// <param name="num"></param>
        public static void GetStopsWithoutLastNums(List<TrolleybusStop> trolleybusStops, int num) {

            var result = trolleybusStops.SkipLast(num);
            Console.WriteLine($"\n10)Виведення даних про зупинки без врахування {num} зупинок з кінця:");
            foreach (var stop in result) {
                Console.WriteLine(stop);
            }
        }

        /// <summary>
        /// 11) Виведення першого в списку тролейбусу з інвентарним номером, який >= сумі номерів тролейбусів
        /// </summary>
        /// <param name="trolleybuses"></param>
        public static void Task11(List<Trolleybus> trolleybuses) {
            var result = (from t in trolleybuses select t).First(t => t.InventoryNumber >= trolleybuses.Sum(t => t.Number));

            Console.WriteLine($"\n11)Виведення першого в списку тролейбусу з інвентарним номером, який >= сумі номерів тролейбусів:\n{result}");
        }

        /// <summary>
        /// 12)Декартовий добуток пасажирів та маршрутів
        /// </summary>
        /// <param name="passangers"></param>
        /// <param name="routes"></param>
        public static void Task12(List<Passanger> passangers, List<Route> routes) {

            var result = from p in passangers
                         from r in routes
                         select new { PassangerName = p.FullName, RouteName = r.Name };
            Console.WriteLine("\n12)Декартовий добуток пасажирів та маршрутів:");
            foreach (var r in result) {
                Console.WriteLine($"{r.PassangerName}   {r.RouteName}\n");
            }
        }

        /// <summary>
        /// 13) Виведення ПІБ пасажирів зі списку
        /// </summary>
        /// <param name="passangers"></param>
        public static void Task13(List<Passanger> passangers) {

            var result = from p in passangers
                         select p.FullName;

            Console.WriteLine("\n13)Виведення ПІБ пасажирів зі списку: ");
            foreach (var r in result) {
                Console.WriteLine(r);
            }
            Console.WriteLine();
        }

        /// <summary>
        /// 14) Перевірка чи є хтось з пасажирів хто прямумав до сільпо
        /// </summary>
        /// <param name="passangers"></param>
        public static void Task14(List<Passanger> passangers) {

            var result = passangers.Any(p => p.LastStop.Name == "Сільпо");
            Console.WriteLine(@"14)Чи є хтось з пасажирів хто прямував до Сільпо? : {0}", (result ? "Так" : "Ні"));
        }

        /// <summary>
        /// 15) Перевірка чи є задана зупинка в списку зупинок
        /// </summary>
        /// <param name="trolleybusStops"></param>
        /// <param name="troleybusStopName"></param>
        public static void Task15(List<TrolleybusStop> trolleybusStops, string troleybusStopName) {
            var result = (from t in trolleybusStops select t.Name).Contains(troleybusStopName);
            Console.WriteLine(@"15)Чи є зупинка {0} в списку зупинок? : {1}", troleybusStopName, (result ? "Так" : "Ні"));
            Console.WriteLine();
        }
        
        /// <summary>
        /// 16) Виведення пасажирів к-сть букв в ПІБ яких є >= мінімальної к-сті пасажирських місць із списку тролейбусів
        /// </summary>
        /// <param name="passangers"></param>
        /// <param name="trolleybuses"></param>
        public static void Task16(List<Passanger> passangers, List<Trolleybus> trolleybuses) {

            var result = passangers.Where(p => p.FullName.Length >= trolleybuses.Min(t => t.PassengerSeats));
            Console.WriteLine("\n16)Виведення пасажирів к-сть букв в ПІБ яких є >= мінімальної к-сті пасажирських місць із списку тролейбусів:");
            foreach(var r in result) {
                Console.WriteLine(r);
            }
        }

        /// <summary>
        /// 17) Виведення пасажирів відсортованих по тривалості маршруту, яким вони рухалися у порядку зростання
        /// </summary>
        /// <param name="passangers"></param>
        /// <param name="routes"></param>
        public static void Task17(List<Passanger> passangers, List<Route> routes) {

            var result = passangers.Join(routes, p => p.NumOfTrolleybus, r => r.RouteNumber,
                        (p, r) => new { PassangerFullName = p.FullName, RouteDuration = r.JourneyTime }).OrderBy(t => t.RouteDuration);
            Console.WriteLine("\n17)Виведення пасажирів відсортованих по тривалості маршруту, яким вони рухалися у порядку зростання:");
            foreach(var r in result) { 
                Console.WriteLine($"Пасажир: {r.PassangerFullName}; Тривалість маршруту: {r.RouteDuration.Value.Hour}год. {r.RouteDuration.Value.Minute}хв.");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// 18) Перевірка чи всі маршрути мають тривалість >= заданої кількості хвилин
        /// </summary>
        /// <param name="routes"></param>
        /// <param name="minutes"></param>
        public static void Task18(List<Route> routes, int minutes) {

            DateTime dateTime = new DateTime();
            dateTime = dateTime.AddHours((double)minutes / 60);
            dateTime = dateTime.AddMinutes((double)minutes % 60);

            var result = routes.All(r => r.JourneyTime >= dateTime);
            Console.WriteLine(@"18)Чи у всіх маршрутів тривалість >= {0}хв.? : {1}", minutes, (result ? "Так" : "Ні"));
        }

        /// <summary>
        /// 19) Виведення тролейбусів які закріплені за маршрутами
        /// </summary>
        /// <param name="trolleybus"></param>
        /// <param name="routes"></param>
        public static void Task19(List<Trolleybus> trolleybus, List<Route> routes) {

            var result = trolleybus.Join(routes, t => t.Number, r => r.RouteNumber,
                (t, r) => new {RoutName = r.Name, TrolleybusNumber = t.Number, PassangerSits = t.PassengerSeats, Type = t.Type, Colour = t.Colour});

            Console.WriteLine("\n19)Виведення тролейбусів які закріплені за маршрутом:");
            foreach(var r in result) {
                Console.WriteLine($"Назва маршруту: {r.RoutName};  Номер тролейбусу: {r.TrolleybusNumber};  К-сть пасажирських місць : {r.PassangerSits}\n" +
                    $"Тип: {r.Type};  Колір: {r.Colour}\n");
            }
        }

        /// <summary>
        /// 20) Виведення пасажирів чий ПІБ закінчується на задану букву 
        /// </summary>
        /// <param name="passangers"></param>
        /// <param name="symbol"></param>
        public static void Task20(List<Passanger> passangers, char symbol) {

            var result = passangers.Where(p => p.FullName[^1].Equals(symbol));

            Console.WriteLine("\n20)Виведення пасажирів чий ПІБ закінчується на задану букву:");
            foreach(var r in result) {
                Console.WriteLine(r);
            }
        }


    }
}