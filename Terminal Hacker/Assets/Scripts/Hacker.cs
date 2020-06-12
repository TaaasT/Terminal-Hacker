using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{

    void Start()
    {
        ShowMainMenu("Hello Ben");
    }

    
    void Update()
    {
        
    }

    void ShowMainMenu(string greeting)
    {
        Terminal.ClearScreen();

        Terminal.WriteLine(greeting);
        Terminal.WriteLine("What would you like to hack?");
        Terminal.WriteLine("");
        Terminal.WriteLine("Press 1 for the local library");
        Terminal.WriteLine("Press 2 for the police station");
        Terminal.WriteLine("Press 3 for NASA");
        Terminal.WriteLine("Enter your selection ");
    }

}
