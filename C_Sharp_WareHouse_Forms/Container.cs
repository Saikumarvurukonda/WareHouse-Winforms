using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouse_Management
{

    public class Containers
    {
        public static List<Product> ProductList = new List<Product>();
        public static List<Customer> CustomerList = new List<Customer>();
        public static List<Order> OrderList = new List<Order>();

        public delegate void CustomerListGridViewUpdate();
        public event CustomerListGridViewUpdate CustomersUpdate;
        public delegate void ProductListGridViewUpdate();
        public event ProductListGridViewUpdate ProductsUpdate;
        public delegate void OrderListGriViewUpdate();
        public event OrderListGriViewUpdate OrdersUpdate;

        public void AddCustomer(Customer cust)
        {
            CustomerList.Add(cust);
            CustomersUpdate?.Invoke();
        }

        public void DeleteCustomer(int id)
        {
            var customer = CustomerList.Find(item => item.UniqueID == id);
            CustomerList.Remove(customer);
            CustomersUpdate?.Invoke();
        }

        public void AddProduct(Product product)
        {
            ProductList.Add(product);
            ProductsUpdate?.Invoke();
        }

        public void DeleteProduct(int id)
        {
            var product = ProductList.Find(x => x.UniqueID == id);
            ProductList.Remove(product);
            ProductsUpdate?.Invoke();
        }

        public void AddOrder(Order order)
        {
            OrderList.Add(order);
            OrdersUpdate?.Invoke();
        }

        public void DeleteOrder(int id)
        {
            var order = OrderList.Find(item => item.OrderID == id);
            var product = ProductList.Find(item => item.UniqueID == order.Product.UniqueID);
            if (!(product is null))
                product.Quantity += order.Quantity;
            else
            {
                Product pro = new Product()
                {
                    UniqueID = order.Product.UniqueID,
                    ArticleName = order.Product.ArticleName,
                    Price = order.Product.Price,
                    Quantity = order.Quantity,
                    Description = order.Product.Description,
                };
                ProductList.Add(pro);
            }
            OrderList.Remove(order);
            OrdersUpdate?.Invoke();
        }

        public static int GetLastCustomerID()
        {
            if (CustomerList.Count == 0) return 0;
            else
            {
                int i = CustomerList.OrderByDescending(item => item.UniqueID).First().UniqueID;
                return i;
            }
        }

        public static int GetLastProductID()
        {
            if (ProductList.Count == 0) return 0;
            else
            {
                int i = ProductList.OrderByDescending(item => item.UniqueID).First().UniqueID;
                return i;
            }
        }

        public static int GetLastOrderID()
        {
            if (OrderList.Count == 0) return 0;
            else
            {
                int i = OrderList.OrderByDescending(item => item.OrderID).First().OrderID;
                return i;
            }
        }

        public void UpdateCustomer(int index, string name, string surname, string email,
            string phone, string address)
        {
            if (index < 0) return;
            Customer customer = CustomerList.Find(item => item.UniqueID == index);
            customer.Update(name, surname, email, phone, address);
            CustomersUpdate?.Invoke();
            return;
        }

        public void UpdateProduct(int index, string name, decimal price, int quantity,
            string desc)
        {
            if (index < 0) return;
            Product product = ProductList.Find(item => item.UniqueID == index);
            product.Update(name, price, quantity,desc);
            ProductsUpdate?.Invoke();
            return;
        }


    }

}
