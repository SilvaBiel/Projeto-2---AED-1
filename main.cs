using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    double total = 0, telefone;
    string nome, endereço, continuar="S", CheckTotal, MudaNome, MudaEndereco;
    int PosProduto, qtd, password;
    double[] PrecoProdutos;
    string[] ListaDeProdutos;
    Loja estoque = new Loja();

    //instanciando o cliente
    Cliente cliente = new Cliente();
    Console.WriteLine("Digite o seu nome e a senha");
    MudaNome = Console.ReadLine();
    password = int.Parse(Console.ReadLine());
    cliente.MudaNome(MudaNome, password);
    Console.WriteLine("Digite o seu endereço, por favor \n Rua e numero da residencia");
    endereço = Console.ReadLine();
    cliente.MudaEndereco(endereço, password);
    Console.WriteLine("Digite o seu telefone, por favor");
    telefone = double.Parse(Console.ReadLine());
    cliente.MudaTelefone(telefone, password);

    for(int i=0; i<estoque.Produtos.Count;i++){
      Console.WriteLine("{0} - ID {3}\n R${1}\n Disponibilidade {2}\n\n", estoque.Produtos[i], estoque.Preco[i], estoque.Quantidade[i], i);
    }
      
  //instanciação do obj carrinho
  Carrinho CarrinhoCliente = new Carrinho();
  while (continuar == "S"){
    Console.WriteLine("Digite o ID do produto na tabela de produtos");
    PosProduto = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite a quantidade");
    qtd = int.Parse(Console.ReadLine());
      while (qtd > estoque.Quantidade[PosProduto]){
        if(qtd > estoque.Quantidade[PosProduto] || qtd == 0){
          Console.WriteLine("Quantidade invalida");
          Console.WriteLine("Digite a quantidade");
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
    Console.WriteLine("\nPara continuar fazendo compras digite S, para sair digite N");
    continuar = Console.ReadLine();
  }
  Console.WriteLine("Deseja saber o valor total do seu carrinho? Se sim digite S, se não, digite N");
  CheckTotal= Console.ReadLine();
  if (CheckTotal == "S"){
     Console.WriteLine(CarrinhoCliente.CarrinhoTotal());
  }
    
    }

  }