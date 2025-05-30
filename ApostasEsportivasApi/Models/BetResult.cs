namespace ApostasEsportivasApi.Models
{
    public class BetResult
    {
        public string OutcomeDescription { get; set; } = string.Empty;
        public double Odd { get; set; }
        public double Amount { get; set; }
        public double PotentialReturn { get; set; }
    }
}
