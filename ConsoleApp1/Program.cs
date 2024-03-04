double[] vet1 = new double[5];
double[] vet2 = new double[5];
string? n;

for (int i = 0; i < vet1.Length; i++)
{
    Console.Write((i+1) + "º valor do vet1: ");
    n = Console.ReadLine();
    Double.TryParse(n, out vet1[i]);

}

for (int i = 0; i < vet2.Length; i++)
{
    Console.Write((i + 1) + "º valor do vet2: ");
    n = Console.ReadLine();
    Double.TryParse(n, out vet2[i]);

}

for (int i = 0; i < vet1.Length; i++)
{
    Console.WriteLine("Soma dos " + (i +1)+ "º valores: " + (vet1[i] + vet2[i]));
    Console.WriteLine("Diferença dos " + (i+1) + "º valores: " + (vet1[i] - vet2[i]));
    Console.WriteLine("Produto dos " + (i+1) + "º valores: " + (vet1[i] * vet2[i]));
    Console.WriteLine("Divisão dos " + (i+1) + "º valores: " + (vet1[i] / vet2[i]));
    Console.WriteLine();
}