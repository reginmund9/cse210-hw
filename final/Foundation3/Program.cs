using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("Marquez Street ", "Cochabamba", "Cochabamba", "Bolivia");

        Lecture lecture = new Lecture("Literary Reading: 'Lithium Congress'", "IWLIME International Workshop on Lithium", "November, 2023", "8 AM", address, "Jaime Antezana", 80);
        Console.WriteLine();

        Console.WriteLine("Event: 1");
        Console.WriteLine();
        Console.WriteLine(lecture.GetStandard());

        Console.WriteLine();
        Console.WriteLine(lecture.DetailedLecture());

        Console.WriteLine();
        Console.WriteLine(lecture.ShortLecture());

        Address addressR = new Address("Ballivian Street", "Sucre", "Chuquisaca", "Bolivia");

        Reception reception = new Reception("International Conference", "Nano science and Nanotechnology", "December 10, 2023", "10 AM", addressR, "info@conferencefora.org");
        Console.WriteLine();

        Console.WriteLine("Event: 2");
        Console.WriteLine();
        Console.WriteLine(reception.GetStandard());

        Console.WriteLine();
        Console.WriteLine(reception.DetailedReception());

        Console.WriteLine();
        Console.WriteLine(reception.ShortReception());

        Address addressOG = new Address("Cristiania y Maciel Avenue", "La Paz", "La Paz", "Bolivia");

        OutdoorGathering outdoorGathering = new OutdoorGathering("Alasitas Festival", "Ekeko, Aymara god of abundance ", "January 24, 2024", "8 AM", addressOG, "fresh");
        Console.WriteLine();

        Console.WriteLine("Event: 3");

        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GetStandard());

        Console.WriteLine();
        Console.WriteLine(outdoorGathering.DetailedOutdoorGathering());

        Console.WriteLine();
        Console.WriteLine(outdoorGathering.ShortOutdoorGathering());
    }
}