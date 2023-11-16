using VisitorPattern.Interfaces;

namespace VisitorPattern.Models;

//Concrete Visitor
public class Historian : TourGuide
{
    public void VisitPainting(Painting painting)
    {
        Console.WriteLine("Historian is analyzing the historical context of the painting.");
    }

    public void VisitSculpture(Sculpture sculpture)
    {
        Console.WriteLine("Historian is studying the cultural significance of the sculpture.");
    }

    public void VisitArtifact(Artifact artifact)
    {
        Console.WriteLine("Historian is researching the origins of the artifact.");
    }
}