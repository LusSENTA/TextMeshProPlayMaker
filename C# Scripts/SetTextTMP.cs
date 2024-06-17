// Developed by Lus SENTA (2024). Licensed under MIT License
using System.Collections;
using System.Collections.Generic;
using TMPro;
using HutongGames.PlayMaker;
using UnityEngine;

public class TMPUpdater : MonoBehaviour
{

    public TextMeshProUGUI mainText;
    public string FsmGlobalVar = "";
    string checkText = "";
    string compareText = "";
    string setText = "";

    // Initial setting of string "checkText"
    void Start()
    {
        checkText = FsmVariables.GlobalVariables.FindFsmString(FsmGlobalVar).Value;
    }

    // Checks if selected Fsm Global Variable has changed
    void Update()
    {
        compareText = FsmVariables.GlobalVariables.FindFsmString(FsmGlobalVar).Value;

        if (compareText != checkText)
        {
            setText = FsmVariables.GlobalVariables.FindFsmString(FsmGlobalVar).Value;
            checkText = FsmVariables.GlobalVariables.FindFsmString(FsmGlobalVar).Value;
            TMPUpdate();
         }
    }

    // Call to update text to contents of string "setText"
    void TMPUpdate()
    {
        mainText.text = setText;
    }
}
