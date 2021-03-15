using System;

namespace SuperMarket.Services.GoodEntreis
{
    public class GettGoodEntryDto
    {
        public string GoodCode { get; set; }
        public DateTime EntryDate { get; set; }
        public int GoodCount { get; set; }
    }
}