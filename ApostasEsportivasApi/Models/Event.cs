﻿namespace ApostasEsportivasApi.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<Outcome> Outcomes { get; set; } = new();
    }
}
