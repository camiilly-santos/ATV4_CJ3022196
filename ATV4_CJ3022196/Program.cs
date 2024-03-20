int n1, n2,op, resultado;

Console.WriteLine("Digite o valor do primeiro número");
n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite  valor do segundo número");
n2 =int.Parse(Console.ReadLine());

Console.WriteLine("Digite 1 para adição");
Console.WriteLine("Digite 2 para subtração");
Console.WriteLine("Digite 3 para multiplicação");
Console.WriteLine("Digite 4 para divisão");
op = int.Parse(Console.ReadLine());


switch (op)
{

    case 1:
        resultado = n1 + n2;
       
        Console.WriteLine(resultado);
       
        break;
    case 2:
        resultado = n1 - n2;

        Console.WriteLine(resultado);
        break;
    case 3:

        resultado = n1 * n2;

        Console.WriteLine(resultado);


        break;
    case 4:
        resultado = n1 / n2;
        Console.WriteLine(resultado);   

        break;

}