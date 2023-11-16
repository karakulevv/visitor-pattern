using VisitorPattern.Interfaces;
using VisitorPattern.Models;

namespace VisitorPattern;

class Program
{
    static void Main(string[] args)
    {
        List<Exhibit> exhibits = new List<Exhibit>
        {
            new Painting(),
            new Sculpture(),
            new Artifact()
        };

        TourGuide artEnthusiast = new ArtEnthusiast();
        TourGuide historian = new Historian();

        // Each exhibit accepts different types of visitors (TourGuide)
        foreach (var exhibit in exhibits)
        {
            exhibit.Accept(artEnthusiast);
            exhibit.Accept(historian);
        }
    }
}