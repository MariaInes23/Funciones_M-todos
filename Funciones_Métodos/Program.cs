using System.ComponentModel;

static void Saludar(string nombre, int carne, string facultad)
{
    Console.WriteLine("Hola, soy " + nombre);
    Console.WriteLine("Mi número de Carné es: " + carne);
    Console.WriteLine("Pertenezco a la siguiente facultaa: " + facultad);

}

// Las llaves y la flecha son los mismo => y {}
// Es necesatio enviar información si añadimos parametros, si no va a tirar error fijo
// \n = salto de lína
static void Despedir() => Console.WriteLine("Adios, que tenga un buen día");



Saludar("Inés", 1544424, "Ingeniería");
Console.WriteLine();
Despedir();

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

//Llamada o invocación es lo mismo

static int OperaciónSuma1(int numeroUno, int numeroDos)
{
    return numeroUno + numeroDos;
}

Console.WriteLine(OperaciónSuma1(5, 2));

//Métodos con parametros opcionales, le añadimos un valor nulo al numeroTres por lo que no afecta si ingresamos o no al devolver el valor
static int OperaciónSuma2(int numeroUno, int numeroDos, int numeroTres = 0)
{
    return numeroUno + numeroDos + numeroTres;
}

Console.WriteLine(OperaciónSuma2(5, 2));


Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

//Polimorfismo: que varios metodos o funciones tienen el mismo nombre, pero tienen distintas funcionalidades
// A esto se le llama sobrecarga 

static int Sumar(int numero1, int numero2)
{
    return numero1 + numero2;
}

static int Sumar(int numero1, int numero2, int numero3)
{
    return numero1 + numero2 + numero3;
}

Console.WriteLine(Sumar(5, 5, 5, 6));
Console.ReadLine();