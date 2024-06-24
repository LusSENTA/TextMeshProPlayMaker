// Developed by Lus SENTA (2024). Licensed under MIT License
using TMPro;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{

	[ActionCategory("TextMeshPro")]
    [Tooltip("Set Text Color of a TextMeshPro object.")]
    public class SetColorTMP : FsmStateAction
	{

        // Get TextMeshPro object
        [RequiredField]
        [Tooltip("The TextMeshPro object you want to change.")]
        public TextMeshProUGUI textObject;

        // Get RGBA values
        [Tooltip("The Color of the TextMeshPro object.")]
        public FsmInt red;
        public FsmInt green;
        public FsmInt blue;
        public FsmInt alpha;

        // Code that runs on entering the state.
        public override void OnEnter()
		{
            // Convert Fsm Vaiables to Standard Variables
            int textColorRed = red.Value;
            int textColorGreen = green.Value;
            int textColorBlue = blue.Value;
            int textColorAlpha = alpha.Value;

            // Convert Int to Byte
            byte bColor1 = (byte)textColorRed;
            byte bColor2 = (byte)textColorGreen;
            byte bColor3 = (byte)textColorBlue;
            byte bColor4 = (byte)textColorAlpha;

            //byte bColor1 = System.Convert.ToByte(textColor1);
            //textObject.color = Color.green;

            // Set TextMeshPro object Color
            textObject.color = new Color32(bColor1, bColor2, bColor3, bColor4);
            Finish();
		}


	}

}
