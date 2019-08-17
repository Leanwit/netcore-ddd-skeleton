namespace Shared.Domain.ValueObject
{
    abstract class IntValueObject
    {
        protected int Value { get; set; }

        public IntValueObject(int value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return this.Value.ToString();
        }
    }
}