namespace AnimalKingdom
{
    public class Bat : Animal
    {
        public int NumberOfWings { get; } = 2;
        public int NumberOfNipples { get; } = 2;
        public override string Sound()
        {
            return base.Sound() + "ti ti ti ti ti";
        }
    }
}