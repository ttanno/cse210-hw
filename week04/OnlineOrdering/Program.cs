using System;

class Program
{
    static void Main(string[] args)
    {
        // Crear direcciones
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Address address2 = new Address("45 Rue de Rivoli", "Paris", "Île-de-France", "France");
        
        // Crear clientes
        Customer customer1 = new Customer("John Smith", address1);
        Customer customer2 = new Customer("Pierre Dupont", address2);
        
        // Crear productos
        Product product1 = new Product("Laptop", 1001, 1000, 1);
        Product product2 = new Product("Mouse", 1002, 25, 2);
        Product product3 = new Product("HeadPhone", 2001, 1000, 1);
        Product product4 = new Product("Smartphone", 2002, 25, 2);
        
        // Crear listas de productos
        List<Product> productslst1 = new List<Product> { product1, product2 };
        List<Product> productslst2 = new List<Product> { product3, product4 };
        
        // Crear lista de clientes y sus órdenes respectivas
        List<Customer> customers = new List<Customer> { customer1, customer2 };
        List<List<Product>> ordersProducts = new List<List<Product>> { productslst1, productslst2 };

        // Procesar órdenes
        for (int i = 0; i < customers.Count; i++)
        {
            Order order = new Order(ordersProducts[i], customers[i]);
            float total = order.calculateTotalCost();
            order.CreateShippingLabel();
            order.CreatePackingLabel();
            Console.WriteLine($"Total cost: {total}\n");
        }
    }
}