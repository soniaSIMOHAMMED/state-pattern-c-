


namespace StatePattern
{

    public class Shipped : State
    {
        public void Change(Order order)
        {
            order.State = new Delivered();
            Console.WriteLine("Change state from Shipped to Deliverd.");
        }
    }
    
    
    
    
}