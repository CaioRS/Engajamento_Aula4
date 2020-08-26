using System;


class MainClass {

  public static double ex1 () {

    double n1, n2, resultado=0;
    string escolha;

    Console.Write ("Digite o primeiro numero:   ");
    n1 = float.Parse(Console.ReadLine());

    Console.Write ("Digite o segundo numero:    ");
    n2 = float.Parse(Console.ReadLine());


    Console.WriteLine ("Digite a operação que deseja realizar: ");
    Console.WriteLine ("Digite + para soma: ");
    Console.WriteLine ("Digite - para subtraçao: ");
    Console.WriteLine ("Digite * para multiplicação: ");
    Console.WriteLine ("Digite / para divisão: ");

    escolha = Console.ReadLine();

    while (escolha != "+" && escolha != "-" && escolha != "*" && escolha != "/"){
    Console.Write ("Numero digitado incorreto, escolha entre as operaçoes:  ");
    escolha = Console.ReadLine();
    }

    switch (escolha){
      case "+" :
      resultado = n1 + n2;
      break;
 
      case "-":
      resultado = n1-n2;
      break;

      case "*":
      resultado  = n1 * n2;
      break;

      case "/":
      resultado = n1/n2;
      break;
    }
   return resultado;
  }
  
  



  public static void Main (string[] args) {
    int menu;

    Console.WriteLine ("Apresentação Exercicio...escolha entre 1,2 ou 3: ");
    menu = int.Parse(Console.ReadLine());
    
   
    while (menu != 1 && menu !=2 && menu !=3){
      Console.WriteLine ("Numero digitado incorreto, escolha entre 1, 2 ou 3");
      menu = int.Parse(Console.ReadLine());
    }
     
    switch (menu)
    {
    case 1:
      Console.WriteLine("O resultado é :   {0}",ex1());
      break;
    
    case 2:
      ex2();
      break;
           
    case 3:
      ex3();
      break;
    }

  
  }
}