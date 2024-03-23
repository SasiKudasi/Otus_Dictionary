namespace Otus_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OtusDictionary dictionary = new OtusDictionary();
           
            var key = 0;
            Console.WriteLine("Введите ключ");
            var key2 = int.TryParse(Console.ReadLine(), out key);
            Console.WriteLine("Введите значение");
            string value = Console.ReadLine();
            dictionary.Add(key, value);            
            Console.WriteLine("Введите ключ");
            key2 = int.TryParse(Console.ReadLine(), out key);
            Console.WriteLine("Введите значение");
            value = Console.ReadLine();
            dictionary.Add(key, value);
            Console.WriteLine("Введите ключ");
            key2 = int.TryParse(Console.ReadLine(), out key);
            Console.WriteLine("Введите значение");
            value = Console.ReadLine();
            dictionary.Add(key, value);
            Console.WriteLine($"Значение по ключу {key} = {dictionary.GetValue(key)}"); 
        }
    }
}