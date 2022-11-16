using System;
using System.Diagnostics;

namespace Console_game_hero_vs_monster
{
    internal class Program
    {
        private static readonly int firstATK = 0;
        private static readonly int firstDEF = 0;
        private static bool dead = false;
        public static void Main()
        { 
            run(firstATK, firstDEF, 0);
        }

        private static void run(int atk, int def, int rounds)
        {
            HeroVsMonster(atk, def);
            Console.ReadLine();
            if (dead)
            {
                Console.WriteLine($"You are dead better luck next time! you survived {rounds} rounds");

            }
            else
            {
                atk = FindEquipment(atk);
                Console.ReadLine();

                def = FindArmor(def);
                Console.ReadLine();

                rounds++;

                Console.WriteLine($"ATK {atk}, DEF {def}, Rounds Survied: {rounds}");
                Console.ReadLine();

                run(atk, def, rounds);
            }
        }

        private static int FindEquipment(int atk)
        {
            var random = new Random().Next(1, 10);

            if (random == 5)
            {
                var newAtk = new Random().Next(1, 4);
                Console.WriteLine($"You found a better sword ATK increased by {newAtk} ");
                return atk + newAtk;
            } 
            
            Console.WriteLine("found nothing :(");
            
            return atk;
        }
        private static int FindArmor(int def)
        {
            var random = new Random().Next(1, 10);

            if (random == 5)
            {
                var newDef = new Random().Next(1, 3);
                Console.WriteLine($"You found a betteR armor DEF increased by {newDef} ");
                return def + newDef;
            }
            Console.WriteLine("found nothing :(");
            
            return def;
        }

        
        
         private static void HeroVsMonster(int ATK, int DEF)
            {
                var attack = new Random() ;
                var HPhero = 150 - ATK - ATK;
                var HPMonster = 100;
                while (HPhero > 0 && HPMonster > 0)
                {
                    var currentAttackHero = attack.Next(5 + ATK, 25 + ATK) ;
                    HPMonster -= currentAttackHero;
                    Console.WriteLine($"Hero attacked the Monster Lost {currentAttackHero} HP, Monster HP now is {HPMonster}");
                    
                    var selfDestruct = new Random().Next(1, 10);
                        if (selfDestruct != 5)
                        {
                            if (HPMonster <= 0) break;
                        } else if (HPMonster > 0)
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
    }
}