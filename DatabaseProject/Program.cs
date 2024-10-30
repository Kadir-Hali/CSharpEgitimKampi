using System;
using System.Data;
using System.Data.SqlClient;

namespace DatabaseProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            string tableNumber;
            Console.WriteLine("1-Kategori");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            tableNumber = Console.ReadLine();

            SqlConnection connection = new SqlConnection("Data Source=(LocalDb)\\MSSQLLocalDB; Initial Catalog=EgitimKampiDb; Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand("Select * from TblCategory", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.Close();

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.WriteLine(item.ToString());
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
