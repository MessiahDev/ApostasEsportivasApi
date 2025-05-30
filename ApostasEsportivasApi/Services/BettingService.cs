using ApostasEsportivasApi.Data;
using ApostasEsportivasApi.Models;

namespace ApostasEsportivasApi.Services
{
    public class BettingService
    {
        public List<Event> GetAllEvents() => MockData.Events;

        public BetResult SimulateBet(BetRequest request)
        {
            var ev = MockData.Events.FirstOrDefault(e => e.Id == request.EventId);
            if (ev == null)
                throw new ArgumentException("Evento não encontrado");

            var outcome = ev.Outcomes.FirstOrDefault(o => o.Description == request.OutcomeDescription);
            if (outcome == null)
                throw new ArgumentException("Resultado não encontrado");

            return new BetResult
            {
                OutcomeDescription = outcome.Description,
                Odd = outcome.Odd,
                Amount = request.Amount,
                PotentialReturn = Math.Round(request.Amount * outcome.Odd, 2)
            };
        }
    }
}
