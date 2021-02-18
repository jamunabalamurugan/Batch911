using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;


namespace ADODay2
{
    class TransactionScopeEg
    {
        static void LocalTransaction()
            {
            int i, j;
          string myconnection="Data Source=DESKTOP-PU8R89M\\BRSQL;Initial Catalog=Northwind;Integrated Security=true";
            using (TransactionScope myscope = new TransactionScope())
            {
               using(var con=new SqlConnection(myconnection))
                {
                    con.Open();
                    try
                    {
                        var mycmd = new SqlCommand("Insert into Shippers values('Mobiwik', '123456789')", con);
                        i = mycmd.ExecuteNonQuery();

                        // command to insert into region
                        var mycmd1 = new SqlCommand("insert into Region values(18,'DoubleCentral')", con);
                        j = mycmd1.ExecuteNonQuery();
                        myscope.Complete();

                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
        }

        static void DistributedTransaction()
        {
            string mycon1 = "Data Source=DESKTOP-PU8R89M\\BRSQL;Initial Catalog=Northwind;Integrated Security=true";
            string mycon2 = "Data Source=DESKTOP-PU8R89M\\BRSQL;Initial Catalog=dbStudy;Integrated Security=true";

            using (TransactionScope myscope = new TransactionScope())
            {
                using (SqlConnection con2 = new SqlConnection(mycon2))
                {
                    con2.Open();
                    var cmd2 = new SqlCommand("insert into tblEmployee values('Amithabh', 8000,'Male', 5)", con2);
                    cmd2.ExecuteNonQuery();

                    using (var con1 = new SqlConnection(mycon1))
                    {
                        con1.Open();
                        var cmd1 = new SqlCommand("insert into Region values(20,'BlueDart')", con1);
                        cmd1.ExecuteNonQuery();

                    }
                    myscope.Complete();
                }

            }
        }
        static void Main()
        {
           // LocalTransaction();
            DistributedTransaction();
            Console.Read();
        }
    }
}
