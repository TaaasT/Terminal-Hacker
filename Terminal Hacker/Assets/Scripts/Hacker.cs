using Packages.Rider.Editor.UnitTesting;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{

    void Start()
    {
        ShowMainMenu();
    }

    void ShowMainMenu()
    {
        Terminal.ClearScreen();

        Terminal.WriteLine("What would you like to hack?");
        Terminal.WriteLine("");
        Terminal.WriteLine("Press 1 for the local library");
        Terminal.WriteLine("Press 2 for the police station");
        Terminal.WriteLine("Press 3 for NASA");
        Terminal.WriteLine("Enter your selection ");
    }

    void OnUserInput(string input)
    {
        if (input == "menu")
        {
            ShowMainMenu();
        }
        else if (input == "1")
        {
            print("You chose level 1");
        }
        else
        {
            Terminal.WriteLine("Please chose a valid level");
        }

    }

}
