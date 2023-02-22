using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Shop_management_system.Resources.BL;

namespace Shop_management_system.DL
{
    class ProductDL

    {
        public static List<Product> products = new List<Product>();

        public static void addproductsintoList(Product p)
        {
            //adding the products into list
            products.Add(p);
        }

        //Function to add into the text file the product from the main program
        public static void addintotextFile(string path1, Product p)
        {
            StreamWriter newfile = new StreamWriter(path1, true);

            newfile.WriteLine(p.ProductName + "," + p.Price + "," + p.Quantity + "," + p.Brand + "," + p.Threshold);
            newfile.Flush();
            newfile.Close();

        }

        public List<Product> stock()
        {

            if (products != null && products.Count > 0)
            {

                foreach (Product p in products)
                {
                    return products;

                }


            }
            return products;
        }

        public static void storeData(string path)
        {
            StreamWriter newfile = new StreamWriter(path);
            foreach (Product p in products)
            {
                newfile.WriteLine(p.ProductName + "," + p.Price + "," + p.Quantity + "," + p.Brand + "," + p.Threshold);
            }
            newfile.Flush();
            newfile.Close();
        }
       

        public static void readdatafromfile(string path1)
        {
            string name;
            int price;
            int quantity;
            string brand;
            int threshold;

            StreamReader file = new StreamReader(path1);
            string line;
            if (File.Exists(path1))
            {
                while ((line = file.ReadLine()) != null)
                {
                    if (line == "")
                    {
                        continue;
                    }
                    string[] splittedrecord = line.Split(',');
                    name = splittedrecord[0];
                    price = int.Parse(splittedrecord[1]);
                    quantity = int.Parse(splittedrecord[2]);
                    brand = splittedrecord[3];
                    threshold = int.Parse(splittedrecord[4]);

                    Product p = new Product(name, price, quantity, brand, threshold);
                    products.Add(p);
                }

                file.Close();
            }

        }
        public static void viewReviews(List<string> review)
        {
            
            if (review.Count == 0)
            {
                Console.WriteLine(" We have no reviews to show....! ");
            }
            else
            {
                for (int i = 0; i < review.Count; i++)
                {
                    Console.WriteLine(review[i]);
                }
            }
            Console.WriteLine(" Press any key to continue....");
            Console.Read();
        }
        public static List<Product> sortedlist()
        {
            if (products != null)
            {
                List<Product> sortedProductList = products.OrderByDescending(z => z.Price).ToList();
                return sortedProductList;
            }
            return null;
        }
        public static Product isProductExist(string productName)
        {
            if (products != null)
            {
                foreach (Product product in products)
                {
                    if (product.ProductName == productName)
                    {
                        return product;
                    }
                }
            }
            return null;
        }



        public static List<Product> stockToManage()
        {
            List<Product> manageProduct = new List<Product>();
            foreach (Product p in products)
            {
                if (p.Quantity < p.Threshold)
                {
                    manageProduct.Add(p);
                }
            }

            if (manageProduct.Count != 0)
            {
                return manageProduct;
            }

            return null;
        }
    }
}
