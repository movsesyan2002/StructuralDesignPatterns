// You receive product data in CSV line format, like:
// "Chair,129.99"
// But your system works internally with a Product object:
// public class Product
// {
//     public string Name { get; set; }
//     public double Price { get; set; }
// }
// Your task:
// Define an interface IProductProvider with a method:

// Product GetProduct();

// Create a class CsvProductAdapter that:


// Takes a CSV line string in the constructor


// Implements the IProductProvider interface


// In GetProduct(), parses the CSV string and returns a correctly populated Product object.

// Client Code to Test:
// string csvLine = "Chair,129.99";
// IProductProvider adapter = new CsvProductAdapter(csvLine);
// Product product = adapter.GetProduct();
// Console.WriteLine($"Name: {product.Name}, Price: {product.Price}");

// Name: Chair, Price: 129.99



interface IProductProvider {
    Product GetProduct();

}


class Product {
    
    public string? Name { get; set; }
    public string? Price { get; set; }

}


class Adapter : IProductProvider{

    private IProductProvider _adaptee;

    public Adapter(IProductProvider adaptee) {
        _adaptee = adaptee; 
    }

    public Product GetProduct() {
        return _adaptee.GetProduct();
    }
}

class CsvProductAdapter : IProductProvider {

    private string _csvLine ;

    public CsvProductAdapter (string csvLine) {
        this._csvLine = csvLine;
    }

    public Product GetProduct() {
        string[] strings= this._csvLine.Split(",");

        return new Product { Name = strings[0], Price = strings[1]};
    }
}
