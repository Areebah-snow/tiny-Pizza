using System;

namespace PizzaOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO STUDENT CAFE /n");

            int size1, size2, size3;
            double size;
            size1 = 7;
            size2 = 9;
            size3 = 14;

            double cost1 = 3.0;
            double cost2 = 5.50;
            double cost3 = 7.25;
            Console.WriteLine("Enter Pizza Size( 7,9, 14)");
            size = Convert.ToDouble(Console.ReadLine());
          
            if (size == size1)
            {

                Console.WriteLine(cost1);
                Console.WriteLine("Your Cost is $3");
            }
            
            else if (size == size2)
            {
                Console.WriteLine(cost2);
                Console.WriteLine("Your cost is $5.50");

            }
            else if (size == size3) {

                Console.WriteLine(cost3);
                Console.WriteLine("This size is $7.25 ");
               
            }

           
            
            string[] toppings = { "Ham", "Olives", "Pineapple", "Pepperoni", "Mushrooms", "Extra Cheese" };
            for (int i=1; i < toppings.Length;i++) {
                    Console.WriteLine(i + "."+ toppings[i]);
            }
                Console.WriteLine("Select amount of toppings to be added:");
    
            int number = Convert.ToInt32(Console.ReadLine());   
            int[] toppingOrderNum = new int[number];

            
            Console.WriteLine("INPUT INDEX OF TOPPINGS DESIRED:(Starting from 0 - 5");
            for(int i = 0;i < number;i++){
                int orderID = Convert.ToInt32(Console.ReadLine());
                toppingOrderNum[i] = orderID;
            }

            Console.WriteLine("These are ur toppings: ");
            double toppingPrice = 0;
            for(int i = 0;i < toppingOrderNum.Length;i++){
                if(toppingOrderNum[i] == 0){
                    Console.WriteLine("Ham which has a value of 0.80");
                    toppingPrice += 0.80;
                }
                if(toppingOrderNum[i] == 1){
                    Console.WriteLine("Olives which has a value of 0.30");
                    toppingPrice += 0.30;
                }
                if(toppingOrderNum[i] == 2){
                    Console.WriteLine("Pineapple which has a value of 0.60");
                    toppingPrice += 0.60;
                }
                if(toppingOrderNum[i] == 3){
                    Console.WriteLine("Pepperoni which has a value of 1.00");
                    toppingPrice += 1.00;
                }
                if(toppingOrderNum[i] == 4){
                    Console.WriteLine("Mushrooms which has a value of 0.50");
                    toppingPrice += 0.50;
                }
                if(toppingOrderNum[i] == 5){
                    Console.WriteLine("Extra Cheese which has a value of 1.20");
                    toppingPrice += 1.20;
                }
            }

            double totalPrice = cost1 +toppingPrice;
            Console.WriteLine("Your order comes to "+ cost1 + " and cost of toppings at "+toppingPrice);
            Console.WriteLine("Total is: " +  totalPrice);
            }




        



          

        }
    }
          

