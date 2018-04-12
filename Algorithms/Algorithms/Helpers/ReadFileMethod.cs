using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Helpers
{
    public class ReadFileMethod
    {
        public static List<string> Read(string path)
        {
            List<string> list = new List<string>();

            using (StreamReader sr = File.OpenText(path))
            {

                string x = "";

                while ((x = sr.ReadLine()) != null)
                {
                    list.Add(x);
                }
            }

            return list;
        }
    }
}
