// Developed by Lus SENTA (2024). Licensed under MIT License
using System.Collections;
using System.Collections.Generic;
using TMPro;
using HutongGames.PlayMaker;
using UnityEngine;

public class SetTextTMPBackground : MonoBehaviour
{

    public TextMeshProUGUI textObject;
    public string FsmGlobalString;
    string checkText;
    string compareText;
    string setText;

    // Initial setting of string "checkText"
    void Start()
    {
        checkText = FsmVariables.GlobalVariables.FindFsmString(FsmGlobalString).Value;
    }

    // Checks if selected Fsm Global Variable has changed
    void Update()
    {
        compareText = FsmVariables.GlobalVariables.FindFsmString(FsmGlobalString).Value;

        if (compareText != checkText)
        {
            setText = FsmVariables.GlobalVariables.FindFsmString(FsmGlobalString).Value;
            checkText = FsmVariables.GlobalVariables.FindFsmString(FsmGlobalString).Value;
            TMPUpdate();
         }
    }

    // Call to update text to contents of string "setText"
    void TMPUpdate()
    {
        textObject.text = setText;
    }
}
