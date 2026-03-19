using ShapesApp.Models;

namespace ShapesApp.Factories
{
    public interface IFigureFactory
    {
        Circle CreateCircle();
        Square CreateSquare();
        Triangle CreateTriangle();
    }
}