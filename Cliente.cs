using System;
using System.Collections.Generic;

class Cliente{
  string Nome;
  string Endereco;
  double Telefone;
  double Acesso=123456;


  //SET
 public void MudaNome(string n, int senha){
    //RN RESTRITIVA - ACESSO
    if (senha == Acesso) {
       Nome = n;
    }  
    else{
      Console.WriteLine("Acesso Negado");
    }
  }
  public void MudaEndereco(string n, int senha){
    //RN RESTRITIVA - ACESSO
    if (senha == Acesso) {
       Endereco = n;
    }  
    else{
      Console.WriteLine("Acesso Negado");
    }
  }
  public void MudaTelefone(double c, int senha){
    //RN RESTRITIVA - ACESSO
    if (c > 0 && senha == Acesso) {
       Telefone = c;
    }  
    else{
      Console.WriteLine("Valor Inválido");
    }
  }
//GET
  public string RetornaNome(){
       return Nome;
  }
  //GET
  public string RetornaEndereco(){
       return Endereco;
  }
  //GET
  public double RetornaTelefone(){
       return Telefone;
  }

}