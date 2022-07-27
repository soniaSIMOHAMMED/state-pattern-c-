


namespace StatePattern
{

    public class Placed : State
    {
        public void Change(Order order)
        {
            order.State = new Packed();

            Console.WriteLine("Change state from Placed to Packed.");
        }
    }
    
    
    
    
}