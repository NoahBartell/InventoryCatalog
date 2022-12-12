using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

/////////Data buddy is the only class that interacts with the database.
/////////I designed it like this to make sure no data is compromised and easy to implement.
/////////Data buddy is static so it doesn't need to be instantiated. only called when a change
/////////to the database is neccessary

namespace InventoryCatalog
{
    static class DataBuddy
    {
        static SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ToolCrib;Integrated Security=True");
        /////// Start User Management
        public static int logincheck(string user, string pass)
        {
            con.Open();
            SqlCommand sqcmd = new SqlCommand($"Select * from accountTbl where email='{user}' and password='{pass}'", con);
            SqlDataAdapter da = new SqlDataAdapter(sqcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            if (dt.Rows.Count > 0)
            {
                int Id = dt.Rows[0].Field<int>("id");
                return Id;
            }
            else
            {
                return 0;
            }

        }

        //Get Name
        public static string GetName(int id)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"Select fName, lName from [accountTbl] where id='{id}'";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dta);
            con.Close();
            string FN = dta.Rows[0]["fName"].ToString();
            string LN = dta.Rows[0]["lName"].ToString();
            return $"{FN} {LN}";
        }

        public static bool IsAdmin(int id)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"Select admin from [accountTbl] where id='{id}'";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dta);
            con.Close();
            bool isAdmin = Convert.ToBoolean(dta.Rows[0]["admin"]);
            return isAdmin;
        }

        //insert new student
        public static bool submitBtn(int id, string fName, string lName, string pass, string email, int isAdmin)
        {
            con.Open();
           
            if (id != 0)
            {
                //if an id greater than zero is sent (meaning a current record is wanting to be updated) update info
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"update [accountTbl] set fName='{fName}', lName='{lName}', password='{pass}', email='{email}', admin='{isAdmin}' where id='{id}'";
                cmd.ExecuteNonQuery();
                con.Close();
                return false;
            }
            else
            {
                //if id = 0 (record isn't selected) insert a new record into table
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"insert into [accountTbl] (fName, lName, password, email, admin) values ('{fName}', '{lName}', '{pass}', '{email}', '{isAdmin}')";
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
        }
        //Display Student accounts
        public static DataTable displayUser()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from [accountTbl]";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dta);
            con.Close();
            //returns data table
            return dta;
        }

        //deletes user
        public static void deleteUser(int id)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"delete from [accountTbl] where id='{id}'";
            cmd.ExecuteNonQuery();
            con.Close();
        }

        /////////End Student Management
        /////////Start Tool Management

        public static DataTable displayTool()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from [toolTbl]";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dta);
            con.Close();
            return dta;
        }
        //either inserts or updates a record
        public static bool submitBtn(int id, string name, int categoryId, int programId)
        {
            con.Open();

            if (id != 0)
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"update [toolTbl] set name='{name}', categoryId='{categoryId}', programId='{programId}' where id='{id}'";
                cmd.ExecuteNonQuery();
                con.Close();
                return false;
            }
            else
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"insert into [toolTbl] (name, imperial, metric, qty, categoryId, programId) values ('{name}', '{categoryId}', '{programId}')";
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
        }
        //deletes selected tool
        public static void deleteTool(int id)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"delete from [toolTbl] where id='{id}'";
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //add size for tool
        public static void AddSize(int toolId, string imp, string met, int qty)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"insert into [sizeTbl] (Id, imperial, metric, quantity) values ('{toolId}', '{imp}', '{met}', {qty})";
            cmd.ExecuteNonQuery();
            con.Close();
        }

        /////////End Tool Management
        /////////Start In use management
        ///
        //gets the specific list of sizes for the tool
        public static List<Object> GetSizes(int toolId)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"Select imperial, metric from [sizeTbl] where Id={toolId}";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dta);
            con.Close();
            return ConvertToObjects(dta);
        }

        public static DataTable GetSizesDT(int toolId)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"Select imperial, metric, quantity from [sizeTbl] where Id={toolId}";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dta);
            con.Close();
            return dta;
        }
        //Takes a datagrid and converts it into a object array
        public static List<Object> ConvertToObjects(DataTable dt)
        {
            var rows = dt.Rows;
            int rowCount = rows.Count;
            //int colCount = dt.Columns.Count;
            //var result = new Object[rowCount];
            var result = new List<Object>();

            for (int i = 0; i < rowCount; i++)
            {
                if(rows[i]["imperial"].ToString() == "")
                {
                    result.Add(rows[i]["metric"]);
                }
            }
            for (int i = 0; i < rowCount; i++)
            {
                if (rows[i]["metric"].ToString() == "")
                {
                    result.Add(rows[i]["imperial"]);
                }
            }

            if (result.Count == 0)
            {
                return null;
            }
            else
            {
                return result;
            }

        }
        public static int GetQuantity(int id, Object size)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"Select qty from [sizeTbl] where id={id} and imperial={size} or metric={size}";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dta);
            con.Close();
            return 0;
        }


        ///////In Use managment
        
        public static void PutInUse(int userId, int toolId, string size)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"INSERT INTO inUseTbl (toolId, accountId, date, size) VALUES ('{toolId}', '{userId}', '{DateTime.Now}', '{size}')";
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //Gets Currently owned tools
        public static DataTable GetOwned(int UserId)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"Select a.id AS 'ID', fName AS 'First Name', lName AS 'Last Name', c.name AS 'Tool Name', date, size AS 'Tool Size'" +
                $"FROM [inUseTbl] a " +
                $"LEFT JOIN [accountTbl] b ON a.accountId = b.id " +
                $"LEFT JOIN [toolTbl] c  ON c.id = a.toolId " +
                $"where a.accountId={UserId}";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dta);
            con.Close();
            return dta;
        }
        //Removes in Use tool from DB
        public static void TakeOutInUse(int Id)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"Delete from [inUseTbl] where id={Id}";
            cmd.ExecuteNonQuery();
            con.Close();
        }


        //HISTORY

        public static void CheckIn(int ID)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"UPDATE HistoryTbl SET CheckedIn='{DateTime.Now}' WHERE Id={ID}";
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public static DataTable GetHistory(String search)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"Select a.Id AS 'ID', b.fName AS 'First Name', b.lName AS 'Last Name', " +
                $"c.name AS 'Tool Name', ToolSize AS 'Tool Size', a.CheckedOut AS 'Checked Out', " +
                $"a.CheckedIn AS 'Checked In' FROM[HistoryTbl] a " +
                $"LEFT JOIN[accountTbl] b ON a.[user] = b.id " +
                $"LEFT JOIN[toolTbl] c ON c.id = a.tool " +
                $"WHERE a.Id LIKE '%{search}%' OR " +
                $"b.fName LIKE '%{search}%' OR " +
                $"b.lName LIKE '%{search}%' OR " +
                $"c.name LIKE '%{search}%'";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dta);
            con.Close();
            return dta;
        }
    }
}
