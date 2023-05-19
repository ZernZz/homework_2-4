using System;
class MainClass {
    public static void Main (string[] args) {
        string[] inputs = Console.ReadLine().Split(' ');
        int N = int.Parse(inputs[0]);
        int K = int.Parse(inputs[1]);
        int[] population = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int maxCustomers = 0;
        for (int i = 0; i < N; i++) {
            int totalCustomers = 0;
            for (int j = Math.Max(0, i - K); j <= Math.Min(i + K, N - 1); j++) {
                totalCustomers += population[j];
            }
            maxCustomers = Math.Max(maxCustomers, totalCustomers);
        }
        Console.WriteLine(maxCustomers);
    }
}