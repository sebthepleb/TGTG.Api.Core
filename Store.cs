﻿namespace TGTG.Api.Core
{
    public class Store
    {
        public string Id { get; set; }
        public string ItemId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Website { get; set; }
        public Address Address { get; set; }
        public double Distance { get; set; }
        public bool Favourited { get; set; }

        public int NumberOfItemsAvailable { get; set; }
        // This appears to indicate whether to show "Check back later".
        public bool InSalesWindow { get; set; }

        public override string ToString() => $"{Name}";
    }
}