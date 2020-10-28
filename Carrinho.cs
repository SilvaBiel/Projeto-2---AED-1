using System;
using System.Collections.Generic;

class Carrinho{
  private string Produto;
  private double Preco;
  private double ValorTotalDoCarrinho;
  public string[] ProdutosCarrinho;
//Lista os produtos no carrinho
  public void CompraProduto (string Produto, double valor, int qtd){
    Console.Write("Produtos escolhidos -> {0} {1}", qtd, Produto);
    // for (int i = 0; i<qtd; i++){
    //   ProdutosCarrinho = new string[15];
    //   ProdutosCarrinho[i]=Produto;
    //   //Console.Write(ProdutosCarrinho[i],",");
    // }
    ValorTotalDoCarrinho = (valor*qtd)+ValorTotalDoCarrinho;
    }

//Calcula o valor total de um item especifico
  public static void ProdutoPreco (double valor, int qtd){
    double PrecoTotalProduto;
    PrecoTotalProduto = valor*qtd;
    Console.WriteLine(PrecoTotalProduto);
    }
//Calcula o valor total de todos os itens no carrinho
  public double CarrinhoTotal (){
    Console.Write("Senhor(a), este é o total do carrinho ->");
    return ValorTotalDoCarrinho;
  }

}