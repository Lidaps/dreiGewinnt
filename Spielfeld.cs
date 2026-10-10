namespace DreiGewinnt
{
    class Spielfeld
    {
        public static string a = "X";
        public static string b = "X";
        public static string c = "X";
        public static string d = "O";
        public static string e = "O";
        public static string f = "O";
        public static string g = " ";
        public static string h = " ";
        public static string i = " ";
        public static string[] symbole = { " ", " ", " ", " ", " ", " ", " ", " ", " " };

        public static void Anzeigen()
        {
            Console.WriteLine("1    |2    |3    ");
            Console.WriteLine($"  {symbole[0]}  |  {symbole[1]}  |  {symbole[2]}  ");
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("4    |5    |6    ");
            Console.WriteLine($"  {symbole[3]}  |  {symbole[4]}  |  {symbole[5]}  ");
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("7    |8    |9    ");
            Console.WriteLine($"  {symbole[6]}  |  {symbole[7]}  |  {symbole[8]}  ");
            Console.WriteLine("     |     |     ");
        }
    }
}
