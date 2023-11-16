using VisitorPattern.Models;

namespace VisitorPattern.Interfaces;

// Visitor Interface (TourGuide)
public interface TourGuide
{
    void VisitPainting(Painting painting);
    void VisitSculpture(Sculpture sculpture);
    void VisitArtifact(Artifact artifact);
}