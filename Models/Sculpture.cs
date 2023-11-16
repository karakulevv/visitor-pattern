using VisitorPattern.Interfaces;

namespace VisitorPattern.Models;

// Concrete Element
public class Sculpture : Exhibit
{
    public void Accept(TourGuide visitor)
    {
        visitor.VisitSculpture(this);
    }
}