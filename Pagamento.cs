using System;
using System.Collections.Generic;

class Pagamento{
  private int tipo;


  public int Pagar(){
    Console.WriteLine("Qual será a forma de pagamento, sr(a)?");
    Console.Write("1 - dinheiro, 2 - PIX >>> ");
    int t = int.Parse(Console.ReadLine());
    tipo = t;
    
    return tipo;
    }

  //class GerarChaveAleatPIX {
  public string GerarChaveAleat() {
  // Gera uma senha com 6 caracteres entre números e letras
  string chars = "abcdefghjkmnpqrstuvwxyz023456789";
  string pass = "";
  Random random = new Random();
  for (int f = 0; f < 15; f++) {
    pass = pass + chars.Substring(random.Next(0, chars.Length-1), 1);
  }
  string chaveA = pass;
  return chaveA;
  }  
}
