a
using UnityEngine;

public class Hacker : MonoBehaviour
{
    string[] level1Passwords = { "book", "aisle", "self", "password", "font", "borrow"};
    string[] level2Passwords = { "prisoner", "handcuffs", "holster", "uniform", "arrest"};

    int level;
    string password;

    enum Screen { MainMenu, Password, Win};
    Screen currentScreen;

    void Start()
    {
        ShowMainMenu();
    }

    void ShowMainMenu()
    {
        Terminal.ClearScreen();
        currentScreen = Screen.MainMenu;
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
        else if(currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }
        else if(currentScreen == Screen.Password)
        {
            CheckPassword(input);
        }

    }

    void RunMainMenu(string input)
    {
        bool isValidLevelNumber = (input == "1" || input == "2");
        if(isValidLevelNumber)
        {
            level = int.Parse(input);
            StartGame();
        }
        else
        {
            Terminal.WriteLine("Please chose a valid level");
        }
    }

    void StartGame()
    {
        currentScreen = Screen.Password;
        Terminal.ClearScreen();
        switch(level)
        {
            case 1:
                password = level1Passwords[Random.Range(0, level1Passwords.Length)];
                break;
            case 2:
                password = level2Passwords[Random.Range(0, level1Passwords.Length)];
                break;
            default:
                Debug.LogError("Invalid level number");
                break;
        }

        Terminal.WriteLine("Please enter your password");
    }

    void CheckPassword(string input)
    {
        if(input == password)
        {
            Terminal.WriteLine("well done");
        }
        else
        {
            Terminal.WriteLine("Sorry, wrong password");
        }            
    }

}
