double peso, altura, imcNovo;
string diagnostico;

Console.WriteLine("-- Calculadora de IMC --\n");

Console.Write("Digite seu peso em kg...: ");
peso = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite sua altura em m..: ");
altura = Convert.ToDouble(Console.ReadLine());


imcNovo = peso * 1.3 / Math.Pow(altura, 2.5);


if(imcNovo < 17)
{
    diagnostico = "Muito abaixo do peso";
}
else if(imcNovo >= 17 && imcNovo <= 18.49) 
{
    diagnostico = "Abaixo do peso";
}
else if(imcNovo >= 18.50 && imcNovo  <= 24.99)
{
    diagnostico = "Peso normal";
}
else if(imcNovo >= 25 && imcNovo  <= 29.99)
{
    diagnostico = "Acima do peso";
}
else if(imcNovo >= 30 && imcNovo  <= 34.99)
{
    diagnostico = "Obesidade I";
}
else if(imcNovo >= 35 && imcNovo  <= 39.99)
{
    diagnostico = "Obesidade II (severa)";
}
else
{
    diagnostico = "Obesidade III (mórbida)";
}


Console.WriteLine($"\nSeu IMC é {imcNovo:N2} kg/m².");
Console.WriteLine($"Diagnóstico: {diagnostico}");

