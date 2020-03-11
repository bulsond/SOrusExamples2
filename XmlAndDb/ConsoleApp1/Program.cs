using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            const string file = @"D:\docs.xml";
            const string fileNew = @"D:\docsNew.xml";
            var xmlDoctors = new XmlDoctorsService();
            var dbDoctors = new DbDoctorsService();

            //List<Doctor> doctors = dbDoctors.GetDoctors();

            //List<Doctor> docs = xmlDoctors.GetDoctors(file);
            //xmlDoctors.SaveDoctors(fileNew, doctors);

            var docs1 = xmlDoctors.GetDoctors(fileNew);

            Console.ReadLine();
        }
    }
}
