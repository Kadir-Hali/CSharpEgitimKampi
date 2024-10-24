using System;
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

            SqlConnection connection = new SqlConnection("");
        }
    }
}
