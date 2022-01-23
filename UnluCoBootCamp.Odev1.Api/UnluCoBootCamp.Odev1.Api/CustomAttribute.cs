using System;

namespace UnluCoBootCamp.Odev1.Api
{
    public class CustomAttribute:Attribute
    {
        public string Value { get; set; }
        public CustomAttribute(string value)
        {
            Value = value;
        }
    }
}
