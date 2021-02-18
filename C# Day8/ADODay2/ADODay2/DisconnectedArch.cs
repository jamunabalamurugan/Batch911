using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ADODay2
{
    class DisconnectedArch
    {
        static void Main()
        {
            SqlConnection con;
           //SqlCommand cmd;
            SqlDataAdapter da;
            try
            {
                con = new SqlConnection(@"Data Source=DESKTOP-PU8R89M\BRSQL;Initial Catalog=Northwind; 
Integrated Security=true");
                da = new SqlDataAdapter("select * from Region", con);
                con.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "NorthwindRegion");
                //DataTable dt = ds.Tables[0];
                DataTable dt = ds.Tables["NorthwindRegion"];
                foreach (DataRow rw in dt.Rows)
                {
                    foreach (DataColumn col in dt.Columns)
                    {
                        Console.Write(rw[col]);
                        Console.Write("");
                        //  Console.WriteLine(" ".PadLeft(20,'-'));
                    }
                    Console.WriteLine(" ");
                }
                Console.Read();
                //Adding one more table to the same Dataset
                Console.WriteLine("----------------------");
                da = new SqlDataAdapter("select * from Shippers", con);
                da.Fill(ds, "NorthwindShipper");
                dt = ds.Tables["NorthwindShipper"];
                foreach (DataRow rw in dt.Rows)
                {
                    foreach (DataColumn col in dt.Columns)
                    {
                        Console.Write(rw[col]);
                        Console.Write("");
                        //  Console.WriteLine(" ".PadLeft(20,'-'));
                    }
                    Console.WriteLine(" ");
                }
                Console.Read();
                
                //inserting or adding a new row to the dataset
                DataRow row = ds.Tables["NorthwindRegion"].NewRow();

                //giving values to the datacolumns of the new row
                row["RegionID"] = 17;
                row["RegionDescription"] = "New Region";

                //adding the new row with data to the datatable of the dataset
                ds.Tables["NorthwindRegion"].Rows.Add(row);

                // issuing Insert command to reflect in the database with the new values from the dataset
                da.InsertCommand = new SqlCommand("insert into Region values("+row["RegionID"]+",' "+row["RegionDescription"]+"')", con);
                
                //Filling the dataset with the new values
                da.Fill(ds);
              
                //reconciling the dataset with the actual records from the database table
               da.Update(ds, "NorthwindRegion");
                
              //iterating the datatable of the dataset to read the values row by row
                Console.WriteLine("-----------------------");
                dt = ds.Tables["NorthwindRegion"];
                foreach (DataRow rw in dt.Rows)
                {
                    foreach (DataColumn col in dt.Columns)
                    {
                        Console.Write(rw[col]);
                        Console.Write("");
                       
                    }
                    Console.WriteLine(" ");
                }
                Console.Read();
               
               
            }
            catch(Exception e)
            {
                Console.WriteLine("Somethings went Wrong ...");
                Console.WriteLine(e.Message);
            }

        }
    }
}
