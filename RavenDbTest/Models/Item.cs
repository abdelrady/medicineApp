﻿namespace RavenDbTest.Models
{
    public class Item
    {
        public string Id { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public string TakingPeriod { get; set; }
        public string ImageUrl { get; set; }
        public bool? IsActive { get; set; }
    }

    //public enum Category
    //{
    //    BodyTemperature,
    //    Antibiotic,
    //    BodySkin
    //}
}
