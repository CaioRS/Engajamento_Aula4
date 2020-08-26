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
  
  public static void ex2(){

    int menu1=0 , quantidade = 0;
    double valor = 0;

    do{
      Console.WriteLine("Escolha uma das opçoes para incluir no pedido:");
      Console.WriteLine("100  Cachorro quente   R$ 1,70");
      Console.WriteLine("101   Bauru Simples    R$ 2,30");
      Console.WriteLine("102   Bauru com ovo    R$ 2,60");
      Console.WriteLine("103   Hamburguer       R$ 2,40");
      Console.WriteLine("104   Cheeseburguer    R$ 2,50");
      Console.WriteLine("105   Refrigerante     R$ 1,00");
      Console.WriteLine("0     Para finalizar o pedido");

        menu1 = int.Parse(Console.ReadLine());

        if (menu1 == 100){
          Console.WriteLine("Digite a quantidade:   ");
          quantidade = int.Parse(Console.ReadLine());
          valor = valor + (1.70*quantidade);
        }    

        if (menu1 == 101){
          Console.WriteLine("Digite a quantidade:   ");
          quantidade = int.Parse(Console.ReadLine());
          valor = valor + (2.30*quantidade);
        }

        if (menu1 == 102){
          Console.WriteLine("Digite a quantidade:   ");
          quantidade = int.Parse(Console.ReadLine());
          valor = valor + (2.60*quantidade);
        }

        if (menu1 == 103){
          Console.WriteLine("Digite a quantidade:   ");
          quantidade = int.Parse(Console.ReadLine());
          valor = valor + (2.40*quantidade);
        }
        
        if (menu1 == 104){
          Console.WriteLine("Digite a quantidade:   ");
          quantidade = int.Parse(Console.ReadLine());
          valor = valor + (2.50*quantidade);
        }
        
        if (menu1 == 105){
          Console.WriteLine("Digite a quantidade:   ");
          quantidade = int.Parse(Console.ReadLine());
          valor = valor + (1.00*quantidade);
        }

        if (menu1 == 0){
          Console.WriteLine("o valor do pedido eh: R$ {0}  ",valor);
        }  

        if(menu1 != 100 && menu1 != 101 && menu1 != 102 && menu1 != 103 && menu1 != 104 && menu1 != 105 && menu1 != 0){
          Console.WriteLine("Codigo errado");
        }
  
    }while (menu1 !=0);
  } 

  public static int ex3(){
    int jose=0 , joana=0 , roberto=0 ,nulo =0, branco = 0, voto;
  

    do{
      voto=-1;

      Console.WriteLine("Votação Eleitoral.... Escolha um candidato :");
      Console.WriteLine("33 - José Couve");
      Console.WriteLine("25 - Joana Bravo");
      Console.WriteLine("10 - Roberto Nove");
      Console.WriteLine("0 - Voto branco");
      Console.WriteLine("4 - Voto nulo");
      Console.WriteLine("100 - Encerrar votação");

      voto = int.Parse(Console.ReadLine());

      if(voto == 33){
        jose++;
      }
      if(voto == 25){
        joana++;
      }
      if(voto == 10){
        roberto++;
      }
      if(voto == 0){
        branco++;
      }
      if(voto == 4){
        nulo++;
      }
      if (voto == 100){
        voto = -1;
      }
      if(voto != 33 && voto != 25 && voto != 10 && voto != 0 && voto != 4 && voto != 100 && voto != -1){
        Console.WriteLine("Opcao invalida....Digite novamente");
      }
    }while(voto>=0);

    if (jose > joana && jose>roberto){
      Console.WriteLine("Vencedor: Jose Couve - {0} votos , branco - {1} votos, nulo - {2} votos",jose,branco,nulo);
      return 0;
    }
    if (joana > jose && joana>roberto){
      Console.WriteLine("Vencedor: Joana Bravo - {0} votos , branco - {1} votos, nulo - {2} votos",joana,branco,nulo);
      return 0;
    }

    if (roberto > jose && roberto>joana){
      Console.WriteLine("Vencedor: Roberto Nove - {0} votos , branco - {1} votos, nulo - {2} votos",roberto,branco,nulo);
      return 0;
    }
    else{
      Console.WriteLine("Empate na votação, refazer");
      return 0;
    }
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