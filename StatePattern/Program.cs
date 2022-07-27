// See https://aka.ms/new-console-template for more information

using StatePattern;


        Order order = new Order(1, new Placed());



        //Change state request from Placed to Packed.

        order.Request();



        //Change state request from Packed to Shipped.

        order.Request();



        //Change state request from Shipped to Delivered.

        order.Request();
        
        
        

        //order.Request();

    
