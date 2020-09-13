using System;

class MainClass {
  public static void Main (string[] args) {
  
   Pessoas murilo = new Pessoas();

   murilo.Cadastro("Murilo", 10, 30, 1.2);
   murilo.Dados();
   murilo.Engordar(42.9);
   murilo.Envelhecer(22);
   Console.WriteLine("____________________");
   murilo.Dados();
   Console.WriteLine("____________________");
   murilo.Emagrecer(10);
   murilo.Envelhecer(23);
   murilo.Crescer(0.05);
   murilo.Dados();
  }
}