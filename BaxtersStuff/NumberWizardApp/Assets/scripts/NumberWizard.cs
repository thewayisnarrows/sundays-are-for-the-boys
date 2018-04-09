using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    int max = 1000;
    int min = 1;
    int guess = 500; 
    // Use this for initialization
    void Start ()
    {
        StartGame();
    }

    private void StartGame()
    {
        max = 1001;
        min = 1;
        guess = 500;

        print("========================");
        print("Welcome to number wizard");
        print("Pick a number in your head but don't tell me");

        print("Pick a number between " + min + " and " + max);

        print("Is your number higher than 500?");
        print("Up for higher, down for lower, equal means we guessed it");
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            NextGuess("min");
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            NextGuess("max");
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            print(guess + " was your number");

            StartGame();
        }
    }

    private void NextGuess(string limit)
    {
        if (limit.ToLower() == "min")
        {
            min = guess;
        } else if (limit.ToLower() == "max")
        {
            max = guess;
        }
        guess = (max + min) / 2;
        print("Is your number higher or lower than " + guess);
    }
}
