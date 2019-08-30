using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace dist
{
    class Program
    {        
        static void Main(string[] args)
        {
            Dictionary<int, bool> hashes = new Dictionary<int, bool>();

            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            {
                while(!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    int hash = line.GetHashCode();

                    if (!hashes.ContainsKey(hash))
                    {
                        hashes.Add(hash, true);
                        Console.WriteLine(line);                        
                    }
                }
            }
        }
    }
}
