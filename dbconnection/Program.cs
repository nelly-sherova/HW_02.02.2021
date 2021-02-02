using System;

namespace dbconnection
{
    class Countries
    {
        public int Id;
        public string Country;
        public string Capital;
        public double Population_mln;
        public string National_Сurrency;
        public double Territory;
        public Countries(){}
        public Countries(int Id, string Country, string Capital, double Population_mln, string National_currency, double Territory)
        {
            this.Id = Id;
            this.Country = Country;
            this.Capital = Capital;
            this.Population_mln = Population_mln;
            this.National_Сurrency = National_currency;
            this.Territory = Territory;
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 83; i++)
                Console.Write("-");
            Console.WriteLine();

            Console.WriteLine("| Id  |Country       |Capital   |Population_mln |National_Сurrency|Territory      |");
            Countries cw = new Countries(1, "Таджикистан", "Душанбе", 9, "Сомони", 141400);
            Countries cw1 = new Countries(2, "Россия", "Москва", 1462, "Рубли", 17125191);

            for (int i = 1; i <= 83; i++)
                Console.Write("-");
            Console.WriteLine();
            Console.WriteLine("| " + cw.Id + "   |" + cw.Country + "   |" + cw.Capital + "   |" + cw.Population_mln + " млн          |" + cw.National_Сurrency + "           |" + cw.Territory + " км      |");

            for (int i = 1; i <= 83; i++)
                Console.Write("-");
            Console.WriteLine();
            Console.WriteLine("| " + cw1.Id + "   |" + cw1.Country + "        |" + cw1.Capital + "    |" + cw1.Population_mln + " млн       |" + cw1.National_Сurrency + "            |" + cw1.Territory + " км    |");
            for (int i = 1; i <= 83; i++)
                Console.Write("-");
        }
    }
}
