using System;

namespace ConsoleApplication2
{
    internal class Program
    {
        private static readonly int firstATK = 0;
        private static readonly int firstDEF = 0;
        private static bool dead = false;

        public static void Main()
        {
            Event(firstATK, firstDEF, 0);
        }

        private static void Event(int atk, int def, int rounds)
        {
            
            if (dead)
            {
                Console.WriteLine($"You are dead better luck next time! you survived {rounds} rounds");

            }
            else
            {
                rounds++;
                
                var newatk = FindEquipment(atk);
                if (newatk > atk)
                {
                    Console.WriteLine($"You found a new weapon your atk increased by {newatk}");
                    atk += newatk;
                    Console.ReadLine();
                }
                
                

                var newdef = FindArmor(def);
                if (newdef > def)
                {
                    Console.WriteLine($"You found new armor you def increased by {newdef}");
                    def += newdef;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"You encounterd a monster!");
                    Battle(atk, def);
                }

                

                Console.WriteLine($"ATK {atk}, DEF {def}, Rounds Survied: {rounds}");
                Console.ReadLine();

                Event(atk, def, rounds);
            }
        }

        private static int FindEquipment(int atk)
        {
            var random = new Random().Next(1, 10);

            if (random != 5) return atk;
            var newAtk = new Random().Next(1, 4);
            return newAtk;

        }

        private static int FindArmor(int def)
        {
            var random = new Random().Next(1, 10);

            if (random != 5) return def;
            var newDef = new Random().Next(1, 3);
            return newDef;
        }



        private static void Battle(int ATK, int DEF)
        {
            var attack = new Random();
            var HPhero = 150 - ATK - ATK;
            var HPMonster = 100;
            while (HPhero > 0 && HPMonster > 0)
            {
                var currentAttackHero = attack.Next(5 + ATK, 25 + ATK);
                HPMonster -= currentAttackHero;
                Console.WriteLine(
                    $"Hero attacked the Monster Lost {currentAttackHero} HP, Monster HP now is {HPMonster}");

                var selfDestruct = new Random().Next(6, 6);
                if (selfDestruct != 5)
                {
                    if (HPMonster <= 0) break;
                }
                else if (HPMonster > 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;

                    HPhero -= new Random().Next(30, 50);
                    if (HPhero > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Monster self destructed!. But the hero tanked it! hero wins");
                        Console.ResetColor();
                        break;
                    }

                    Console.WriteLine("Monster self destructed!. The Hero and the Monster both are dead");
                    Console.ResetColor();
                    HPhero = 1;
                    HPMonster = 1;
                    dead = true;
                    break;
                }
                else
                {
                    break;
                }

                var currentAttackMonster = attack.Next(10 - DEF, 30 - DEF);
                HPhero -= currentAttackMonster;
                Console.WriteLine($"Monster attacked the Hero Lost {currentAttackMonster} HP, Hero HP now is {HPhero}");
            }

            if (HPMonster <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Hero won! with {HPhero}HP left");
                Console.ResetColor();
            }
            else if (HPhero <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Monster won! with {HPMonster}HP left");
                Console.ResetColor();
                dead = true;
            }
        }

        public static void SelfDestruct()
        {
            var selfDestruct = new Random().Next(1,5);

            if (selfDestruct == 3)
            {
                
            }

        }
    }
}