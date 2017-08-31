using System.Linq;

namespace AlgorithmParty.Services
{
    public static class GeneralProblemService
    {
        public static int GetTimeWithMostUsers()
        {
            var users = new[] {
                new { User = "A", LogOn = 1, LogOff = 3 },
                new { User = "B", LogOn = 2, LogOff = 3 },
                new { User = "C", LogOn = 2, LogOff = 4 },
                new { User = "D", LogOn = 3, LogOff = 4 },
                new { User = "E", LogOn = 1111, LogOff = 2224 }
            };

            var startTime = users.Min(u => u.LogOn);
            var endTime = users.Max(u => u.LogOff);
            var maxUsers = 0;

            while (endTime >= startTime)
            {
                var usersOnline = users.Count(u => startTime >= u.LogOn && startTime <= u.LogOff);

                if (usersOnline > maxUsers)
                {
                    maxUsers = usersOnline;
                }

                startTime++;
            }

            // another way - may be more effiient as there are less users than time
            //foreach (var cu in users)
            //{
            //    var otherUsersOnline = users.Count(u => cu.LogOn <= u.LogOn && cu.LogOff >= u.LogOff);

            //    if (++otherUsersOnline > maxUsers)
            //    {
            //        maxUsers = otherUsersOnline;
            //    }
            //}

            return maxUsers;
        }
    }
}
