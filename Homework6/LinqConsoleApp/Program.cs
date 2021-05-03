﻿namespace LinqConsoleApp
{
    using System;
    using System.Data.Linq;
    using System.Data.Linq.Mapping;
    using System.Linq;

    public class Northwind : DataContext
    {
        // Table<T> abstracts database details per table/data type.
        public Table<Customer> Customers;
        public Table<Order> Orders;

        public Northwind(string connection) : base(connection) { }
    }

    [Table(Name = "Customers")]
    public class Customer
    {
        private string _CustomerID;
        [Column(IsPrimaryKey=true, Storage="_CustomerID")]
        public string CustomerID
        {
            get
            {
                return this._CustomerID;
            }
            set
            {
                this._CustomerID = value;
            }
        }

        private string _City;
        [Column(Storage="_City")]
        public string City
        {
            get
            {
                return this._City;
            }
            set
            {
                this._City=value;
            }
        }

        private EntitySet<Order> _Orders;
        public Customer()
        {
            this._Orders = new EntitySet<Order>();
        }

        [Association(Storage = "_Orders", OtherKey = "CustomerID")]
        public EntitySet<Order> Orders
        {
            get { return this._Orders; }
            set { this._Orders.Assign(value); }
        }
    }

    [Table(Name = "Orders")]
    public class Order
    {
        private int _OrderID = 0;
        private string _CustomerID;
        private EntityRef<Customer> _Customer;
        public Order() { this._Customer = new EntityRef<Customer>(); }

        [Column(Storage = "_OrderID", DbType = "Int NOT NULL IDENTITY",
            IsPrimaryKey = true, IsDbGenerated = true)]
        public int OrderID
        {
            get { return this._OrderID; }
            // No need to specify a setter because IsDBGenerated is
            // true.
        }

        [Column(Storage = "_CustomerID", DbType = "NChar(5)")]
        public string CustomerID
        {
            get { return this._CustomerID; }
            set { this._CustomerID = value; }
        }

        [Association(Storage = "_Customer", ThisKey = "CustomerID")]
        public Customer Customer
        {
            get { return this._Customer.Entity; }
            set { this._Customer.Entity = value; }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // Use a connection string.
            Northwind db = new Northwind($"{Properties.Settings.Default.SqlDbFilePath}"
                                         + $"\\{Properties.Settings.Default.SqlDbFileName}");

            // Query for customers from Seattle.
            var custQuery =
                from cust in db.Customers
                where cust.City == "Seattle"
                select cust;

            foreach (var custObj in custQuery)
            {
                Console.WriteLine("ID={0}", custObj.CustomerID);
            }
            // Freeze the console window.
            Console.ReadLine();
        }
    }
}
