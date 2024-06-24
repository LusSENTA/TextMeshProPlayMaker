// Developed by Lus SENTA (2024). Licensed under MIT License
using TMPro;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{

	[ActionCategory("TextMeshPro")]
	[Tooltip("Set Outline Color of a TextMeshPro object.")]
	public class SetOutlineColorTMP : FsmStateAction
	{

        // Get TextMeshPro object
        [RequiredField]
        [Tooltip("The TextMeshPro object you want to change.")]
        public TextMeshProUGUI textObject;

        // Get RGBA values
        [Tooltip("The Outline Color of the TextMeshPro object.")]
        public FsmInt red;
        public FsmInt green;
        public FsmInt blue;
        public FsmInt alpha;

        // Code that runs on entering the state.
        public override void OnEnter()
		{
            // Convert Fsm Vaiables to Standard Variables
            int outlineColorRed = red.Value;
            int outlineColorGreen = green.Value;
            int outlineColorBlue = blue.Value;
            int outlineColorAlpha = alpha.Value;

            // Convert Int to Byte
            byte bColor1 = (byte)outlineColorRed;
            byte bColor2 = (byte)outlineColorGreen;
            byte bColor3 = (byte)outlineColorBlue;
            byte bColor4 = (byte)outlineColorAlpha;

            // Set TextMeshPro object Outline Color
            textObject.outlineColor = new Color32(bColor1, bColor2, bColor3, bColor4);
            Finish();
		}


	}

}
