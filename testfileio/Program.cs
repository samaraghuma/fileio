using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testfileio
{
    class Program
    {
        static void Main(string[] args)
        {
            List<employee> employeelist = Readfile();
            foreach (employee emp in employeelist)

            {
                Console.WriteLine(emp.Name + "=  " + emp.Salary);
                // Console.WriteLine($"name:{emp.Name},salary:{emp.Salary}");
                // Console.WriteLine("name:{ 0},salary: { 1}"),emp.Name,emp.Salary);


            }
            writetodatafile("q","10000");
        }

        private static void writetodatafile(string name,string salary)
        {
            StreamWriter sw = new StreamWriter("../../datafile.txt", true);
            sw.Write(($"\n{name},{salary}"));
            sw.Close();
        }

        private static List<employee> Readfile()
        {
            List<employee> employeelist = new List<employee>();
            string filelocation = "../../datafile.txt";
            StreamReader reader = new StreamReader(filelocation);
            string data = (reader.ReadToEnd().Trim());
            string[] records = data.Split('\n');
            foreach (string record in records)
            {
                string[] rc = record.Split(',');
                employeelist.Add(new employee(rc[0], float.Parse(rc[1])));
            }
            reader.Close();
            return employeelist;
        }
    }
}
