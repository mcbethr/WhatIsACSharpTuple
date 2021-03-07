using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace WhatIsACSharpTuple
{
    public enum CopType
    {
        OnFoot,
        OnMotorcycle,
        OnHorse,
        InCar
    }

    public enum Awareness
    {
        IsEngaged,
        Patroling,
        OnBreak,
        Unaware
    }

    public class Cop
    {
        public Point Position { get; set; }

        public int Speed { get; set; }

        public int Bearing { get; set; }

        public int Distance { get; set; }

        public CopType TypeOfCop { get; set; }

        public bool IsArmed {get;set;}

        public Awareness AwareState { get; set; }

        public string ClothingDescription { get; set; }

    }
}
