using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DAClientList
    {
        public DataTable getClientsList(string nume, string prenume, string code)
        {
            DataTable dataTable = new DataTable();
            try
            {
                SqlConnection connection =
                       new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = connection;
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText =
                    "SELECT * from TClient ";


                if(!String.IsNullOrWhiteSpace(nume))
                { 
                    sqlCmd.CommandText += " where ClientName LIKE @Nume ";
                    sqlCmd.Parameters.AddWithValue("@Nume", "%"+nume+"%");
                }
                if (!String.IsNullOrWhiteSpace(prenume))
                {
                    if (String.IsNullOrWhiteSpace(nume))
                    {
                        sqlCmd.CommandText += " where ClientSurname LIKE @Prenume ";
                    }
                    else if(!String.IsNullOrWhiteSpace(nume))
                    { 
                        sqlCmd.CommandText += " and  ClientSurname LIKE @Prenume' ";
                    }
                    sqlCmd.Parameters.AddWithValue("@Prenume", "%" + prenume + "%");
                }
                if (!String.IsNullOrWhiteSpace(code))
                {
                    if (String.IsNullOrWhiteSpace(nume) && String.IsNullOrWhiteSpace(prenume))
                    {
                        sqlCmd.CommandText += " where ClientCode LIKE @CodeClient ";
                    }
                    else if (!String.IsNullOrWhiteSpace(nume) || !String.IsNullOrWhiteSpace(prenume))
                    {
                        sqlCmd.CommandText += " and  ClientCode LIKE @CodeClient ";
                    }
                    sqlCmd.Parameters.AddWithValue("@CodeClient", "%"+ code + "%");
                }
                SqlDataAdapter sqlDataAdap = new SqlDataAdapter(sqlCmd);

                SqlDataReader reader = sqlCmd.ExecuteReader();
                dataTable.Load(reader);
                return dataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
} 

