using System;

namespace CalculadoraIMC
{
 public class Program
 {
  static void Main(string[] args)
  {
   Console.WriteLine(" Calculadora de IMC");

   Console.WriteLine("Digite seu peso em kg: ");
   double peso = Convert.ToDouble(Console.ReadLine());

   Console.WriteLine("Digite sua altra em metros: ");
   double altura = Convert.ToDouble(Console.ReadLine());

   double imc = peso / (altura * altura);
   Console.WriteLine($"O seu IMC é: {imc:F2}");

   // imc < 18,5 = abaixo do peso
    if (imc < 18.5){
        Console.WriteLine("Voce esta abaixo do peso");
    }
   // imc > = 18,5L e  imc < 24,9 = peso normal
   else if(imc >= 18.5 &&  imc < 24.9){
       Console.WriteLine("peso normal");
   }
   // imc >= 25 e imc < 29,9
   else if (imc >= 25 && imc < 29.9) {
    Console.WriteLine("Você está acima do peso");
   }
   // imc >= 29,9 = obesidade
   else{
     Console.WriteLine("Obesidade");
   } 
  }
 }
}