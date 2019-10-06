using System;
using MateODragao.Models;

namespace MateODragao {
    class Program {
        static void Main (string[] args) {

            bool playerDidntGiveUp = true;

            do {

                Console.Clear ();
                System.Console.WriteLine ("==============||==============");
                System.Console.WriteLine ("       Kill The Dragon!");
                System.Console.WriteLine ("==============||==============");

                System.Console.WriteLine (" 1 - Start Game");
                System.Console.WriteLine (" 0 - Exit Game");

                string optionPlayer = Console.ReadLine();

                switch (optionPlayer) {
                    case "1":

                        Console.Clear();

                        Warrior warrior = CreateWarrior();

                        Dragon dragon = new Dragon();
                        dragon.Name = "Katuaba";
                        dragon.Strength = 5;
                        dragon.Dexterity = 1;
                        dragon.Intelligence = 3;
                        dragon.Life = 300;

                        /* Start - First Dialogue */
                        CreateDialogue(warrior.Name, $"{dragon.Name}, I'll end your reing of terror, you will no more kill inocent people!");
                        CreateDialogue(dragon.Name, "insolent human, who do you think you are? You are no more than a bug.");
                        
                        FinishDialogue();

                        /* End - First Dialogue */

                        /* Start - Second Dialogue */

                        System.Console.WriteLine($"{warrior.Name.ToUpper()}: I'm {warrior.Name}! Of The House {warrior.Surname}");
                        System.Console.WriteLine($"{warrior.Name.ToUpper()}: I come from {warrior.City} to kill you!");

                        System.Console.WriteLine($"{dragon.Name.ToUpper()} Who cares about you? I'll fry you like a chicken!");

                        System.Console.WriteLine("Is time for the showdown!");

                        System.Console.WriteLine();
                        System.Console.WriteLine("Press ENTER to proceed");
                        Console.ReadLine();
                        
                        /* End - Second Dialogue */
                        
                        bool playerAttacksFirst = warrior.Dexterity >= dragon.Dexterity ? true : false; 
                        int powerAttackWarrior = warrior.Strength > warrior.Intelligence ? warrior.Strength + warrior.Dexterity : warrior.Intelligence + warrior.Dexterity;

                        bool playerDidntRun = true;
                        if (playerAttacksFirst)
                        {
                            System.Console.WriteLine("*** Player's Turn ***");
                            System.Console.WriteLine("Choose a action");
                            System.Console.WriteLine("1 - Attack");
                            System.Console.WriteLine("2 - Run");

                            string optionBattlePlayer = Console.ReadLine();

                            switch (optionBattlePlayer)
                            {
                                case "1":
                                    Random generatorNumberRandom = new Random();

                                    int numberRandomWarrior = generatorNumberRandom.Next(0, 5);
                                    int numberRandomDrangon = generatorNumberRandom.Next(0, 5);
                                    int warriorDexterityTotal = warrior.Dexterity + numberRandomWarrior;
                                    int dragonDexterityTotal = dragon.Dexterity + numberRandomDrangon;

                                    if (warriorDexterityTotal > dragonDexterityTotal) 
                                    {
                                        System.Console.WriteLine($"{warrior.Name.ToUpper()}: Take this!");
                                        dragon.Life -= powerAttackWarrior + 5;

                                        System.Console.WriteLine($"{dragon.Name.ToUpper()}: AH! You human!");

                                        System.Console.WriteLine($"HP Dragon: {dragon.Life}");
                                        System.Console.WriteLine($"HP Warrior: {warrior.Life}");
                                    }

                                    else
                                    {
                                        System.Console.WriteLine($"{dragon.Name.ToUpper()}: You missed, idiot.");
                                    }

                                break;

                                case "2":
                                    System.Console.WriteLine($"{warrior.Name.ToUpper()}: I think I'm not ready yet to fight you ...");
                                    System.Console.WriteLine($"{dragon.Name.ToUpper()}: I knew it, you humans are all the same!");
                                    playerDidntRun = false;
                                break;
                            }
                            
                        } 

                        System.Console.WriteLine();
                        System.Console.WriteLine("Press ENTER to proceed");
                        Console.ReadLine();
                        
                        while (warrior.Life > 0 && dragon.Life > 0 && playerDidntRun)
                        {
                            Console.Clear();
                            System.Console.WriteLine("*** Dragon's Turn ***");
                            
                            Random generatorNumberRandom = new Random();
                            int numberRandomWarrior = generatorNumberRandom.Next(0, 5);
                            int numberRandomDrangon = generatorNumberRandom.Next(0, 5);
                            int warriorDexterityTotal = warrior.Dexterity + numberRandomWarrior;
                            int dragonDexterityTotal = dragon.Dexterity + numberRandomDrangon;

                            if (dragonDexterityTotal > warriorDexterityTotal) 
                            {
                                System.Console.WriteLine($"{dragon.Name.ToUpper()}: Burn human!");
                                warrior.Life -= dragon.Strength;

                                System.Console.WriteLine($"{warrior.Name.ToUpper()}: AH! You pay for this!");

                                System.Console.WriteLine($"HP Dragon: {dragon.Life}");
                                System.Console.WriteLine($"HP Warrior: {warrior.Life}");
                            }

                            else
                            {
                                System.Console.WriteLine($"{warrior.Name.ToUpper()}: Are you blind or something?");
                            }

                            System.Console.WriteLine();
                            System.Console.WriteLine("Press ENTER to proceed");
                            Console.ReadLine();

                            /* */

                            Console.Clear();

                            System.Console.WriteLine("*** Player's Turn ***");
                            System.Console.WriteLine("Choose a action");
                            System.Console.WriteLine("1 - Attack");
                            System.Console.WriteLine("2 - Run");

                            string optionBattlePlayer = Console.ReadLine();

                            switch (optionBattlePlayer)
                            {
                            case "1":
                                generatorNumberRandom = new Random();

                                numberRandomWarrior = generatorNumberRandom.Next(0, 5);
                                numberRandomDrangon = generatorNumberRandom.Next(0, 5);
                                warriorDexterityTotal = warrior.Dexterity + numberRandomWarrior;
                                dragonDexterityTotal = dragon.Dexterity + numberRandomDrangon;
                                
                                if (warriorDexterityTotal > dragonDexterityTotal) 
                                {
                                    System.Console.WriteLine($"{warrior.Name.ToUpper()}: Take this!");
                                    dragon.Life -= powerAttackWarrior + 5;

                                    System.Console.WriteLine($"{dragon.Name.ToUpper()}: AH! You human!");

                                    System.Console.WriteLine($"HP Dragon: {dragon.Life}");
                                    System.Console.WriteLine($"HP Warrior: {warrior.Life}");
                                }

                                else
                                {
                                    System.Console.WriteLine($"{dragon.Name.ToUpper()}: You missed, idiot.");
                                }

                            break;

                            case "2":
                                System.Console.WriteLine($"{warrior.Name.ToUpper()}: I think ... I'm not ready yet to fight you ...");
                                System.Console.WriteLine($"{dragon.Name.ToUpper()}: I knew it, you humans are all the same!");
                                playerDidntRun = false;
                            break;
                            }
                            
                        }
                        
                        if (warrior.Life <= 0)
                        {
                            System.Console.WriteLine("You lost!");
                        }

                        if (dragon.Life <= 0)
                        {
                            System.Console.WriteLine("You won!");
                        }

                        break;

                    case "0":
                        playerDidntGiveUp = false;
                        System.Console.WriteLine("|GAMERS RISE UP|");
                        break;

                    default:
                        System.Console.WriteLine ("Invalid Comand, Please Try Again.");
                        break;
                }

            } while (playerDidntGiveUp);

        }
    
        public static void CreateDialogue(string name, string phrase) {
            System.Console.WriteLine($"{name.ToUpper()}:\n{phrase}");
        }

        public static void FinishDialogue() {
            System.Console.WriteLine();
            System.Console.WriteLine("Press ENTER to proceed");
            Console.ReadLine();
            Console.Clear();
        }

        public static Warrior CreateWarrior() {
            Warrior warrior = new Warrior();
            warrior.Name = "Isabella";
            warrior.Surname = "O'Tricks";
            warrior.City = "Paris";
            warrior.DOB = DateTime.Parse("29/06/1427");
            warrior.DefenseWeapon = "Shield";
            warrior.AttackWeapon = "Axe";
            warrior.Strength = 3;
            warrior.Dexterity = 2;
            warrior.Intelligence = 3;
            warrior.Life = 20;

            return warrior;
        }
    
    }
}