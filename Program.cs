using System;
using System.Text;

// Налаштування мови
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("=== Лабораторна робота №3 (Варіант 5) ===");
Console.Write("Введіть кількість векторів: ");

if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
{
    Vector[] vectors = new Vector[n];

    for (int i = 0; i < n; i++)
    {
        Console.WriteLine($"\nВектор #{i + 1}");
        Console.Write("X: ");
        double x = double.Parse(Console.ReadLine() ?? "0");
        Console.Write("Y: ");
        double y = double.Parse(Console.ReadLine() ?? "0");

        vectors[i] = new Vector(x, y);
    }

    Vector maxV = vectors[0];
    foreach (var v in vectors)
    {
        if (v.CalculateLength() > maxV.CalculateLength())
            maxV = v;
    }

    Console.WriteLine($"\nНайдовший вектор: ({maxV.X}, {maxV.Y})");
    Console.WriteLine($"Довжина: {maxV.CalculateLength():F2}");
}

public class Vector
{
    private double _x; // Поля для інкапсуляції
    private double _y;

    public double X { get => _x; set => _x = value; }
    public double Y { get => _y; set => _y = value; }

    public Vector(double x, double y)
    {
        _x = x;
        _y = y;
    }

    public double CalculateLength() => Math.Sqrt(_x * _x + _y * _y);
}