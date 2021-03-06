using System;

namespace EditorHTML
{
  public static class Menu
  {
    public static void Show()
    {
      Console.Clear();
      Console.BackgroundColor = ConsoleColor.Blue;
      Console.ForegroundColor = ConsoleColor.Black; //Colore o texto

      DrawScreen();
      WriteOptions();
      short option = short.Parse(Console.ReadLine());
      HandleMenuOption(option);
    }

    public static void DrawScreen(){
      Console.Write("+");
      for(int i = 0; i <= 30; i++)
        Console.Write("-");

      Console.Write("+");
      Console.Write("\n");

      for(int lines = 0; lines <= 10; lines++){
        Console.Write("|");
        for(int i = 0; i <= 30; i++)
          Console.Write(" ");
        
          Console.Write("|");
          Console.Write("\n");
      }

      Console.Write("+");
      for(int i = 0; i <= 30; i++)
        Console.Write("-");

      Console.Write("+");
      Console.Write("\n");

    }

    public static void WriteOptions(){
      Console.SetCursorPosition(3, 2); // coloca o cursor na coluna 3 e na linha dois
      Console.WriteLine("Editor HTML");
      Console.SetCursorPosition(3, 3);
      Console.WriteLine("===========");
      Console.SetCursorPosition(3, 4);
      Console.WriteLine("Selecione uma opção abaixo:");
      Console.SetCursorPosition(3, 5);
      Console.WriteLine("1 - Novo Arquivo");
      Console.SetCursorPosition(3, 6);
      Console.WriteLine("2 - Abrir Arquivo");
      Console.SetCursorPosition(3, 7);
      Console.WriteLine("0 - Sair do Editor");
      Console.SetCursorPosition(3, 9);
      Console.Write("Opção: ");
    }

    public static void HandleMenuOption(short option){
      switch(option){
        case 1: Editor.Show(); break;
        case 2: Console.WriteLine("View"); break;
        case 0: Console.Clear(); Environment.Exit(0); break;
        default: Viewer.Show("text"); break;
      }
    }
  }
}
