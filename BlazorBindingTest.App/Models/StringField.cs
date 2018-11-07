using System;

namespace BlazorBindingTest.App.Models
{
    public class StringField : IField
    {
        public Guid Id { get; set; }
        public string Value { get; set; }

        public static implicit operator string(StringField field)
        {
            return field.Value;
        }
    }
}