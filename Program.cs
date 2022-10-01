int n1, n2, resto;



Console.WriteLine("");

Console.WriteLine("Múltiplo");

Console.WriteLine("");



Console.Write("primeiro numero: ");

n1 = Convert.ToInt32(Console.ReadLine());



Console.Write("segundo número: ");

n2 = Convert.ToInt32(Console.ReadLine());



resto = n1 % n2;

bool ehMultiplo = (resto == 0);



if (resto == 0)

{

    Console.WriteLine($"{n1} é multiplo de {n2}");

}

else

{

Console.WriteLine($"{n1} não é multiplo de {n2}");

}


