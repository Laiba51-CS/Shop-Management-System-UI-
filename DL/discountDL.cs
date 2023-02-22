using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Shop_management_system.Resources.BL;


namespace Shop_management_system.DL
{
    class discountDL
    {
        public static List<Discount> discounts = new List<Discount>();
        public static void add(Discount d)
        {
            discounts.Add(d);
        }

        public static Discount activeDiscount()
        {
            if (discounts.Count != 0)
            {
                foreach (Discount d in discounts)
                {
                    if (d.Flag == true)
                    {
                        return d;
                    }
                }
                return discounts[0];
            }
            return null;
        }

        public static void readData(string path)
        {
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    string[] splittedRecord = line.Split(',');

                    int price = int.Parse(splittedRecord[0]);
                    int dis = int.Parse(splittedRecord[1]);
                    bool flag = bool.Parse(splittedRecord[2]);

                    Discount discount = new Discount(price, dis, flag);

                    discounts.Add(discount);
                }

                file.Close();
            }
        }

        public static void storeData(string path)
        {
            StreamWriter file = new StreamWriter(path);

            foreach (Discount d in discounts)
            {
                file.WriteLine(d.Price + "," + d.Dis + "," + d.Flag);
            }

            file.Flush();
            file.Close();
        }
    }
}

