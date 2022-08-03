using System;
namespace ChristmasWithTypes
{
    public class Christmas
    {
        public string[] Presents;
        public string Santa { get; set; }
        public int? TreeHeight { get; set; } //DONE Make the Height property nullable ( just needed to add ? to int) 

        //DONE Make the property, "Day", type enum
        public enum Day {Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday};

    }
}
