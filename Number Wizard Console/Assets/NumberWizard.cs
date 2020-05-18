﻿using Microsoft.Win32.SafeHandles;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{ 

    static int min = 1;
    static int max = 1000;
    static int guess = (min + max) / 2;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Welcome to Number Wizard");
        Debug.Log("Pick a number!");
        Debug.Log($"The Highest number you can pick is {max}.");
        Debug.Log($"The Lowest number you can pick is {min}.");
        Debug.Log($"Tell me if your number is higher or lower than {guess}.");
        Debug.Log("[UP] = Higher, [DOWN] = Lower, or [RETURN] = Correct!");
        max += 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("You chose Higher.");
            min = guess;
            guess = (min + max) / 2;
            Debug.Log($"Is your number {guess}?");
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("You chose Lower.");
            max = guess;
            guess = (min + max) / 2;
            Debug.Log($"Is your number {guess}?");
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Correct!");
        }
    }
}
