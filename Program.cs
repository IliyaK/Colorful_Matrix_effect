using System;

namespace Matrix{
    class Draw{
        public void MainColor(int colorType){
            switch (colorType){
                case 0:
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case 1:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case 6:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case 7:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case 8:
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    break;
                case 9:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                case 10:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                case 11:
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    break;
                case 12:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
                case 13:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;
                case 14:
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    break;
            }
        }//End MainColor

        public void BackGroundDraw(int numberOfCharacters){

            Random rnd = new Random();

            string chars = "!@#$%^&*<>?\"|\'abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ12345678";

            char blank = ' ';

            int[] numberOfChars = new int[numberOfCharacters];

            int width = Convert.ToInt32(Console.WindowWidth);

            for (int i = 0; i < numberOfCharacters; i++){

                numberOfChars[i] = rnd.Next(0, width);
                
            }

            int colorType = -1;            

            Array.Sort(numberOfChars, (x, y) => y.CompareTo(x));

            for (int i = 0; i < numberOfChars.Length; i++){

                for (int j = 0; j <= numberOfChars[i]; j++){

                    if (j == numberOfChars[i]){

                        colorType = rnd.Next(0, 14);
                        MainColor(colorType);
                        Console.Write("{0}", chars[rnd.Next(0, chars.Length)]);
                    }

                    else{

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(blank);
                    }
                }
            }
        }//End BackGroundDraw
    }//End Draw

    class Program{
        static void Main(string[] args){
            Draw drw = new Draw();

            int numberOfLetters = -1;
            int fallSpeed = 50;

            Console.WriteLine("Number should be between 2 and 13");
            Console.Write("How many letters per line do you want ? : ");                     

            do{

                numberOfLetters = Convert.ToInt32(Console.ReadLine());
            } while ((numberOfLetters <= 1) || (numberOfLetters > 13));

            while (true){

                drw.BackGroundDraw(numberOfLetters);
                System.Threading.Thread.Sleep(fallSpeed);
            }
        }//End Main
    }//End Program
}//End namespace
