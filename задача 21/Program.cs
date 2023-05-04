// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53



int ReadInt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());

}

int[] coordsA = new int[2];
coordsA[0] = ReadInt("Введите координату Х точки A");
coordsA[1] = ReadInt("Введите координату Y точки А");
coordsA[2] = ReadInt("Введите координату Z точки А");

int[] coordsB = new int[2];
coordsA[0] = ReadInt("Введите координату Х точки B");
coordsA[1] = ReadInt("Введите координату Y точки B");
coordsA[2] = ReadInt("Введите координату Y точки B");

double distance = Math.Sqrt(Math.Pow(coordsA[0] - coordsB[0], 2) + Math.Pow(coordsA[1] - coordsB[1], 2) + Math.Pow(coordsA[2] - coordsB[2], 2));

System.Console.WriteLine(Math.Round(distance, 3));