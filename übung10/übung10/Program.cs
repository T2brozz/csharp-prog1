using System;
using System.Diagnostics;

namespace übung10
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = args[0];
            Process cmd = new Process();
            cmd.StartInfo.FileName = "sh";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            cmd.StandardInput.WriteLine("wc "+filename);
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            Console.WriteLine(cmd.StandardOutput.ReadToEnd());
            
        }

        static bool teilmenge(int[] a, int[] b)
        {
            bool[] bInA = new bool[b.Length];

            if (b.Length <= a.Length)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    for (int j = 0; j < b.Length; j++)
                    {
                        if (!bInA[j])
                        {
                            if (b[j] == a[i])
                            {
                                bInA[j] = true;
                            }
                        }
                    }
                }

                for (int i = 0; i < bInA.Length; i++)
                {
                    if (bInA[i] == false)
                    {
                        return false;
                    }
                }

                return true;
            }

            return false;
        }

      

        static void Zerlege1(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                int summe = 0;
                int ende = 0; 
                for (int j = i; summe < n; j++)
                {
                    summe += j;
                    ende = j; 
                }

                if (summe == n)
                {
                    for (int k = i; k <= ende; k++)
                    {
                        Console.Write($"{k},");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}