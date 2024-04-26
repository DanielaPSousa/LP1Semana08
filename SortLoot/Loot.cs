using System;

namespace SortLoot
{
    public class Loot : IComparable<Loot>
    {
        /// <summary>Type of loot.</summary>
        public LootType Kind { get; }

        /// <summary>Loot description.</summary>
        public string Description { get; }

        /// <summary>Loot value.</summary>
        public float Value { get; }
        public override string ToString() =>
            $"[{Kind,15}]\t{Value:f2}\t{Description}";

        public Loot(LootType kind, string description, float value)
        {
            Kind = kind;
            Description = description;
            Value = value;
        }
        public int CompareTo(Loot other)
        {
            int valueComparison = other.Value.CompareTo(Value);
            if (valueComparison != 0)
                return valueComparison;

            int kindComparison = Kind.ToString().CompareTo(other.Kind.ToString());
            if (kindComparison != 0)
                return kindComparison;

            return string.Compare(Description, other.Description, StringComparison.Ordinal);
        }
    }
}
