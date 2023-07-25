using Facade.Subsystems;

namespace Facade
{
    // This is a Facade class that provides a simple interface to the complex logic of one
    // or several subsystems. The Facade delegates the client requests to the
    // appropriate objects within the subsystem. 
    public class Order
    {
        public void PlaceOrder()
        {
            Console.WriteLine("Place order started");

            Product product = new Product();
            product.GetProductDetails();

            Payment payment = new Payment();
            payment.MakePayment();

            Invoice invoice = new Invoice();
            invoice.SendInvoice();

            Console.WriteLine("Order placed successfully");
        }
    }
}
