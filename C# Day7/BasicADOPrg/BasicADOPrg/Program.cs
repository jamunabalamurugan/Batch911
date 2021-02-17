using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BasicADOPrg
{
    class Program
    {
        public static SqlConnection con = new SqlConnection(); // an empty connection object
        public static SqlCommand cmd = new SqlCommand();//command object for issuing sql commands
        public static SqlDataReader dr;
        static void Main(string[] args)
        {
            // SelectData();
            // InsertData();
            //InsertwithParameter();
            //DeleteData();
            //  SelectData();
            DisconnectSelect();
            Console.Read();
        }

        static void SelectData()
        {
            con = GetConnection();
            cmd = new SqlCommand("select * from tblEmployee", con); //or
                                                                    // cmd = new SqlCommand("select * from tblEmployee");
                                                                    //cmd.Connection = con;
            dr=cmd.ExecuteReader();
            while (dr.Read())
            {
                Console.WriteLine(dr[0] + " " + dr[1] + " " + dr[2]+ " " + dr[3]+" " +dr[4]);
            }
        }

        static void InsertData()
        {
            con = GetConnection();
            cmd=new SqlCommand("insert into tblEmployee values('ADO',5800,'Male',2)");
            cmd.Connection = con;
            int count = cmd.ExecuteNonQuery();
            if(count > 0)
            {
                Console.WriteLine("Record Added Successfully");
            }
            else
            {
                Console.WriteLine("Unsuccessful");
            }
        }

        static void InsertwithParameter()
        {
            con = GetConnection();
            Console.WriteLine("Enter Name, Salary, Gender");
            string ename = Console.ReadLine();
            float esalary = float.Parse(Console.ReadLine());
            string egender = Console.ReadLine();
            cmd = new SqlCommand("Insert into tblEmployee(Name, Salary, Gender) values(@name,@salary,@gender)");
            cmd.Parameters.AddWithValue("@name", ename);
            cmd.Parameters.AddWithValue("@salary", esalary);
            cmd.Parameters.AddWithValue("@gender", egender);
            cmd.Connection = con;
            int result = cmd.ExecuteNonQuery();
            if(result>0)
            {
                Console.WriteLine("One Row added to the Employee table");
            }
        }

        static void DeleteData()
        {
            con = GetConnection();
            Console.WriteLine("Enter the Empid to delete:");
            int eid = Convert.ToInt32(Console.ReadLine());
            SqlCommand cmd1 = new SqlCommand("select * from tblEmployee where ID=@id");
            cmd1.Parameters.AddWithValue("@id", eid);
            cmd1.Connection = con;
            // SqlDataReader dr1 = cmd1.ExecuteReader();
            int r=cmd1.ExecuteNonQuery();
            Console.WriteLine(r);
            //while(dr1.Read())
            //{
            //    for(int i=0; i<dr1.FieldCount; i++)
            //    {
            //        Console.WriteLine(dr1[i]);
            //    }
            //}
            con.Close();
            Console.WriteLine("Are you sure to Delete this Record? Y/N");
            string answer = Console.ReadLine();
            if(answer=="Y" || answer=="y")
            {
                cmd = new SqlCommand("delete from tblEmployee where ID=@id",con);
                cmd.Parameters.AddWithValue("@id", eid);
                con.Open();
                cmd.ExecuteReader();
                //if(res > 0)
                //{
                //    Console.WriteLine("Record deleted successfully");
                //}
                //else
                //{
                //    Console.WriteLine("Unable to delete ");
                //}
            }
          
        }

        // Function using disconnected Architecture

        static void DisconnectSelect()
        {
            con = GetConnection();
            cmd = new SqlCommand("select * from tblEmployee", con);
            DataSet ds = new DataSet(); // empty data object
            SqlDataAdapter da = new SqlDataAdapter(cmd);
          //  da.
            da.Fill(ds,"Emp");
            con.Close();
            DataTable dt = ds.Tables[0];
            //DataTable dt1 = ds.Tables[1];
            foreach(DataRow drow in dt.Rows)
            {
                foreach(var x in drow.ItemArray)
                {
                    Console.Write(x);
                }
                Console.Read();
            }

        }

        static SqlConnection GetConnection()
        {
            con = new SqlConnection("Data Source=DESKTOP-PU8R89M\\BRSQL;Initial Catalog=dbStudy;Integrated Security=true");
            con.Open();
            return con;
        }

    }
}
