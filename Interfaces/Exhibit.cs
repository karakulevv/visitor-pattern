namespace VisitorPattern.Interfaces;

// Element Interface (Exhibit)
public interface Exhibit
{
    void Accept(TourGuide visitor);
}