using System.Text;

/*
 * Необхідно реалізувати додаток, що дозволяє виконувати шифрування та 
дешифрування тексту кількома простими шифрами з ключами. Повинно 
бути реалізовано не менше двох шифрів (можна обмежитися латинським 
алфавітом)
*/

namespace Lab3 {
    internal class Program {

        public static void Main(string[] args) {

            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.WriteLine("Введіть цифру шифру з яким хочете працювати:\n1. Шифр Цезаря\n2. Шифр Віженера");
            Cipher? cipher = Console.ReadLine() switch {
                "1" => CipherFactory.CreateCipher(CipherType.Cesar),
                "2" => CipherFactory.CreateCipher(CipherType.Vigenere),
                _ => throw new ArgumentException("Invalid type"),
            };
            Console.WriteLine("\nВведіть цифру бажаної дії:\n1. Шифрування тексту\n2. Дешифрування тексту");

            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nВведіть текст з використанням латинського алфавіту великими літерами: ");
            string text = Console.ReadLine();
            Console.Write("Введіть ключ(цифра, якщо шифр Цезаря або слово на латиниці великими літерами якщо шифр Віженера): ");
            string key = Console.ReadLine();
            switch(num) {
                case 1:
                    Console.WriteLine("Зашифроване повідомлення: " + cipher.Encrypt(text, key));
                    break;
                case 2:
                    Console.WriteLine("Розшифроване повідомлення: " + cipher.Decrypt(text, key));
                    break;
                default:
                    throw new ArgumentException("Invalid choice");
            }
        }
    }
}
