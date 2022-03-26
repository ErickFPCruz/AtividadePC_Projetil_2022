Console.Clear();

const double gravidade = 9.80665;
double anguloGraus, velocidadeInicial, anguloRad, alcance, alturaMax;

Console.Write("Insira a velocidade inicial (em metros/segundo): ");
velocidadeInicial = Convert.ToDouble(Console.ReadLine());

Console.Write("Insira o ângulo (em graus): ");
anguloGraus = Convert.ToDouble(Console.ReadLine());

anguloRad = (anguloGraus * Math.PI)/180;

Console.WriteLine();

alturaMax = (Math.Pow(velocidadeInicial * Math.Sin(anguloRad), 2))/(2 * gravidade);
Console.Write($"Altura Máxima = {alturaMax:N2}");

Console.WriteLine();

alcance = (Math.Pow(velocidadeInicial, 2) * Math.Sin(2 * anguloRad))/gravidade;
Console.Write($"Alcance = {alcance:N2}");

Console.WriteLine();

//Isso é tudo pessoal!!!!! Até a próxima conta!!!!!