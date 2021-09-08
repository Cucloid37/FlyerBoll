using Vector3 = UnityEngine.Vector3;

namespace MVC.Model
{
    public interface IFieldCoordinates
    {
        Coordinates myCoordinates { get; set; }
        Vector3 myPosition { get; }

    }
}