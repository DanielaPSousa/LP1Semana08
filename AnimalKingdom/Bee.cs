namespace AnimalKingdom
{
    public class Bee : Animal
    {
        public int NumberOfWings { get; } = 4;
        public override string Sound()
        {
            return base.Sound() + "Bzz";
        }
    }
}