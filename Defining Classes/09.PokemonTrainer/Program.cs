namespace _09.PokemonTrainer
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            List<Trainer> trainers = new();

            string command;
            while ((command = Console.ReadLine()) != "Tournament")
            {
                string[] cmdArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string trainerName = cmdArgs[0];
                string pokemonName = cmdArgs[1];
                string pokemonElement = cmdArgs[2];
                int pokemonHealth = int.Parse(cmdArgs[3]);

                var trainer = trainers.FirstOrDefault(x => x.Name == trainerName);
                if (trainer != null)
                {
                    trainer.Pokemons.Add(new Pokemon(pokemonName, pokemonElement, pokemonHealth));
                }
                else
                {
                    var newTrainer = new Trainer(trainerName);
                    newTrainer.Pokemons.Add(new Pokemon(pokemonName, pokemonElement, pokemonHealth));
                    trainers.Add(newTrainer);
                }

                
                //Trainer trainer = new Trainer(trainerName, pokemon);

                //Console.WriteLine(trainer.ToString());
            }

            string command2;
            while ((command2 = Console.ReadLine()) != "End")
            {
                for (int i = 0; i < trainers.Count; i++)
                {
                    if (!trainers[i].Pokemons.Any(x => x.Element == command2))
                    {
                        foreach (var item in trainers[i].Pokemons)
                        {
                            item.Health -= 10;
                            if (item.Health <= 0)
                            {
                                trainers[i].Pokemons.RemoveAll(x => x.Health <= 0);
                                break;
                                //foreach (var item2 in trainers)
                                //{
                                //    item2.Pokemons.RemoveAll(x => x.Health <= 0);
                                //}
                            }
                            
                        }
                    }
                    else
                    {
                        trainers[i].NumberOfBadges++;
                    }
                }
            }

            var ordered = trainers.OrderByDescending(x => x.NumberOfBadges);
            foreach (var trainer in ordered)
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.Pokemons.Count}");
            }
        }
    }
}