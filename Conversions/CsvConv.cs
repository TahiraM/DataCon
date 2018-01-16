using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;

namespace Conversions
{
    class CsvConv
    {
        public static DataTable ReadFile()
        {
            DataTable dtCsv = new DataTable();
            string Fulltext;
            using(StreamReader sr = new StreamReader("Deal.csv"))
            {
                while (!sr.EndOfStream)
                {
            Fulltext = sr.ReadToEnd().ToString(); //read full file text
                    string[] rows = Fulltext.Split('\n'); //split full file text into rows
                    
                    for (int i = 0; i < rows.Count() - 1; i++)
                    {
                        string[] rowValues = rows[i].Split('|'); //split each row with comma to get individual values  
                        {
                            if (i == 0)
                            {
                                for (int j = 0; j < rowValues.Count(); j++)
                                {
                                    dtCsv.Columns.Add(rowValues[j]); //add headers
                                }
                            }
                            else
                            {
                                DataRow dr = dtCsv.NewRow();
                                for (int k = 0; k < rowValues.Count(); k++)
                                {
                                    dr[k] = rowValues[k].ToString();
                                }
                                dtCsv.Rows.Add(dr);
                            }
                        }
                    }
                }
            }
            foreach (DataRow row in dtCsv.Rows)
            {
                Console.WriteLine();
                for(int x = 0; x < dtCsv.Columns.Count; x++)
                {
                    Console.Write(row[x].ToString() + " ");
                }
            }

             return dtCsv;
        }
    }
}