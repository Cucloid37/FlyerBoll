using UnityEngine;

namespace MVC.Model
{
    public sealed class FieldModel : MonoBehaviour, IFieldCoordinates
    {
        public Coordinates myCoordinates { get; set; }
        public Vector3 myPosition { get; }

        public FieldModel(Coordinates myCoordinates)
        {
            this.myCoordinates = myCoordinates;
            myPosition = gameObject.transform.position;
        }
    }
}
