using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab
{
    class Reader
    {
        private List<User> data;
        public Reader()
        {
            data = new List<User>();
        }
        public List<User> ReadTxt(string fileName)
        {
            var lines = File.ReadAllLines(fileName);
            ConvertToUsers(lines);
            return data;
        }

        private void ConvertToUsers(string[] lines)
        {
            for (int i = 0; i < lines.Length; i++)
            {
                var temp = lines[i].Split(' ');
                data.Add(new User { Date = temp[0], Name = temp[1], Money = Convert.ToInt32(temp[2]), Currency = temp[3] });
            }
        }
    }
}
