interface IEntity
{
    int Id { get; set; }
}


interface IRepository<T> where T : IEntity
{
    public void Add(T item);
    public void Delete(T item);
    public T FindById(int id);
    public IEnumerable<T> GetAll();
}

class ProductRepository : IRepository<Product>
{
    List<Product> products;

    public void Add(Product item)
    {
        products.Add(item);
    }

    public void Delete(Product item)
    {
        products.Remove(item);
    }

    public Product FindById(int id)
    {
        int index = products.FindIndex(p => p.Id == id);
        if(index == -1)
        {
            return products[index];
        }
        else
        {
            Console.WriteLine("Такого индекса нет в массиве");
            return null;
        }
    }

    public IEnumerable<Product> GetAll()
    {
        foreach(var prod in products)
        {
            Console.WriteLine(prod);
            yield return prod;
        }
    }
}
class CustomerRepository : IRepository<Customer>
{
    List <Customer> customers;

    public void Add(Customer item)
    {
        customers.Add(item);
    }

    public void Delete(Customer item)
    {
        customers.Remove(item);
    }

    public Customer FindById(int id)
    {
        int index = customers.FindIndex(p => p.Id == id);
        if (index == -1)
        {
            return customers[index];
        }
        else
        {
            Console.WriteLine("Такого индекса нет в массиве");
            return null;
        }
    }

    public IEnumerable<Customer> GetAll()
    {
        foreach (var prod in customers)
        {
            Console.WriteLine(prod);
            yield return prod;
        }
    }
}
class Product : IEntity
{
    public int Id { get; set; }
    string Name { get; set; }
    int Price { get; set; }
    string Address { get; set; }
    public Product(int id, string name, int price, string address)
    {
        Id = id;
        Name = name;
        Price = price;
        Address = address;
    }
}
class Customer : IEntity
{
    public int Id { get ; set; }
    string Name { get; set; }
    int Price { get; set; }
    string Address { get; set; }
    public Customer(int id, string name, int price, string address)
    {
        Id = id;
        Name = name;
        Price = price;
        Address = address;
    }
}
class Program
{
    static void Main(string[] args)
    {
        CustomerRepository customerpository = new CustomerRepository();
        ProductRepository productRepository = new ProductRepository();
        Product product = new Product(1, "Alfred", 30000, "Logovo BetMan'a stavochnika");
        Product product1 = new Product(2, "Alfredddddd", 3045000, "Lovo BitMan'a stavochnika");
        productRepository.Add(product);
        Customer customer = new Customer(4,"Batmen", 10000000, "Скучное каноничное логово");
        Customer customer2 = new Customer(3, "Battonmen", 10000000, "Скучное ну рил рил рил каноничное логово");
        customerpository.Add(customer);
        productRepository.Add(product1);
        customerpository.Add(customer2);
        productRepository.FindById(2);
        customerpository.FindById(3);
        productRepository.GetAll();
        customerpository.GetAll();
        productRepository.Delete(product1);
        customerpository.Delete(customer2);

    }
}