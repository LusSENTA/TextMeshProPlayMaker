// Developed by Lus SENTA (2024). Licensed under MIT License
using TMPro;
using HutongGames.PlayMaker;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{

	[ActionCategory("TextMeshPro")]
    [Tooltip("Set Text of a TextMeshPro object from a Global Variable.")]
    public class SetTextTMPGlobalVariable : FsmStateAction
	{
        // Get TextMeshPro object
        [RequiredField]
        [Tooltip("The TextMeshPro object you want to change.")]
        public TextMeshProUGUI textObject;

        // Get Global Variable
        [RequiredField]
        [Tooltip("The String Variable used to set TextMeshPro objext.")]
        public string FsmGlobalString;

        string setText;

        // Get Fsm Global Variable and set TextMeshPro object to it
        public override void OnEnter()
		{
            setText = FsmVariables.GlobalVariables.FindFsmString(FsmGlobalString).Value;
            textObject.text = setText;
            Finish();
		}


	}

}
