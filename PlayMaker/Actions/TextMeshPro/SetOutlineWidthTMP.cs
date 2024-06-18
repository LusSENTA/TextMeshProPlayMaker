using TMPro;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{

	[ActionCategory("TextMeshPro")]
	[Tooltip("Set Outline Width of a TextMeshPro object.")]
	public class SetOutlineWidthTMP : FsmStateAction
	{

        [RequiredField]
        [Tooltip("The TextMeshPro object you want to change.")]
        public TextMeshProUGUI textObject;

        [Tooltip("The Outline Width of the TextMeshPro object.")]
        public float outlineWidth;

        // Code that runs on entering the state.
        public override void OnEnter()
		{
			textObject.outlineWidth = outlineWidth;
			Finish();
		}


	}

}
