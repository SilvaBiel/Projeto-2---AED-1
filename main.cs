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
    Console.Write("Digite o seu endereço, por favor \nRua e número da residência >> ");
    endereço = Console.ReadLine();
    cliente.MudaEndereco(endereço, password);
    Console.Write("Digite o seu telefone, por favor >> ");
    telefone = double.Parse(Console.ReadLine());
    Console.Clear();
    cliente.MudaTelefone(telefone, password);

    for(int i=0; i<estoque.Produtos.Count;i++){
      Console.WriteLine("{0} - ID {3}\n R${1}\n Disponibilidade {2}\n\n", estoque.Produtos[i], estoque.Preco[i], estoque.Quantidade[i], i);
    }
      
  //instanciação do obj carrinho
  Carrinho CarrinhoCliente = new Carrinho();
  while (continuar == "S" ^ continuar == "s"){
    Console.Write("Digite o ID do produto na tabela de produtos >> ");
    PosProduto = int.Parse(Console.ReadLine());
    while(PosProduto >= estoque.Produtos.Count){
      Console.Write("ID inválido.\n Digite o ID do produto na tabela de produtos >> ");
      PosProduto = int.Parse(Console.ReadLine());
      if(PosProduto <= estoque.Produtos.Count){
        break;
      }
    }
    Console.Write("Digite a quantidade >> ");
    qtd = int.Parse(Console.ReadLine());
      while (qtd > estoque.Quantidade[PosProduto]){
        if(qtd > estoque.Quantidade[PosProduto] || qtd == 0){
          Console.WriteLine("Quantidade inválida.\nQuantidade disponível em estoque {0}",estoque.Quantidade[PosProduto]);
          Console.Write("Digite a quantidade >> ");
          qtd = int.Parse(Console.ReadLine());
          if (estoque.Quantidade[PosProduto]==0){
            Console.WriteLine("Produto Indisponível! ");
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

  double totalCar = CarrinhoCliente.CarrinhoTotal();
  Console.Write(totalCar);
  
  Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
  
  Console.Write("Irá finalizar a compra? (s ou n) >> ");
  
  string finalCompra= Console.ReadLine();
  Console.Clear();
  if (finalCompra == "S" ^ finalCompra == "s"){
    //Instanciando Pagamento
    Pagamento PagamentoCliente = new Pagamento();
    
    opPag = PagamentoCliente.Pagar();
    if (opPag == 1){
      Console.WriteLine ("OK! Dinheiro, né?! ");
      while (opPag == 1){
        //Cliente entrega o valor
        Console.Write("Valor entregue >> ");
        double valorEntregue = double.Parse(Console.ReadLine());
        if(valorEntregue < totalCar){
          Console.WriteLine("Senhor, o valor é insuficiente, o total do seu carrinho é {0}", totalCar);
        }else{
          Console.WriteLine("O seu troco é de R$ {0} ",valorEntregue - totalCar);
          Console.WriteLine("Tenha um ótimo dia!!");
          break;
        }
    }
  }
    if (opPag == 2){
      Console.WriteLine("Só escolher uma das chaves abaixo:");
      Console.WriteLine("");
      Console.Write("Chave aleatória: "); 
      Console.WriteLine(PagamentoCliente.GerarChaveAleat());
      Console.WriteLine("Telefone: 279999988888 \nE-mail: comerciocapixaba@ccapixaba.com \nCPF: 193.839.850-54\n ");
      Console.WriteLine("Obrigado! Tenha um ótimo dia!");
    }
  }
  else{
    Console.WriteLine(".");
  }


  
  }

}

