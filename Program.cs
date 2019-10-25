using System;
using System.Linq;

namespace EOLCricketSimulator
{
    class Program
    {
            static void Main(string[] args)
            {
                Team team = new Team(4, 40, 4);
                Random random = new Random();
                WeightRandom weight = new WeightRandom(team.Striker.RunsProbability.Select(x => x.Item2).ToList(), team.Striker.RunsProbability.Select(x => x.Item1).ToList());
            for (int i = team.LeftOvers; i > 0; i--)
            {
                Console.WriteLine($"{i} overs left. {team.RunsToWin} runs to win.");
                for (int j = 0; j < 6; j++)
                {
                    int score = weight.Next();
                    team.Striker.NumberBalls += 1;
                    //Out case so change the player
                    if (score == -1)
                    {
                        Console.WriteLine($"0.{j + 1} {team.Striker.PlayerName} is out.");
                        team.Striker.IsOut = true;
                        team.RemainingWicket--;
                        if (team.RemainingWicket == 0)
                        {
                            Console.WriteLine($"Remus lost by {team.RunsToWin} runs.");
                            //lose case
                            break;
                        }
                        else
                        {
                            team.Striker = team.Players[team.Players.Count - team.RemainingWicket - 1];
                            weight = new WeightRandom(team.Striker.RunsProbability.Select(x => x.Item2).ToList(), team.Striker.RunsProbability.Select(x => x.Item1).ToList());
                        }
                    }
                    else
                    {
                        team.TotalRuns += score;
                        team.RunsToWin -= score;
                        if (score <= 1)
                            Console.WriteLine($"0.{j + 1} {team.Striker.PlayerName} scores {score} run.");
                        else
                            Console.WriteLine($"0.{j + 1} {team.Striker.PlayerName} scores {score} runs.");

                        if (team.RunsToWin <= 0)
                        {
                            Console.WriteLine($"Remus won by {team.RemainingWicket} wicket with {(i) * 6 - j - 1} balls remaining.");
                            team.Players.OrderBy(currPlayer => currPlayer.Order).ToList().ForEach(currPlayer =>
                            {
                                if (team.Players.Count - team.RemainingWicket < currPlayer.Order)
                                {
                                    return;
                                }
                                if (currPlayer.IsOut)
                                {
                                    Console.WriteLine($"{currPlayer.PlayerName} - {currPlayer.Score} runs ({currPlayer.NumberBalls} balls).");
                                }
                                else
                                {
                                    Console.WriteLine($"{currPlayer.PlayerName} - {currPlayer.Score}* runs ({currPlayer.NumberBalls} balls).");
                                }
                            });
                            break;
                        }
                        team.Striker.Score += score;
                        if (score % 2 != 0 || j == 5)
                        {
                            var temp = team.Striker;
                            team.Striker = team.Runner;
                            weight = new WeightRandom(team.Striker.RunsProbability.Select(x => x.Item2).ToList(), team.Striker.RunsProbability.Select(x => x.Item1).ToList());
                            team.Runner = temp;
                        }
                    }
                }

                if (team.RemainingWicket == 0 || team.TotalRuns == 40 || team.RunsToWin < 0)
                    {
                        break;
                    }

                    Console.WriteLine();
                }
            }
    }
}
