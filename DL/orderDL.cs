using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Shop_management_system.Resources.BL;

namespace Shop_management_system.DL
{
    class orderDL
    {
        public static List<order> orders = new List<order>();
        public static void addintolist(order o)
        {
            orders.Add(o);
        }
        public static void storedata(string path2)
        {
            StreamWriter newfile = new StreamWriter(path2);
            for (int i = 0; i < orders.Count; i++)
            {
                newfile.WriteLine(orders[i].ProductName + "," +orders[i].CustomerName+","+ orders[i].OrderQuantity  + "," + orders[i].Address + "," + orders[i].PhoneNo);
            }
            newfile.Flush();
            newfile.Close();

        }

        public static void storeObjectInFile(string path, order temp)
        {

            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(temp.ProductName + "," + temp.CustomerName + ","+ temp.OrderQuantity + "," + temp.Address + "," + temp.PhoneNo);
            file.Flush();
            file.Close();
        }

        public static void read_data(string path2)
        {
            string line;
            if (File.Exists(path2))
            {
                StreamReader file = new StreamReader(path2);
                while ((line = file.ReadLine()) != null && line != "")
                {
                    string[] splittedrecord = line.Split(',');
                    string name = splittedrecord[0];
                    string customername= splittedrecord[1];
                    int quantity = int.Parse(splittedrecord[2]);
                    string address = splittedrecord[3];
                    string phoneNo = splittedrecord[4];

                    order p = new order(name,customername, quantity, address, phoneNo);
                    orders.Add(p);
                }

                file.Close();
            }

        }
    }
}
