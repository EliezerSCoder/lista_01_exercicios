/*
 6. Classificação de Notas
o Objetivo: Aprender a usar múltiplas condições em uma estrutura de 
decisão.
o Descrição: Crie um programa que peça a nota de um aluno e classifique a 
nota em categorias: "Excelente" (nota >= 9), "Boa" (7 <= nota < 9), "Regular" 
(5 <= nota < 7) e "Baixa" (nota < 5). Exiba a classificação na tela.
o Exemplo de Saída: "Excelente", "Boa", "Regular" ou "Baixa"*/
Console.WriteLine(" digite sua nota:");
float n1 = float.Parse(Console.ReadLine());
if (n1 >= 9)
{
    Console.WriteLine("excelente");
}
else if (n1 > 7)
{
    Console.WriteLine("boa");
}
else if (n1 >= 5)
{
    Console.WriteLine("Regular");

}
else
    Console.WriteLine("Baixa");