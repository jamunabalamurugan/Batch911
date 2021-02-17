using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BasicADOPrg
{

    class Shipper
    {
        public int ShipperId { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }

        public void GetShipper()
        {
            Console.WriteLine("Enter Company Name");
            CompanyName = Console.ReadLine();
            Console.WriteLine("Enter Phone");
            Phone = Console.ReadLine();
        }
    }
    class ConnectedArchitecture
    {
        static void Main()
        {
            
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-PU8R89M\\BRSQL;Database=Northwind;Integrated Security=true");
                con.Open();
            SqlCommand cmd;
            try
            {
                //Shipper s = new Shipper();
                //s.GetShipper();
                //SqlCommand cmd = new SqlCommand("insert into Shippers values(@cname,@phoneno)", con);
                //cmd.Parameters.AddWithValue("@cname", s.CompanyName);
                //cmd.Parameters.AddWithValue("@phoneno", s.Phone);
                //int res = cmd.ExecuteNonQuery();
                //if (res > 0)
                //{
                //    Console.WriteLine("Added");
                //}
                //cmd.Parameters.Clear();
                //steps to execute a stored procedure
                cmd = new SqlCommand("Ten Most Expensive Products", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader sqd = cmd.ExecuteReader();
                while(sqd.Read())
                {
                    // Console.WriteLine(sqd[0] + "   " + sqd[1]);
                    Console.WriteLine(sqd[0].ToString() + "  " + sqd[1].ToString());
                }
                Console.Read();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                con.Close();
            }
        }


    }
}
