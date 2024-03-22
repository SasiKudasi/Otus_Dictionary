namespace Otus_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OtusDictionary dictionary = new OtusDictionary();
            string value = Console.ReadLine();
            var key = 0;
            var key2 = int.TryParse(Console.ReadLine(), out key);
            dictionary.Add(key, value);
            value = Console.ReadLine();
            key2 = int.TryParse(Console.ReadLine(), out key);
            dictionary.Add(key, value);
            value = Console.ReadLine();
            key2 = int.TryParse(Console.ReadLine(), out key);
            dictionary.Add(key, value);
            Console.WriteLine(dictionary.GetValue(key)); 
        }
    }
}