namespace MVC.Model
{
    public interface ICharacteristicsFlyers : IActionPoints
    {
        int force { get; }
        int agity { get; }
        int magicForce { get; }
        
        float factorSpeed { get; }
        float factorHieght { get; }
        float factorDiagonale { get; }
    }
}