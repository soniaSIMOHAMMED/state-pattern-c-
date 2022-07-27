


namespace StatePattern
{

    public class Packed : State
    {
        public void Change(Order order)
        {
            order.State = new Shipped();

            Console.WriteLine("Change state from Packed to Shipped.");
        }
    }
    
    
    
    
}