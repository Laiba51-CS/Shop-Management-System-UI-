using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Shop_management_system.DL
{
    class MuserDL
    {
        public static List<Muser> UsersList = new List<Muser>();

        public static bool readData(string path)
        {

            string name, password, role;

            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string line;


                while ((line = file.ReadLine()) != null)
                {
                    string[] splittedRecord = line.Split(',');

                    name = splittedRecord[0];
                    password = splittedRecord[1];
                    role = splittedRecord[2];

                    Muser user = new Muser(name, password, role);
                    AddUserIntoList(user);
                }
                file.Close();
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void storeData(string path)
        {

            StreamWriter file = new StreamWriter(path);
            int i = 0;
            foreach (Muser user in UsersList)
            {
                i++;
                file.Write(user.Username + "," + user.Password + "," + user.Role);
                if (i < UsersList.Count)
                {
                    file.WriteLine();
                }
            }

            file.Flush();
            file.Close();
        }

        public static void AddUserIntoList(Muser User)
        {
            UsersList.Add(User);
        }

        public static string isExist(Muser u)
        {
            string role = "";
            foreach (Muser user in UsersList)
            {
                if (user.Username == u.Username && user.Password == u.Password)
                {
                    role= user.Role;
                }
            }
            return role;
        }
    }
}
