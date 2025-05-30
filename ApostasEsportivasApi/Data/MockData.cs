using ApostasEsportivasApi.Models;

namespace ApostasEsportivasApi.Data
{
    public class MockData
    {
        public static List<Event> Events => new()
        {
            new Event
            {
                Id = 1,
                Name = "Time A vs Time B",
                Outcomes = new List<Outcome>
                {
                    new Outcome { Description = "Vitória Time A", Odd = 1.8 },
                    new Outcome { Description = "Empate", Odd = 3.2 },
                    new Outcome { Description = "Vitória Time B", Odd = 2.5 }
                }
            },
            new Event
            {
                Id = 2,
                Name = "Time C vs Time D",
                Outcomes = new List<Outcome>
                {
                    new Outcome { Description = "Vitória Time C", Odd = 2.1 },
                    new Outcome { Description = "Empate", Odd = 3 },
                    new Outcome { Description = "Vitória Time D", Odd = 2 }
                }
            },
            new Event
            {
                Id = 2,
                Name = "Time E vs Time F",
                Outcomes = new List<Outcome>
                {
                    new Outcome { Description = "Vitória Time E", Odd = 1.9 },
                    new Outcome { Description = "Empate", Odd = 3.1 },
                    new Outcome { Description = "Vitória Time F", Odd = 2.2 }
                }
            }
        };
    }
}
