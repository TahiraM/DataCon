using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Conversions
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*using( var reader = new StreamReader("Deal.csv"))
            {
                List<string> one = new List<string>();
                List<string> two = new List<string>();

            
            while(!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split('|');
                one.Add(values[0]);

                var linetwo = reader.ReadLine();
                var valtwo = linetwo.Split('|').Skip(1);
                two.Add(values[0]);

                Console.WriteLine(string.Join("\t", one.Cast<string>().ToArray()));
                Console.WriteLine(string.Join("\t", two.Cast<string>().ToArray()));
            }
            }*/
            CsvConv.ReadFile();

        }
    }
}
