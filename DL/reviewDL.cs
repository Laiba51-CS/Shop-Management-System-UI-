using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Shop_management_system.Resources.BL;

namespace Shop_management_system.DL
{
    class reviewDL
    {
        public static List<review> reviews = new List<review>();

        public static void addproductsintoList(review p)
        {
            //adding the products into list
            reviews.Add(p);
        }

        //Function to add into the text file the product from the main program
        public static void addintotextFile(string path1, review p)
        {
            StreamWriter newfile = new StreamWriter(path1, true);

            newfile.WriteLine(p.customername + " " +p.revies);
            newfile.Flush();
            newfile.Close();

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
                    string a = splittedrecord[1];
                  

                    review p = new review(name,a);
                      reviewDL.addproductsintoList(p);
                }

                file.Close();
            }

        }
        public static string viewReviews()
        {
         
            string msg = "";

            foreach (review r in reviews)
            {
                if (r.revies == null)
                {
                    msg = " We have no reviews to show....! ";

                }
                else
                {
                    msg = r.customername + "," + r.revies;
                }
            }

            return msg;
        }
    }


}

