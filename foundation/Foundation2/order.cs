using System.Collections.Generic;

public class Order
{
    private List<Product> products;
    private Customer customer;
    private const double domesticShippingCost = 5.00;
    private const double internationalShippingCost = 35.00;

    public Order(Customer customer)
    {
        this.customer = customer;
        products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double total = 0;
        foreach (var product in products)
        {
            total += product.TotalCost();
        }
        double shippingCost = customer.LivesInUSA() ? domesticShippingCost : internationalShippingCost;
        return total + shippingCost;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in products)
        {
            label += product.GetProductInfo() + "\n";
        }
        return label.Trim();
    }

    public string GetShippingLabel()
    {
        return "Shipping Label:\n" + customer.GetCustomerInfo();
    }
}
