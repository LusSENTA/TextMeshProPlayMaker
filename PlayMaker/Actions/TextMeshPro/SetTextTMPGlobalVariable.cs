// Developed by Lus SENTA (2024). Licensed under MIT License
using TMPro;
using HutongGames.PlayMaker;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{

	[ActionCategory("TextMeshPro")]
	public class SetTextTMPGlobalVariable : FsmStateAction
	{

        public TextMeshProUGUI textObject;

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
