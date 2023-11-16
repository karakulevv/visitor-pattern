using VisitorPattern.Interfaces;

namespace VisitorPattern.Models;

//Concrete Visitor
public class ArtEnthusiast : TourGuide
{
    public void VisitPainting(Painting painting)
    {
        Console.WriteLine("Art Enthusiast is admiring the painting.");
    }

    public void VisitSculpture(Sculpture sculpture)
    {
        Console.WriteLine("Art Enthusiast is examining the sculpture.");
    }

    public void VisitArtifact(Artifact artifact)
    {
        Console.WriteLine("Art Enthusiast is observing the artifact.");
    }
}