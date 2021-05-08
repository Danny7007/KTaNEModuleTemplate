using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using UnityEngine;
using KModkit;

public class TemplateScript : MonoBehaviour {

    public KMBombInfo Bomb;
    public KMAudio Audio;

    static int moduleIdCounter = 1;
    int moduleId;
    private bool moduleSolved;

    void Awake() //Invoked on frame 0
    {
        moduleId = moduleIdCounter++;
        
        /*
        foreach (KMSelectable selectable in keypad) 
        {
            selectable.OnInteract += delegate () { keypadPress(selectable); return false; };
        }
        */
        //button.OnInteract += delegate () { buttonPress(); return false; };

    }

    void Start() //Invoked on frame 1
    {

    }

    void Update() //Invoked every frame 
    {

    }

    #pragma warning disable 414
    private readonly string TwitchHelpMessage = @"Use [!{0}] to do something.";
    #pragma warning restore 414

    IEnumerator ProcessTwitchCommand (string input)
    {
        yield return null;
    }

    IEnumerator TwitchHandleForcedSolve ()
    {
        yield return null;
    }
}
