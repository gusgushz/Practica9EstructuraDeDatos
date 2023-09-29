using System;

class Programa {
    static void Main () {
        int TM = 2; // TM = Tamaño Matriz
        double[,] matrizA = new double[TM,TM];
        double[,] matrizB = new double[TM,TM];
        
        Console.WriteLine("Escriba los 4 numeros para la matriz A");
        for (int i = 0; i < TM; i++)
        {
            for (int j = 0; j < TM; j++)
            {
                matrizA[i,j] = double.Parse(Console.ReadLine()!);
            }
        }
        Console.WriteLine("Escriba los 4 numeros para la matriz B");
        for (int i = 0; i < TM; i++)
        {
            for (int j = 0; j < TM; j++)
            {
                matrizB[i,j] = double.Parse(Console.ReadLine()!);
            }
        }

        CalculadoraMatriz gus = new();

        Console.WriteLine("Resultados de la Suma");
        double[,] matrizResultadoSuma = gus.Sumar(TM,matrizA,matrizB);
        for (int i = 0; i < TM; i++)
        {
            for (int j = 0; j < TM; j++)
            {
                Console.Write("{0} ", matrizResultadoSuma[i,j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("Resultados de la Resta");
        double[,] matrizResultadoResta = gus.Restar(TM,matrizA,matrizB);
        for (int i = 0; i < TM; i++)
        {
            for (int j = 0; j < TM; j++)
            {
                Console.Write("{0} ", matrizResultadoResta[i,j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("Resultados de la Multiplicación");
        double[,] matrizResultadoMulti = gus.Multiplicar(TM,matrizA,matrizB);
        for (int i = 0; i < TM; i++)
        {
            for (int j = 0; j < TM; j++)
            {
                Console.Write("{0} ", matrizResultadoMulti[i,j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("Resultados de la División");
        double[,] matrizResultadoDiv = gus.Dividir(TM,matrizA,matrizB);
        for (int i = 0; i < TM; i++)
        {
            for (int j = 0; j < TM; j++)
            {
                Console.Write("{0} ", Math.Round(matrizResultadoDiv[i,j],2).ToString("#.##"));
            }
            Console.WriteLine();
        }
    }
}
public class CalculadoraMatriz {
    public double[,] Sumar (int TM, double[,] matrizA, double[,] matrizB) {
        double[,] NuevaMatriz = new double [TM,TM];
        for (int i = 0; i < TM; i++)
        {
            for (int j = 0; j < TM; j++)
            {
                NuevaMatriz[i,j] = matrizA[i,j]+matrizB[i,j];
            }
        }
        return NuevaMatriz;
    }
    public double[,] Restar (int TM, double[,] matrizA, double[,] matrizB) {
        double[,] NuevaMatriz = new double [TM,TM];
        for (int i = 0; i < TM; i++)
        {
            for (int j = 0; j < TM; j++)
            {
                NuevaMatriz[i,j] = matrizA[i,j]-matrizB[i,j];
            }
        }
        return NuevaMatriz;
    }
    public double[,] Multiplicar (int TM, double[,] matrizA, double[,] matrizB) {
        double[,] NuevaMatriz = new double [TM,TM];
        for (int i = 0; i < TM; i++)
        {
            for (int j = 0; j < TM; j++)
            {
                NuevaMatriz[i,j] = matrizA[i,j]*matrizB[i,j];
            }
        }
        return NuevaMatriz;
    }
    public double[,] Dividir (int TM, double[,] matrizA, double[,] matrizB) {
        double[,] NuevaMatriz = new double [TM,TM];
        for (int i = 0; i < TM; i++)
        {
            for (int j = 0; j < TM; j++)
            {
                NuevaMatriz[i,j] = matrizA[i,j]/matrizB[i,j];
            }
        }
        return NuevaMatriz;
    }
}