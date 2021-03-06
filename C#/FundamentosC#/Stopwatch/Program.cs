using System;
using System.Threading;

namespace Stopwatch
{
  public class Program
  {
    public static void Main()
    {
      Menu();
    }

    public static void Menu(){
      Console.Clear();
      Console.WriteLine("Digite o tempo que você quer contar e depois digite um [s] ou um [m] ao lado:");
      Console.WriteLine("S = Segundos");
      Console.WriteLine("M = Minutos");
      Console.WriteLine("0 = Sair");
      Console.WriteLine("Quanto tempo deseja contar?");

      string data = Console.ReadLine().ToLower();
      char type = char.Parse(data.Substring(data.Length-1, 1));
      int time = int.Parse(data.Substring(0, data.Length-1));
      int multiplier = 1;

      if(type == 'm')
        multiplier = 60;
      if(time == 0)
        System.Environment.Exit(0);

      Start(time * multiplier);
    }

    public static void Start(int time){
      int currentTime = 0;

      for(int i = currentTime; i <= time; i++){
        Console.Clear();
        Console.Write(i);
        Thread.Sleep(1000);
      }
      Console.Clear();
      Console.WriteLine("Retornando ao menu");
      Thread.Sleep(2500);
    }
  }
}