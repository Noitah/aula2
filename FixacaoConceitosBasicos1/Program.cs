
/*
 * As classes a serem dsenvolvidas devem atender aos seguintes requisitos:
 * - Devem estar na pasta Model
 * - Para a classe SomaDoisNumeros, deve-se criar um método estático chamado Somar que recebe dois inteiros e retorna a soma deles
 * - Para a classe MetrosMilimetros, deve-se criar um método estático chamado Converter que recebe um double e retorna o valor em milímetros
 * - A  classe CalculaAumento deve ter um método estático chamado Calcular que recebe um double salario e um double aumento e retorna o valor do salário com o aumento aplicado
 * A classe CalculaDesconto deve ter um método estático chamado Calcular que recebe um double valor e um double desconto e retorna o valor com o desconto aplicado
 * - A classe CalculaAluguelCarro deve ter um método estático chamado Calcular que recebe um int dias, um int quilometragemInicial, um int quilometragemFinal e retorna o valor total do aluguel
 */
//Primeira tarefa realizada

using System;
using FixacaoConceitosBasicos1.Model;
using FixacaoConceitosBasicos1.Model.Model;

/*
* Escolha uma opção:
* [0] - Sair
* [1] - Somar dois números
* [2] - Converter metros para milímetros
*
*/

bool continuar = true;
while (continuar) { 


try
{
    Console.WriteLine("Informe o primeiro valor: ");
    int num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe o segundo valor: ");
    int num2 = int.Parse(Console.ReadLine());
    SomaDoisNumeros somador = new SomaDoisNumeros();
    Console.WriteLine(SomaDoisNumeros.Somar(num1, num2));
        continuar = false; 
}

catch(Exception)
{
    Console.WriteLine("Por Favor, informe um valor valido");
    

}
    Console.WriteLine("Informe o valor a ser convertido: ");
    int mm = int.Parse(Console.ReadLine());
    Console.WriteLine(MetrosMilimetros.Converter(mm));

}