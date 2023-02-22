using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Shop_management_system.Resources.BL;

namespace Shop_management_system.DL
{
    class customerDL
    {

        public static List<Customer> CustomerList = new List<Customer>();

        public static Customer presentCustomer;
        public static void initializeCustomer(string name)
        {
            presentCustomer = new Customer(name);
            CustomerList.Add(presentCustomer);
        }


        public static void addIntoCustomerList(Customer c)
        {
            if (!isCustomerExists(c.CustomerName))
            {
                CustomerList.Add(c);
            }
        }

        public static bool isCustomerExists(string name)
        {
            if (CustomerList != null)
            {
                foreach (Customer customer in CustomerList)
                {
                    if (customer.CustomerName == name)
                    {
                        return true;
                    }

                }
            }
            return false;
        }


        public static bool readData(string path)
        {

            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string line;


                while ((line = file.ReadLine()) != null && line != "")
                {


                    string[] splittedRecord = line.Split(',');

                    string name = splittedRecord[0];

                    string[] splittedProduct = splittedRecord[1].Split(';');

                    Customer newCustomer = new Customer(name);

                    foreach (string pName in splittedProduct)
                    {
                        soldtype p = soldtypeDL.isProductExist(pName);
                        if (p != null)
                        {
                            newCustomer.addBuyedProduct(p);
                        }
                    }

                    addIntoCustomerList(newCustomer);

                }
                file.Close();
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void combineData()
        {
            if (presentCustomer != null)
            {
                string name = presentCustomer.CustomerName;

                foreach (Customer c in CustomerList)
                {

                    if (name == c.CustomerName)
                    {
                        c.Purchased = presentCustomer.getProductList();
                    }
                }
            }
        }

        public static void storeData(string path)
        {
            StreamWriter file = new StreamWriter(path);
            combineData();

            foreach (Customer c in CustomerList)
            {


                string productNames = "";
                string name = c.CustomerName;
                List<soldtype> pList = c.Purchased;
                if (pList.Count != 0)
                {
                    for (int idx = 0; idx < pList.Count - 1; idx++)
                    {
                        productNames = productNames + pList[idx].ProductName + ";";
                    }
                    productNames = productNames + pList[pList.Count - 1].ProductName;
                }
                file.WriteLine(name + "," + productNames);

            }
            file.Flush();
            file.Close();
        }

    }
}
