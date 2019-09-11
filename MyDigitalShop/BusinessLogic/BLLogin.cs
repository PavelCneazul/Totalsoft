using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class BLLogin
    {
        public BLLogin()
        {
        }

        public UserModel CheckUser(string userName, string password, out bool status)
        {
            string passwordEncrypted;
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(password);
            passwordEncrypted = System.Convert.ToBase64String(plainTextBytes);

            UserModel user = new UserModel();
            status = false;
            DALogin da = new DALogin();
            DataTable tableUsers = da.CheckUser(userName);
            if (tableUsers.Rows.Count == 0)
                status = false;
            else
            {
                for(int i =0;i<tableUsers.Rows.Count;i++)
                {
                    if(passwordEncrypted == tableUsers.Rows[i]["UserPassword"].ToString())
                    {
                        user.UserId = Convert.ToInt32(tableUsers.Rows[i]["UserId"]);
                        user.UserName = tableUsers.Rows[i]["UserName"].ToString();
                        user.UserPasswrod = tableUsers.Rows[i]["UserPassword"].ToString();
                        user.LastLogin = DateTime.Now;
                        status = true;
                    }
                }
            }

            return user;
        }
    }
}
