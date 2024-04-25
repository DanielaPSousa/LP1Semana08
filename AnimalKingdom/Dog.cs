namespace AnimalKingdom
{
    public class Dog : Animal
    {
        public int NumberOfNipples { get; } = 8;
        public override string Sound()
        {
            return base.Sound() + "Woof!";
        }
    }
}
