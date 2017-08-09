using AlgorithmParty.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmParty.Patterns.Fluent_Builder
{
    public class TeamApp
    {
        public void Execute()
        {
            TeamBuilder tb = new TeamBuilder();

            Team team3 = tb.CreateTeam("Chelsea")
                .WithNickName("The blues")
                .WithShirtColor(Color.Blue)
                .FromTown("London")
                .PlayingAt("Stamford Bridge");
        }
    }
}
