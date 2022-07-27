using System.Collections.Generic;
using System.Linq;

namespace StatePattern {
public class Order
{

          public Order(int id, State state)
      
          {
              Id = id;
              State = state;
              Console.WriteLine("Create object of Order class with initial State.");
      
          }
          
           public int Id { get; set; }
           public State State { get; set; }
           
               public void Request()
           
               {
           
                   State.Change(this);
           
               }


}
}