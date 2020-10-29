using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    double telefone;
    string endereço, continuar="S",MudaNome;
    int PosProduto, qtd, password, opPag;
    Loja estoque = new Loja();

    //instanciando o cliente
    Cliente cliente = new Cliente();
    Console.Write("Digite o seu nome >> ");
    MudaNome = Console.ReadLine();
    Console.Write("Digite a senha >> ");
    password = int.Parse(Console.ReadLine());
    cliente.MudaNome(MudaNome, password);
    Console.Write("Digite o seu endereço, por favor \nRua e numero da residencia >> ");
    endereço = Console.ReadLine();
    cliente.MudaEndereco(endereço, password);
    Console.Write("Digite o seu telefone, por favor >> ");
    telefone = double.Parse(Console.ReadLine());
    cliente.MudaTelefone(telefone, password);

    for(int i=0; i<estoque.Produtos.Count;i++){
      Console.WriteLine("{0} - ID {3}\n R${1}\n Disponibilidade {2}\n\n", estoque.Produtos[i], estoque.Preco[i], estoque.Quantidade[i], i);
    }
      
  //instanciação do obj carrinho
  Carrinho CarrinhoCliente = new Carrinho();
  while (continuar == "S" ^ continuar == "s"){
    Console.Write("Digite o ID do produto na tabela de produtos >> ");
    PosProduto = int.Parse(Console.ReadLine());
    Console.Write("Digite a quantidade >> ");
    qtd = int.Parse(Console.ReadLine());
      while (qtd > estoque.Quantidade[PosProduto]){
        if(qtd > estoque.Quantidade[PosProduto] || qtd == 0){
          Console.WriteLine("Quantidade invalida\n. Quantidade disponivel em estoque {0}", estoque.Quantidade[PosProduto]);
          Console.Write("Digite a quantidade >> ");
          qtd = int.Parse(Console.ReadLine());
          if (estoque.Quantidade[PosProduto]==0){
            Console.WriteLine("Produto Indisponivel");
          }
        }else{
          break;
        }
      }
      estoque.Quantidade[PosProduto]=estoque.Quantidade[PosProduto]-qtd;
    CarrinhoCliente.CompraProduto(estoque.Produtos[PosProduto], estoque.Preco[PosProduto], qtd);
    Console.WriteLine("\n-------------------------------------------------------------------------");
    Console.Write("\nPara continuar fazendo compras digite S, para sair digite N >> ");
    continuar = Console.ReadLine();
  }
  //Console.WriteLine("Esse é o valor total do seu carrinho: ");
  //CheckTotal= Console.ReadLine();
  double totalCar = CarrinhoCliente.CarrinhoTotal();
  //if (CheckTotal == "S" ^ CheckTotal == "s"){
  Console.Write(totalCar);
  
  Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
  
  Console.Write("Irá finalizar a compra? (s ou n) >> ");
  
  string finalCompra= Console.ReadLine();
  
  if (finalCompra == "S" ^ finalCompra == "s"){
    //Instanciando Pagamento
    Pagamento PagamentoCliente = new Pagamento();
    
    opPag = PagamentoCliente.Pagar();
    if (opPag == 1){
      Console.WriteLine ("OK! Dinheiro, né?! ");
    while (opPag == 1){
      //Cliente entrega o valor
      // Console.Write("Vai precisar de troco? (S ou N) >>> ");
      // char opTroco = char.Parse(Console.ReadLine()); 
      // if (opTroco == 'S' ^ opTroco == 's'){
        Console.Write("Valor entregue >> ");
        double valorEntregue = double.Parse(Console.ReadLine());
        if(valorEntregue < totalCar){
          Console.WriteLine("Senhor, o valor é insuficiente, o total do seu carrinho é {0}", totalCar);
        }else{
        Console.WriteLine("O seu troco é de R$ {0} ",valorEntregue - totalCar);
        Console.WriteLine("Tenha um ótimo dia!!");
        break;
        }
      // }
      // else{
      //   Console.WriteLine("OK! Tenha um ótimo dia, sr(a)");
      //   break;
      // }
    }
  }
    if (opPag == 2){
      Console.WriteLine("Só escolher uma das chaves abaixo:");
      Console.Write("Chave aleatória: "); 
      Console.WriteLine(PagamentoCliente.GerarChaveAleat());
      Console.WriteLine("Telefone: 279999988888 \nE-mail: comerciocapixaba@gmail.com \nCPF: 193.839.850-54\n ");
      Console.WriteLine("Obrigado! Tenha um ótimo dia!");
    }
  }
  else{
    Console.WriteLine(".");
  }
/*
  //Instanciando pagamento
  Pagamento PagamentoCliente = new Pagamento();
  
  opPag = PagamentoCliente.Pagar();

  if (opPag == 1){
    Console.WriteLine ("OK! Dinheiro, né?! ");
    //Cliente entrega o valor
    Console.Write("Vai precisar de troco? (S ou N) >>> ");
    char opTroco = char.Parse(Console.ReadLine()); 
    if (opTroco == 'S' ^ opTroco == 's'){
      Console.Write("Valor entregue >> ");
      double valorEntregue = double.Parse(Console.ReadLine());
      Console.WriteLine("Aqui o seu troco R$ {0} ",valorEntregue - totalCar);
      Console.WriteLine("Tenha um ótimo dia!!");
    }
    else{
      Console.WriteLine("OK! Tenha um ótimo dia, sr(a)");
    }
  }
  else if (opPag == 2){
    Console.WriteLine("Só escolher uma das chaves abaixo:");
    Console.Write("Chave aleatória: "); 
    Console.WriteLine(PagamentoCliente.GerarChaveAleat());
    Console.WriteLine("Telefone: 279999988888 \nE-mail: comerciocapixaba@gmail.com \nCPF: 193.839.850-54\n ");
    Console.WriteLine("Obrigado! Tenha um ótimo dia!");
  }

    


*/
    }

  }

