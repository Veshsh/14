using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace _14Budget_accounting
{
    class Data
    {
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public uint Mony { get; set; }
        public bool Pluss { get; set; }
        public string Typ { get; set; }
        public Data(DateTime date, string name, uint mony, bool pluss, string typ)
        {
            Date = date;
            Name = name;
            Mony = mony;
            Pluss = pluss;
            Typ = typ;
        }
    }
    internal class Ster
    {
        public static List<Data> data = new List<Data>();
        public static HashSet<string> type = new HashSet<string>();
        public const string Sterfile = "\\source\\repos\\14Budget_accounting\\Sterfile.json";
        public const string SterfileType = "\\source\\repos\\14Budget_accounting\\Type.json";
        public static void ster<T>(T listdata, string paff)
        {
            string paf = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string json = JsonConvert.SerializeObject(listdata);
            File.WriteAllText(paf + paff, json);
        }
        public static T dester<T>(string paff)
        {
            string paf = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string jsontext = File.ReadAllText(paf + paff);
            T list = JsonConvert.DeserializeObject<T>(jsontext);
            return list;
        }
    }
}

