Console.Clear();

double altura, pesoideal;
string sexo;


Console.Write("digite sua altura: ");
altura = Convert.ToDouble(Console.ReadLine());

Console.Write("digite seu sexo: ");
sexo = Console.ReadLine()!.ToLower();

if (sexo == "m")
{
    pesoideal = altura *72.7 - 58.0;
}
else

pesoideal = altura *62.1-44.7;
    

Console.WriteLine($"seu peso ideal é {pesoideal:N1} kg.");