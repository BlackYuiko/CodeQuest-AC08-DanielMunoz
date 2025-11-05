using System;
using System.ComponentModel.DataAnnotations;


public class Program
{
    static void Main()
    {
        const string MenuTitle = "===== MAIN MENU - CODEQUEST =====";
        const string MenuOption1 = "1. Train your wizard";
        const string MenuOption2 = "2. Check the dungeon";
        const string MenuOption3 = "3. Loot the mine";
        const string MenuOptionExit = "0. Exit game";
        const string MenuPrompt = "Choose an option (1-3) - (0) to exit: ";
        const string InputErrorMessage = "Invalid input. Please enter a number between 0 and 3.";

        const string AskName = "What is your mage name?";
        const string MsgLevelObtained = "Level obtained day {0} : {1}";
        const string MsgPointLevel = "Your final points of level is ";
        const string MsgPowerLevel = "{0}, you obtained the final level of power: {1}";
        const string MsgRaoden = "You repeat in the 2nd call.";
        const string LvlRaoden = "Raoden the Elantrian";
        const string MsgZyn = "You still confuse the rod with a spoon";
        const string LvlZyn = "Zyn the Bugged";
        const string MsgArka = "You are a Summoner of Magical Breezes.";
        const string LvlArka = "Arka Nullpointer";
        const string MsgElarion = "Wow! You can summon dragons without burning down the lab!";
        const string LvlElarion = "Elarion of the Embers";
        const string MsgITBWizard = "You have reached the rank of Arcane Master!";
        const string LvlITBWizard = "ITB-Wizard the Grey";

        const string DrakeRamon = "You must demonstrate your training and enter the Dungeon of the drake Ramón the Mighty, " +
            "where each door is protected by a digital access code beetween 1 and 5, both included.\n";
        const string MsgDigitalCode = "Enter a number for the digital code:";
        const string MsgCorrectCode = "The correct code was: ";
        const string MsgIncorrectCode = "The drake kicked you from the server.";
        const string NextDoor = "You pass to the next door!";
        const string AllDoorsCorrect = "Be ready for the fight!!!";

        const string DrakeDefeated = "Well done! You defeated the drake, it's time to loot the mine.";
        const string NotLucky = "Today is not ur lucky day, you founded 0 bits.";
        const string MsgLootFounded = "You found {0} bits.";
        const string MsgTotalLootFounded = "Your total bits founded is: {0}";
        const string goldGPU = "You have unlocked the gold GPU! Your spells now run at 120 FPS!";
        const string integratedGPU = "Your magic card is still integrated. It's time to defeat another drake!";

        int op = 0;
        bool validInput;
        int trainingDays = 5;
        string? name;
        Random rnd = new Random();
        string levelPower = "";

        int numberCode;
        int level;
        int doorCounter;
        int maxTries;

        int rndLootFounded;
        int noBits = 10; // 10% of no loot for each mine
        int totalLootFounded = 0;
        int excavations;
        int maxExcavations = 5;

        do
        {
            Console.WriteLine(MenuTitle);
            Console.WriteLine(MenuOption1);
            Console.WriteLine(MenuOption2);
            Console.WriteLine(MenuOption3);
            Console.WriteLine(MenuOptionExit);
            Console.Write(MenuPrompt);

            validInput = true;

            try
            {
                op = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine(InputErrorMessage);
                validInput = false;
            }
            catch (Exception)
            {
                Console.WriteLine(InputErrorMessage);
                validInput = false;
            }

            if (validInput)
            {
                if (op == 1) 
                {
                    Console.WriteLine(AskName);
                    name = Console.ReadLine();

                    level = 1;

                    for (int i = 1; i <= trainingDays; i++)
                    {
                        int rndLevel = rnd.Next(1, 11);
                        Console.WriteLine(MsgLevelObtained, i, rndLevel);
                        level += rndLevel;
                    }

                    Console.WriteLine(MsgPointLevel + level);

                    if (level < 20)
                    {
                        Console.WriteLine(MsgRaoden);
                        levelPower = LvlRaoden;
                    }
                    else if (level >= 20 && level < 30)
                    {
                        Console.WriteLine(MsgZyn);
                        levelPower = LvlZyn;
                    }
                    else if (level >= 30 && level < 35)
                    {
                        Console.WriteLine(MsgArka);
                        levelPower = LvlArka;
                    }
                    else if (level > 35 && level < 40)
                    {
                        Console.WriteLine(MsgElarion);
                        levelPower = LvlElarion;
                    }
                    else if (level >= 40)
                    {
                        Console.WriteLine(MsgITBWizard);
                        levelPower = LvlITBWizard;
                    }
                    Console.WriteLine(MsgPowerLevel, name, levelPower);
                                        
                }

                if (op == 2)
                {
                    Console.WriteLine(DrakeRamon);

                    doorCounter = 0;
                    maxTries = 0;

                    while (maxTries < 3 && doorCounter < 3)
                    {

                        Console.WriteLine(MsgDigitalCode);


                        numberCode = Convert.ToInt32(Console.ReadLine());

                        int rndDoorValue = rnd.Next(1, 6);

                        maxTries++;

                        Console.WriteLine(MsgCorrectCode + rndDoorValue);
                        Console.WriteLine();

                        if (numberCode == rndDoorValue)
                        {
                            doorCounter++;

                            if (doorCounter != 3)
                            {
                                Console.WriteLine(NextDoor);
                            }

                            maxTries = 0;
                        }

                        if (doorCounter >= 3)
                        {
                            Console.WriteLine(AllDoorsCorrect);
                        }

                        if (maxTries >= 3)
                        {
                            Console.WriteLine(MsgIncorrectCode);
                            totalLootFounded = 0;
                        }
                    }
                }
                if (op == 3)
                {
                    Console.WriteLine(DrakeDefeated);
                    excavations = 0;

                    while (excavations != maxExcavations)
                    {
                        if (rnd.Next(noBits) == 0)
                        {
                            Console.WriteLine(NotLucky);
                        }
                        else
                        {
                            rndLootFounded = rnd.Next(5, 51);
                            Console.WriteLine(MsgLootFounded, rndLootFounded);
                            totalLootFounded += rndLootFounded;
                        }
                        excavations++;
                    }

                    Console.WriteLine("\n" + MsgTotalLootFounded, totalLootFounded);

                    if (totalLootFounded > 200)
                    {
                        Console.WriteLine(goldGPU);
                    }
                    else
                    {
                        Console.WriteLine(integratedGPU);
                    }
                }
            }
            Console.WriteLine();
        }

        while (op != 0);
    }
}




