using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Shop_management_system.Resources.BL;

namespace Shop_management_system.DL
{
    class soldtypeDL
    {
        public static List<soldtype> solditmes = new List<soldtype>();


        public static void addIntoList(soldtype soldItem)
        {
            solditmes.Add(soldItem);
        }

        public static soldtype isProductExist(string productName)
        {
            if (solditmes != null)
            {
                foreach (soldtype item in solditmes)
                {
                    if (item.ProductName == productName)
                    {
                        return item;
                    }
                }
            }
            return null;
        }
        public static string displayprofit(List<soldtype> sold)
        {

            int total_items = 0;
            int total_price = 0;

            foreach (soldtype s in sold)
            {
                Console.WriteLine(" " + s.ProductName + "\t" + s.Quantity + "\t" + s.Price );

                total_items = total_items + s.Quantity;
                total_price = total_price + s.Price;
            }
            string a = total_items.ToString() + total_price.ToString() +( total_price * 0.2).ToString();

            return a;
        }

        public static void readData(string path)
        {
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string line;
                while ((line = file.ReadLine()) != null && line != "")
                {
                    string[] splittedRecord = line.Split(',');

                    string name = splittedRecord[0];
                    int quantity = int.Parse(splittedRecord[1]);
                    int price = int.Parse(splittedRecord[2]);

                    soldtype sold = new soldtype(name, quantity, price);

                    solditmes.Add(sold);
                }
                file.Close();
            }
        }

        public static void storeData(string path)
        {
            StreamWriter file = new StreamWriter(path);

            foreach (soldtype item in solditmes)
            {
                file.WriteLine(item.ProductName + "," + item.Quantity + "," + item.Price);
            }

            file.Flush();
            file.Close();
        }
    }
}
