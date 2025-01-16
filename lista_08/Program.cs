/*
 8. Verificação de Votação
o Objetivo: Compreender a lógica de permissões baseadas em condições.
o Descrição: Crie um programa que pergunte a idade de uma pessoa e 
determine se ela pode votar (idade >= 16). Utilize uma condição if para exibir 
a mensagem correspondente.
o Exemplo de Saída: "Você pode votar." ou "Você não pode votar.
*/
Console.WriteLine("qual sua idade?");
int idade = int.Parse(Console.ReadLine());  
if  (idade >= 16)
{
    Console.WriteLine("Voce pode votar");
    
}
else
{
    Console.WriteLine("Você não pode votar!");
    
}