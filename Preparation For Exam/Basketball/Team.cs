using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Basketball
{
    public class Team
    {
        private List<Player> players;

        public Team(string name, int openPositions, char group)
        {
            Name = name;
            OpenPositions = openPositions;
            Group = group;
            players = new List<Player>();
        }

        public string Name { get; private set; }
        public int OpenPositions { get; private set; }
        public char Group { get; private set; }
        public IReadOnlyCollection<Player> Players => players;

        public int Count => Players.Count;

        public string AddPlayer(Player player)
        {
            if (string.IsNullOrEmpty(player.Name) || string.IsNullOrEmpty(player.Position))
            {
                return "Invalid player's information.";
            }
            else if (OpenPositions <= 0)
            {
                return "There are no more open positions.";
            }
            else if (player.Rating < 80)
            {
                return "Invalid player's rating.";
            }

            players.Add(player);
            OpenPositions--;
            return $"Successfully added {player.Name} to the team. Remaining open positions: {OpenPositions}.";
        }

        public bool RemovePlayer(string name)
        {
            foreach (Player player in players)
            {
                if (player.Name == name)
                {
                    OpenPositions++;
                    players.Remove(player);
                    return true;
                }
            }

            return false;
        }

        public Player RetirePlayer(string name)
        {

            foreach (var player in players)
            {
                if (player.Name == name)
                {
                    player.Retired = true;
                    return player;
                }
            }

            return null;
        }

        public List<Player> AwardPlayers(int games)
        {
            List<Player> list = new List<Player>();
            foreach (Player player in players.Where(p => p.Games >= games))
            {
                list.Add(player);
            }

            return list;
        }

        public int RemovePlayerByPosition(string position)
        {
            int count = players.RemoveAll(p => p.Position == position);

            OpenPositions++;
            return count;
        }


        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Active players competing for Team {Name} from Group {Group}: ");
            foreach (Player player in players.Where(p => p.Retired == false))
            {
                sb.AppendLine(player.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
