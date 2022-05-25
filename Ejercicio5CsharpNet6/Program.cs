Console.Write("Ingrese un numero entero para determinar la longitud del vector: ");
int longitudVector = int.Parse(Console.ReadLine());

int[] vector = new int[longitudVector];
Random random = new Random();

Console.Write($"Los números del vector son: ");
for (int i = 0; i < vector.Length; i++)
{
    vector[i] = random.Next(100);
    Console.Write($"{vector[i]} ");
}

int aux;
int contador = 1;
for (int i = 0; i < (vector.Length/2); i++)
{
    aux = vector[vector.Length - contador];
    vector[vector.Length - contador] = vector[i];
    vector[i] = aux;
    contador++;
}

Console.WriteLine();
Console.Write($"El nuevo orden del vector es: ");
for (int i = 0; i < vector.Length; i++)
{
    Console.Write($"{vector[i]} ");
}
