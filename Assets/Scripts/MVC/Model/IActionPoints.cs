namespace MVC.Model
{
    public interface IActionPoints
    {
        float actionPoints { get; }

        void ChangeActionPoints(float value);
    }

}