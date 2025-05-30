namespace ApostasEsportivasApi.Models
{
    public class BetRequest
    {
        public int EventId { get; set; }
        public string OutcomeDescription { get; set; } = string.Empty;
        public double Odd { get; set; }
        public double Amount { get; set; }
        public double PotentialReturn { get; set; }
    }
}
