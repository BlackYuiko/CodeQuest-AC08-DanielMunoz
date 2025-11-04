using System;


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
        

        int op = 0;
        bool validInput;
        int trainingDays = 5;
        string name;
        string levelPower = "";
        Random rnd = new Random();

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
                    int level = 1;
                    Console.WriteLine(AskName);
                    
                    name = Console.ReadLine();
                    for (int i = 1; i <= trainingDays; i++)
                    {
                        int rndLevel = rnd.Next(1,11);
                        Console.WriteLine(MsgLevelObtained, i, rndLevel);
                        level = level + rndLevel;
                        
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
                    Console.WriteLine();
                }
            }
        } 

        while (op != 0);
    }
}