namespace DreiGewinnt
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool isRunning = true;
            int counter = 1;
            string player = "fehler 404";

            while (isRunning)
            {
                if (counter % 2 == 0)
                {
                    player = "Spieler Zwei ist am Start";
                }
                else
                {
                    player = "Spieler Eins ist jetzt dran";
                }

                Console.Clear();
                Console.WriteLine("Drei Gewinnt drücke eine Taste von 1-9 um zu spielen");
                Console.WriteLine(player + " " + "Runde " + counter);
                Spielfeld.Anzeigen();

                ConsoleKey taste = Console.ReadKey(true).Key;
                if (taste == ConsoleKey.Q)
                {
                    isRunning = false;
                }

                // Eingabe der Spieler
                // Spieler 1
                if (
                    taste == ConsoleKey.D1
                    && counter % 2 != 0
                    && Spielfeld.symbole[0] != "X"
                    && Spielfeld.symbole[0] != "O"
                )
                {
                    Spielfeld.symbole[0] = "O";
                }
                if (
                    taste == ConsoleKey.D2
                    && counter % 2 != 0
                    && Spielfeld.symbole[1] != "X"
                    && Spielfeld.symbole[1] != "O"
                )
                {
                    Spielfeld.symbole[1] = "O";
                }
                if (
                    taste == ConsoleKey.D3
                    && counter % 2 != 0
                    && Spielfeld.symbole[2] != "X"
                    && Spielfeld.symbole[2] != "O"
                )
                {
                    Spielfeld.symbole[2] = "O";
                }
                if (
                    taste == ConsoleKey.D4
                    && counter % 2 != 0
                    && Spielfeld.symbole[3] != "X"
                    && Spielfeld.symbole[3] != "O"
                )
                {
                    Spielfeld.symbole[3] = "O";
                }
                if (
                    taste == ConsoleKey.D5
                    && counter % 2 != 0
                    && Spielfeld.symbole[4] != "X"
                    && Spielfeld.symbole[4] != "O"
                )
                {
                    Spielfeld.symbole[4] = "O";
                }
                if (
                    taste == ConsoleKey.D6
                    && counter % 2 != 0
                    && Spielfeld.symbole[5] != "X"
                    && Spielfeld.symbole[5] != "O"
                )
                {
                    Spielfeld.symbole[5] = "O";
                }
                if (
                    taste == ConsoleKey.D7
                    && counter % 2 != 0
                    && Spielfeld.symbole[6] != "X"
                    && Spielfeld.symbole[6] != "O"
                )
                {
                    Spielfeld.symbole[6] = "O";
                }
                if (
                    taste == ConsoleKey.D8
                    && counter % 2 != 0
                    && Spielfeld.symbole[7] != "X"
                    && Spielfeld.symbole[7] != "O"
                )
                {
                    Spielfeld.symbole[7] = "O";
                }
                if (
                    taste == ConsoleKey.D9
                    && counter % 2 != 0
                    && Spielfeld.symbole[8] != "X"
                    && Spielfeld.symbole[8] != "O"
                )
                {
                    Spielfeld.symbole[8] = "O";
                }
                //Spieler 2
                //
                //
                if (
                    taste == ConsoleKey.D1
                    && counter % 2 == 0
                    && Spielfeld.symbole[0] != "O"
                    && Spielfeld.symbole[0] != "X"
                )
                {
                    Spielfeld.symbole[0] = "X";
                }
                if (
                    taste == ConsoleKey.D2
                    && counter % 2 == 0
                    && Spielfeld.symbole[1] != "O"
                    && Spielfeld.symbole[1] != "X"
                )
                {
                    Spielfeld.symbole[1] = "X";
                }
                if (
                    taste == ConsoleKey.D3
                    && counter % 2 == 0
                    && Spielfeld.symbole[2] != "O"
                    && Spielfeld.symbole[2] != "X"
                )
                {
                    Spielfeld.symbole[2] = "X";
                }
                if (
                    taste == ConsoleKey.D4
                    && counter % 2 == 0
                    && Spielfeld.symbole[3] != "O"
                    && Spielfeld.symbole[3] != "X"
                )
                {
                    Spielfeld.symbole[3] = "X";
                }
                if (
                    taste == ConsoleKey.D5
                    && counter % 2 == 0
                    && Spielfeld.symbole[4] != "O"
                    && Spielfeld.symbole[4] != "X"
                )
                {
                    Spielfeld.symbole[4] = "X";
                }
                if (
                    taste == ConsoleKey.D6
                    && counter % 2 == 0
                    && Spielfeld.symbole[5] != "O"
                    && Spielfeld.symbole[5] != "X"
                )
                {
                    Spielfeld.symbole[5] = "X";
                }
                if (
                    taste == ConsoleKey.D7
                    && counter % 2 == 0
                    && Spielfeld.symbole[6] != "O"
                    && Spielfeld.symbole[6] != "X"
                )
                {
                    Spielfeld.symbole[6] = "X";
                }
                if (
                    taste == ConsoleKey.D8
                    && counter % 2 == 0
                    && Spielfeld.symbole[7] != "O"
                    && Spielfeld.symbole[7] != "X"
                )
                {
                    Spielfeld.symbole[7] = "X";
                }
                if (
                    taste == ConsoleKey.D9
                    && counter % 2 == 0
                    && Spielfeld.symbole[8] != "O"
                    && Spielfeld.symbole[8] != "X"
                )
                {
                    Spielfeld.symbole[8] = "X";
                }

                // Auswertung!
                //
                //
                if (
                    Spielfeld.symbole[0] == "X"
                        && Spielfeld.symbole[1] == "X"
                        && Spielfeld.symbole[2] == "X"
                    || Spielfeld.symbole[3] == "X"
                        && Spielfeld.symbole[4] == "X"
                        && Spielfeld.symbole[5] == "X"
                    || Spielfeld.symbole[6] == "X"
                        && Spielfeld.symbole[7] == "X"
                        && Spielfeld.symbole[8] == "X"
                    || Spielfeld.symbole[0] == "X"
                        && Spielfeld.symbole[3] == "X"
                        && Spielfeld.symbole[6] == "X"
                    || Spielfeld.symbole[1] == "X"
                        && Spielfeld.symbole[4] == "X"
                        && Spielfeld.symbole[7] == "X"
                    || Spielfeld.symbole[2] == "X"
                        && Spielfeld.symbole[5] == "X"
                        && Spielfeld.symbole[8] == "X"
                    || Spielfeld.symbole[0] == "X"
                        && Spielfeld.symbole[4] == "X"
                        && Spielfeld.symbole[8] == "X"
                    || Spielfeld.symbole[2] == "X"
                        && Spielfeld.symbole[4] == "X"
                        && Spielfeld.symbole[6] == "X"
                )
                {
                    isRunning = false;
                    Console.Clear();
                    Console.WriteLine("jewonnen!");
                    Console.WriteLine("jewonnen!");
                    Console.WriteLine("jewonnen!");
                    Console.WriteLine("jewonnen!");
                    Console.WriteLine("jewonnen!");
                }
                if (
                    Spielfeld.symbole[0] == "O"
                        && Spielfeld.symbole[1] == "O"
                        && Spielfeld.symbole[2] == "O"
                    || Spielfeld.symbole[3] == "O"
                        && Spielfeld.symbole[4] == "O"
                        && Spielfeld.symbole[5] == "O"
                    || Spielfeld.symbole[6] == "O"
                        && Spielfeld.symbole[7] == "O"
                        && Spielfeld.symbole[8] == "O"
                    || Spielfeld.symbole[0] == "O"
                        && Spielfeld.symbole[3] == "O"
                        && Spielfeld.symbole[6] == "O"
                    || Spielfeld.symbole[1] == "O"
                        && Spielfeld.symbole[4] == "O"
                        && Spielfeld.symbole[7] == "O"
                    || Spielfeld.symbole[2] == "O"
                        && Spielfeld.symbole[5] == "O"
                        && Spielfeld.symbole[8] == "O"
                    || Spielfeld.symbole[0] == "O"
                        && Spielfeld.symbole[4] == "O"
                        && Spielfeld.symbole[8] == "O"
                    || Spielfeld.symbole[2] == "O"
                        && Spielfeld.symbole[4] == "O"
                        && Spielfeld.symbole[6] == "O"
                )
                {
                    isRunning = false;
                    Console.Clear();
                    Console.WriteLine("jewonnen!");
                    Console.WriteLine("jewonnen!");
                    Console.WriteLine("jewonnen!");
                    Console.WriteLine("jewonnen!");
                    Console.WriteLine("jewonnen!");
                }
                counter++;
            }
        }
    }
}
