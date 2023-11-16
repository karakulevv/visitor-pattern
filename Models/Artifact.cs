using VisitorPattern.Interfaces;

namespace VisitorPattern.Models;

// Concrete Element
public class Artifact : Exhibit
{
    public void Accept(TourGuide visitor)
    {
        visitor.VisitArtifact(this);
    }
}