using System;

namespace Baz_geluk9.Feature_vault.Extensions
{
    public sealed class CharValueAttribute : Attribute
    {
        public char Value { get; }

        public CharValueAttribute(char value) => Value = value;
    }
}