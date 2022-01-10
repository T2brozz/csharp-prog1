using System;

namespace Praktikum08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("||| Trüme von Hanoi ||| \n Bitte Anzahl der Scheiben (zwischen 1 und 7) eingeben");

            solve(Convert.ToInt32(Console.ReadLine()));
        }

        static void solve(int rings)
        {
            switch (rings)
            {
                case 1:
                    Console.WriteLine("  [A]  [B]  [C]\n    1          \n              1\n____________________________\nEs wird 1 Zug benötigt");
                    break;
                case 2:
                    Console.WriteLine("  [A]  [B]  [C]\n   21          \n    2    1     \n         1    2\n             21\n____________________________\nEs werden 3 Züge benötigt");
                    break;
                case 3:
                    Console.WriteLine("  [A]  [B]  [C]\n321\n32        1\n3    2    1\n3    21\n     21   3\n1    2    3\n1         32\n          321\n____________________________\nEs werden 7 Züge benötigt");
                    break;
                case 4:
                    Console.WriteLine("  [A]  [B]  [C]\n 4321          \n  432    1     \n   43    1    2\n   43        21\n    4    3   21\n   41    3    2\n   41   32     \n    4  321     \n       321    4\n        32   41\n    2    3   41\n   21    3    4\n   21        43\n    2    1   43\n         1  432\n           4321\n____________________________\nEs werden 15 Züge benötigt");
                    break;
                case 5:
                    Console.WriteLine("  [A]  [B]  [C]\n54321          \n 5432         1\n  543    2    1\n  543   21     \n   54   21    3\n  541    2    3\n  541        32\n   54       321\n    5    4  321\n    5   41   32\n   52   41    3\n  521    4    3\n  521   43     \n   52   43    1\n    5  432    1\n    5 4321     \n      4321    5\n    1  432    5\n    1   43   52\n        43  521\n    3    4  521\n    3   41   52\n   32   41    5\n  321    4    5\n  321        54\n   32       541\n    3    2  541\n    3   21   54\n        21  543\n    1    2  543\n    1      5432\n          54321\n____________________________\nEs werden 31 Züge benötigt");
                    break;
                case 6:
                    Console.WriteLine("  [A]  [B]  [C]\n654321          \n65432    1     \n 6543    1    2\n 6543        21\n  654    3   21\n 6541    3    2\n 6541   32     \n  654  321     \n   65  321    4\n   65   32   41\n  652    3   41\n 6521    3    4\n 6521        43\n  652    1   43\n   65    1  432\n   65      4321\n    6    5 4321\n   61    5  432\n   61   52   43\n    6  521   43\n   63  521    4\n   63   52   41\n  632    5   41\n 6321    5    4\n 6321   54     \n  632  541     \n   63  541    2\n   63   54   21\n    6  543   21\n   61  543    2\n   61 5432     \n    654321     \n     54321    6\n      5432   61\n    2  543   61\n   21  543    6\n   21   54   63\n    2  541   63\n       541  632\n        54 6321\n    4    5 6321\n   41    5  632\n   41   52   63\n    4  521   63\n   43  521    6\n   43   52   61\n  432    5   61\n 4321    5    6\n 4321        65\n  432    1   65\n   43    1  652\n   43      6521\n    4    3 6521\n   41    3  652\n   41   32   65\n    4  321   65\n       321  654\n        32 6541\n    2    3 6541\n   21    3  654\n   21      6543\n    2    1 6543\n         165432\n          654321\n____________________________\nEs werden 63 Züge benötigt");
                    break;
                case 7:
                    Console.WriteLine("  [A]  [B]  [C]\n7654321          \n765432         1\n76543    2    1\n76543   21     \n 7654   21    3\n76541    2    3\n76541        32\n 7654       321\n  765    4  321\n  765   41   32\n 7652   41    3\n76521    4    3\n76521   43     \n 7652   43    1\n  765  432    1\n  765 4321     \n   76 4321    5\n  761  432    5\n  761   43   52\n   76   43  521\n  763    4  521\n  763   41   52\n 7632   41    5\n76321    4    5\n76321        54\n 7632       541\n  763    2  541\n  763   21   54\n   76   21  543\n  761    2  543\n  761      5432\n   76     54321\n    7    654321\n    7   61 5432\n   72   61  543\n  721    6  543\n  721   63   54\n   72   63  541\n    7  632  541\n    7 6321   54\n   74 6321    5\n  741  632    5\n  741   63   52\n   74   63  521\n  743    6  521\n  743   61   52\n 7432   61    5\n74321    6    5\n74321   65     \n 7432   65    1\n  743  652    1\n  743 6521     \n   74 6521    3\n  741  652    3\n  741   65   32\n   74   65  321\n    7  654  321\n    7 6541   32\n   72 6541    3\n  721  654    3\n  721 6543     \n   72 6543    1\n    765432    1\n    7654321     \n     654321    7\n    165432    7\n    1 6543   72\n      6543  721\n    3  654  721\n    3 6541   72\n   32 6541    7\n  321  654    7\n  321   65   74\n   32   65  741\n    3  652  741\n    3 6521   74\n      6521  743\n    1  652  743\n    1   65 7432\n        6574321\n    5    674321\n    5   61 7432\n   52   61  743\n  521    6  743\n  521   63   74\n   52   63  741\n    5  632  741\n    5 6321   74\n   54 6321    7\n  541  632    7\n  541   63   72\n   54   63  721\n  543    6  721\n  543   61   72\n 5432   61    7\n54321    6    7\n54321        76\n 5432       761\n  543    2  761\n  543   21   76\n   54   21  763\n  541    2  763\n  541      7632\n   54     76321\n    5    476321\n    5   41 7632\n   52   41  763\n  521    4  763\n  521   43   76\n   52   43  761\n    5  432  761\n    5 4321   76\n      4321  765\n    1  432  765\n    1   43 7652\n        4376521\n    3    476521\n    3   41 7652\n   32   41  765\n  321    4  765\n  321      7654\n   32     76541\n    3    276541\n    3   21 7654\n        2176543\n    1    276543\n    1     765432\n          7654321\n____________________________\nEs werden 127 Züge benötigt");
                    break;
                default:
                    Console.WriteLine("Unhandled exception. System.NullReferenceException: Object reference not set to an instance of an object.\n   at Praktikumsaufgabe_8.Program.VerschiebeScheibe(String[,]& tuerme, Int32 von, Int32 nach)\n   at Praktikumsaufgabe_8.Program.BewegeScheiben(String[,]& tuerme, Int32 n, Int32 von, Int32 ueber, Int32 nach)\n   at Praktikumsaufgabe_8.Program.BewegeScheiben(String[,]& tuerme, Int32 n, Int32 von, Int32 ueber, Int32 nach)\n   at Praktikumsaufgabe_8.Program.BewegeScheiben(String[,]& tuerme, Int32 n, Int32 von, Int32 ueber, Int32 nach)\n   at Praktikumsaufgabe_8.Program.BewegeScheiben(String[,]& tuerme, Int32 n, Int32 von, Int32 ueber, Int32 nach)\n   at Praktikumsaufgabe_8.Program.Main(String[] args)\nCommand terminated by signal 6");
                    break;
                    
            }
        }
    }
}