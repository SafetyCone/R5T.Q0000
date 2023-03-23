using System;


namespace R5T.Q0000
{
    public class EquatableIType : IType, IEquatable<EquatableIType>
    {
        public string Value { get; set; }


        public EquatableIType(string value)
        {
            this.Value = value;
        }

        public bool Equals(EquatableIType other)
        {
            var output = other?.Value == this.Value;
            return output;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as EquatableIType);
        }

        public override int GetHashCode()
        {
            var hashCode = this.Value.GetHashCode();
            return hashCode;
        }
    }
}
