using System;

class Pessoas{
 private int idade;
 private double peso;
 private double altura;
 private string nome;

public void Cadastro(string n, int i, double p, double a) {
    idade = i;
    peso = p;
    altura = a;
    nome = n;
}

public void Envelhecer (int idade_new){
  if (idade < 21){
      int aux=((idade_new-idade)-(idade_new-21));
      for (int i = 0; i < aux; i++) {
        Crescer(0.05); 
      }
    }
    if (idade < idade_new)
      idade = idade_new;

}

public void Engordar(double var_peso) {
  peso=peso+var_peso;
}

public void Emagrecer (double var_peso){
  peso=peso-var_peso;
}

public void Crescer(double var_altura) {
  altura=altura+var_altura;
}

public void Dados() { 
    Console.WriteLine("Nome: {0}\nIdade: {1}\nPeso: {2}\nAltura: {3}", nome, idade, peso, altura);
  }

}