using System;
using Midterm;
namespace BookConsole
{
    class Program
    {
        private static string _func;
        private static string _title;
        private static string _last;
        static void Main()
        {
            string[] args = Environment.GetCommandLineArgs();
            AreArguementsValid(args);

            var book = new BookStoreFunctions();
            switch (_func)
            {
                case "title":
                    Console.WriteLine($"{_title} = {book.GetBookeByTitle(_title)}");
                    break;
            }
        }
        public static void AreArguementsValid(string[] args)
        {
            var a = args;
            Console.WriteLine(a.Length);
            _func = args[1].ToLower();
            //_title = args[1];
            //_last = args[2];
            
            if (_func == "title")
            {
                _title = args[2];
                Console.WriteLine("title valid");
            }
            
            if(_func == "last")
            {
                _last = args[2];
                Console.WriteLine("last valid");
            }
            Console.WriteLine("args are valid");
        }
    }
}
