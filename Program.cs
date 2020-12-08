using System;
using POO_Encapsulamento.classes;

namespace POO_Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            MasterCard m = new MasterCard();

            m.Parcelas = 12;
            m.Cvv = "12345";
            m.Numero = "113355";
            
            //só o get
            Console.WriteLine($"Bandeira: {m.Bandeira}");
            Console.WriteLine($"Limite: {m.LimiteDeCompra}");
            Console.WriteLine($"Token: {m.Token}");
            
            //get e set
            Console.WriteLine($"Parcelas: {m.Parcelas}");
            Console.WriteLine($"CVV: {m.Cvv}");
            Console.WriteLine($"Número: {m.Numero}");


        }//main
    }
}
