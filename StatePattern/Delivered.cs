


namespace StatePattern
{

    public class Delivered : State
    {
        public void Change(Order order)
        {
            Console.WriteLine("Order " +order.Id+ " has been successfully Deliverd.");

        }
    }
    
    
    
    
}

