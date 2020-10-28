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
    Console.WriteLine("Digite o seu nome, por favor e a senha");
    MudaNome = Console.ReadLine();
    password = int.Parse(Console.ReadLine());
    cliente.MudaNome(MudaNome, password);
    Console.WriteLine("Digite o seu endereço, por favor");
    endereço = Console.ReadLine();
    cliente.MudaEndereco(endereço, password);
    Console.WriteLine("Digite o seu telefone, por favor");
    telefone = double.Parse(Console.ReadLine());
    cliente.MudaTelefone(telefone, password);

    for(int i=0; estoque.Produtos.Count;i++){
      Console.WriteLine("Produto{0}, Valor{1}, Quantidade em estoque{2}", estoque.Produtos[i], estoque.Preco[i], estoque.Quantidade[i]);
    }


    ListaDeProdutos = new string[] { "arroz", "feijao", "carne" };
    PrecoProdutos = new double[] { 20,7,25 };
      for (int i=0;i<3;i++){
      Console.WriteLine("Produto {0} - Preço {1}",ListaDeProdutos[i],PrecoProdutos[i]);
      }
      
  //instanciação do obj carrinho
  Carrinho CarrinhoCliente = new Carrinho();
  while (continuar == "S"){
    Console.WriteLine("Digite a posição do produto na tabela de produtos, inicia-se por zero");
    PosProduto = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite a quantidade");
    qtd = int.Parse(Console.ReadLine());
    CarrinhoCliente.CompraProduto(ListaDeProdutos[PosProduto], PrecoProdutos[PosProduto], qtd);
    Console.WriteLine("\nPara continuar fazendo compras digite S, para sair digite N");
    continuar = Console.ReadLine();
  }
  Console.WriteLine("Deseja saber o valor total do seu carrinho? Se sim digite S, se não, digite N");
  CheckTotal= Console.ReadLine();
  if (CheckTotal == "S"){
     Console.WriteLine(CarrinhoCliente.CarrinhoTotal());
  }
  // para calcular o valor de algum produto
  Carrinho.ProdutoPreco(20,4);
    
    }

  }