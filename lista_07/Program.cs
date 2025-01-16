/*
 * 7. Comparação de Números
o Objetivo: Praticar a comparação entre variáveis.
o Descrição: Escreva um programa que solicita dois números ao usuário e 
determina qual deles é maior. Utilize if, else if e else para exibir a mensagem 
adequada.
o Exemplo de Saída: "O primeiro número é maior.", "O segundo número é 
maior." ou "Os números são iguais.*/
Console.WriteLine("Digite seu primeiro numero");
int numero1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite seu segundo numero");
int numero2 = int.Parse(Console.ReadLine());
if (numero1 > numero2)
{
    Console.WriteLine("primeiro numero é maior que o segundo");
}
else if (numero2 > numero1)
{
    Console.WriteLine("Segundo numero maior que o primeiro");
}
else
{
    Console.WriteLine("Os numeros são iguais");
}