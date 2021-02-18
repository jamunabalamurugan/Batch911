using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADODay2
{
    #region
    class Region
    {
        public int RegionId { get; set; }
        public string RegionDescription { get; set; }

        internal void GetRegion()
        {
            Console.WriteLine("Enter Region Id:");
            RegionId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Region Description:");
            RegionDescription = Console.ReadLine();

        }
    }
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            DataAcess d = new DataAcess();
            // d.DisplayRegion();
            //  d.GetByScalar();
            // d.EditRegion();
            //  d.DisplayRegion();
            d.CallProcwithParam();
            Console.Read();

        }

    }
    class DataAcess
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataReader dr;

        public SqlConnection Getconnection()
        {
            con = new SqlConnection(@"Data Source=DESKTOP-PU8R89M\BRSQL;Initial Catalog=Northwind; Integrated Security=true");
            con.Open();
            return con;
        }

        public void DisplayRegion()
        {
            try
            {
                con = Getconnection();
                SqlDataReader dr;
                cmd = new SqlCommand("Select * from Region", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine(dr["RegionId"] + " " + dr["RegionDescription"]);
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                con.Close();
            }
        }


        internal void GetByScalar()
        {
            con = Getconnection();
            cmd = new SqlCommand("select count(RegionId)from Region", con);
            int count = Convert.ToInt32(cmd.ExecuteScalar());  // returns an scalar object
            Console.WriteLine("No. Of Regions :{0}", count);
        }

        internal void EditRegion()
        {
            Region r = new Region();
            Console.WriteLine("Enter the Region Id:");
            r.RegionId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Region Description to be modified:");
            r.RegionDescription = Console.ReadLine();
            con = Getconnection();
            cmd = new SqlCommand("update Region set RegionDescription=@rdesc where RegionID=@rid", con);
            cmd.Parameters.AddWithValue("@rid", r.RegionId);
            cmd.Parameters.AddWithValue("@rdesc", r.RegionDescription);
            int i = cmd.ExecuteNonQuery();
            Console.WriteLine("Rows Updated{0}", i);

        }
        ///summary
        /// Below function takes an input from the user and executes the procedure and returns the output
        ///calling stored procedure with parameter
        internal void CallProcwithParam()
        {
            con = Getconnection();
            Console.WriteLine("Enter Customer ID:");
            string custid = Console.ReadLine();
            cmd = new SqlCommand("CustOrdersOrders", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
           //  cmd.Parameters.AddWithValue("@customerid", custid);

            //or we can use object of SqlParameter class to define many properties associated with the parameter like data type, name, size, direction etc
            SqlParameter sqlparam = new SqlParameter("@customerid", custid);
           //
            sqlparam.ParameterName = "Customerid";
            sqlparam.Direction = System.Data.ParameterDirection.Input;
            sqlparam.DbType = System.Data.DbType.String;
            cmd.Parameters.Add(sqlparam);

            //execute the procedure
            dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                Console.WriteLine(dr["OrderId"] + "  " + dr["OrderDate"] + "  " + dr["RequiredDate"]+ "  " + dr["ShippedDate"]);
            }

            con.Close();
        }

    }
}

