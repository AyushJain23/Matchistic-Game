using System;
class game {
  int i , m = 21 ,choice,a;
   
   
  public void play()
  {   
      Console.WriteLine("Welcome in the Game");
     
       
      
      Console.WriteLine("   This is the matchstick game   ");
      Console.WriteLine("   --------------------------");
      
      Console.WriteLine("Game Start");
      
      Console.WriteLine("Total no. of Matchstick");
      for(i=0;i<m;i++)
        {
           Console.Write("! ");
        }
      Console.WriteLine();
      while(m >= 1)
        { 
             
               if(m==1)
               {
                   Console.WriteLine("User Lose");
                   Console.WriteLine("Computer Won ");
                   
                   break;
               }
        
          
               
        
       
        Console.WriteLine("User Turn");
        Console.WriteLine("Enter the value how many matchstick you want to pick  1 , 2 , 3 ,4 ");
        choice = int.Parse(Console.ReadLine());
            if(choice > 0 && choice< 5 ) 
            {
            
               Console.WriteLine(""); 
               m = m - choice ;
               Console.WriteLine("Remaining no. of Matchstick is " + m);
               for(i=0;i<m;i++)
                {
                  Console.Write("! ");
                }
     
               Console.WriteLine("");
               if(m==1)
                 {
                  Console.WriteLine("Computer lose");
                   Console.WriteLine("User Win");
                       
                       
                  break ;
                 }
             
             
              Console.WriteLine(" Computer turn");
              Console.WriteLine(".");
              for(i=1;i<500 ; i++) Console.Write("");
              Console.WriteLine("..");
               for(i=1;i<500 ; i++) Console.Write("");
              Console.WriteLine("...");
              a = 5 - choice;
              Console.WriteLine("Computer Choose " +  a);
              m = m - a ;
              Console.WriteLine("Remaining no. of Matchstick is " + m );
              for(i=0;i<m;i++)
               {
                Console.Write("! ");
               }
               Console.WriteLine("");
             }
         
        
         else
          {
            Console.WriteLine("Invalid Choice");
            Console.WriteLine("Please enter again");
            continue;
        
         }
      
      }
      
      
    
      
  }
  public static void Main(String[] args)
  {
    game g = new game();
      g.play();
  
  }

}
