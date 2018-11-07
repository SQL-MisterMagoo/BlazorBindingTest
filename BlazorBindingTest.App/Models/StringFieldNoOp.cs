using System;

namespace BlazorBindingTest.App.Models
{
    public class StringFieldNoOp : IField
    {
        public Guid Id { get; set; }
        public string Value { get; set; }
    }
}