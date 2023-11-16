using VisitorPattern.Interfaces;

namespace VisitorPattern.Models;

// Concrete Element
public class Painting : Exhibit
{
    public void Accept(TourGuide visitor)
    {
        visitor.VisitPainting(this);
    }
}