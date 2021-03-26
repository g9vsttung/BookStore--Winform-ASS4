using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            BookDB db = new BookDB();
            Console.WriteLine("ok");
            List<Book> list = db.findBooks("a");
            foreach (var i in list){
                Console.WriteLine(i.BookName);
            }
           
            Console.ReadLine();
        }
    }
    public class BookDB
    {
        private readonly string strConnection = @"server=localhost;database=BookStore_A4;uid=sa;pwd=123456";      
       
        public List<Book> getBooks()
        {
            string SQL = "select * from Books";
            SqlConnection cnn = null;
            List<Book> list = new List<Book>();
            try
            {
                cnn = new SqlConnection(strConnection);
                SqlCommand command = new SqlCommand(SQL, cnn);
                cnn.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Book b = new Book()
                    {
                        BookID = int.Parse(reader["BookID"].ToString()),
                        BookName = reader["BookName"].ToString(),
                        BookPrice=float.Parse(reader["BookPrice"].ToString())
                    };
                    list.Add(b);
                }
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
            finally
            {
                cnn.Close();
            }
            return list;
        }
        public List<Book> findBooks(string search)
        {
            string SQL = "select * from Books where BookName like @name";
            SqlConnection cnn = null;
            List<Book> list = new List<Book>();
            try
            {
                cnn = new SqlConnection(strConnection);
                SqlCommand command = new SqlCommand(SQL, cnn);
                cnn.Open();
                command.Parameters.AddWithValue("@name", "%" + search + "%");
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Book b = new Book()
                    {
                        BookID = int.Parse(reader["BookID"].ToString()),
                        BookName = reader["BookName"].ToString(),
                        BookPrice = float.Parse(reader["BookPrice"].ToString())
                    };
                    list.Add(b);
                }
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
            finally
            {
                cnn.Close();
            }
            return list;
        }
        public bool addNewBook(Book book)
        {
            string SQL = "insert Books values (@name,@price)";
            SqlConnection cnn = null;          
            try
            {
                cnn = new SqlConnection(strConnection);
                SqlCommand command = new SqlCommand(SQL, cnn);
                cnn.Open();
                command.Parameters.AddWithValue("@name", book.BookName);
                command.Parameters.AddWithValue("@price", book.BookPrice);
                return command.ExecuteNonQuery() == 1;               
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
            finally
            {
                cnn.Close();
            }
        }
        public bool updateBook(Book book)
        {
            string SQL = "Update Books set BookName=@name,BookPrice=@price where BookID=@id ";
            SqlConnection cnn = null;
            try
            {
                cnn = new SqlConnection(strConnection);
                SqlCommand command = new SqlCommand(SQL, cnn);
                cnn.Open();
                command.Parameters.AddWithValue("@name", book.BookName);
                command.Parameters.AddWithValue("@price", book.BookPrice);
                command.Parameters.AddWithValue("@id", book.BookID);
                return command.ExecuteNonQuery() == 1;
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
            finally
            {
                cnn.Close();
            }
        }
        public bool deleteBook(int ID)
        {
            string SQL = "delete Books where BookID=@id";
            SqlConnection cnn = null;
            try
            {
                cnn = new SqlConnection(strConnection);
                SqlCommand command = new SqlCommand(SQL, cnn);
                cnn.Open();
                command.Parameters.AddWithValue("@id", ID);
                return command.ExecuteNonQuery() == 1;
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
            finally
            {
                cnn.Close();
            }
        }
    }
    public class EmployeeDB
    {
        private readonly string strConnection = @"server=localhost;database=BookStore_A4;uid=sa;pwd=123456";
        
        public string CheckLogin(string id, string pass)
        {
            string SQL = "Select * from Employee where EmpID=@id and EmpPassword=@pass";
            string role = "";
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(strConnection);
                SqlCommand command = new SqlCommand(SQL, connection);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@pass", pass);            
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                   string UserPass = reader["EmpPassword"].ToString().Trim();
                    if (UserPass == pass)
                    {
                    
                        bool EmpRole = (bool)reader["EmpRole"];
                        if (EmpRole)
                        {
                            role += "admin";
                        }
                        else
                        {
                            role += "employee";
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                connection.Close();
            }
            return role;
        }  
        public bool UpdateEmp(Employee e)
        {
            string SQL = "update Employee set EmpPassword=@pass where EmpID=@id";
            SqlConnection cnn = null;
            try
            {
                cnn = new SqlConnection(strConnection);
                SqlCommand command = new SqlCommand(SQL, cnn);
                cnn.Open();
                command.Parameters.AddWithValue("@id", e.EmpID);
                command.Parameters.AddWithValue("@pass", e.EmpPassword);
                return command.ExecuteNonQuery() == 1;
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
            finally
            {
                cnn.Close();
            }
        }
        public List<Employee> GetEmployees()
        {
            string SQL = "select * from Employee";
            SqlConnection cnn = null;
            List<Employee> list = new List<Employee>();
            try
            {
                cnn = new SqlConnection(strConnection);
                SqlCommand command = new SqlCommand(SQL, cnn);
                cnn.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Employee e = new Employee()
                    {
                        EmpID = reader["EmpID"].ToString()
                    };
                    list.Add(e);
                }
            }
            catch (SqlException se)
            {
                throw new Exception(se.Message);
            }
            finally
            {
                cnn.Close();
            }
            return list;
        }
    }
    public class Employee
    {
        public string EmpID { get; set; }
        public string EmpPassword { get; set; }
        public bool EmpRole { get; set; }
    }
    public class Book:  IComparable<Book>
    {
        public int BookID { get; set; }
        public string BookName { get; set; }
        public float BookPrice { get; set; }

        int IComparable<Book>.CompareTo(Book other)
        {
            if( this.BookPrice < other.BookPrice) return 1;
            else if (this.BookPrice > other.BookPrice) return -1;
            return 0;
        }

       
    }
}
