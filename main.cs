using System;

class MainClass {
  public static void Main (string[] args) {
    Random rnd = new Random ();
    Console.WriteLine ("Pick rock 1, paper 2 or scissors 3");
    int game = Convert.ToInt32(Console.ReadLine());
    //Console.WriteLine (game);
    int play = rnd.Next (1,4);
    Console.WriteLine (play);

    if (game == play){
      Console.WriteLine ("Draw");

      //return;
    }
    if (play == 3 ){
      if (game == 1){
      Console.WriteLine ("You Win");
      }
      if (game == 2){
        Console.WriteLine ("You loose");
      }
    }
    if (play == 2){
      if (game == 1){
        Console.WriteLine ("You loose");
      }
      if (game == 3){
        Console.WriteLine ("you win");

      }
    }
    if (play == 1){
      if (game == 3){
        Console.WriteLine ("You win");
      
      }
      if (game == 2){
        Console.WriteLine ("You loose");
      } 
    
    
    }

  }
  
}