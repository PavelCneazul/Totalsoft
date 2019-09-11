using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class BLRegister
    {
        DARegister register = new DARegister();
        public BLRegister()
        {
        }
        public bool AddUser(string userName, string password)
        {

            string passwordEncrypted;
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(password);
            passwordEncrypted = System.Convert.ToBase64String(plainTextBytes);
            return register.AddUser(userName, passwordEncrypted);
        }
    }
}
