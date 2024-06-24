// Developed by Lus SENTA (2024). Licensed under MIT License
using TMPro;
using HutongGames.PlayMaker;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{

	[ActionCategory("TextMeshPro")]
    [Tooltip("Set Text of a TextMeshPro object.")]
    public class SetTextTMP : FsmStateAction
	{

        // Get TextMeshPro object
        [RequiredField]
        [Tooltip("The TextMeshPro object you want to change.")]
        public TextMeshProUGUI textObject;

        // Get text or variable
        [UIHint(UIHint.TextArea)]
        [Tooltip("The text of the TextMeshPro object.")]
        public FsmString Text;

        // Set color Y/N
        [Tooltip("When enabled text color will be set.")]
        public bool setColor;

        // Get RGBA values
        [Tooltip("The Face Color of the TextMeshPro object.")]
        public FsmInt red;
        public FsmInt green;
        public FsmInt blue;
        public FsmInt alpha;

        // Set TextMeshPro object to entered text
        public override void OnEnter()
		{
            // Convert Fsm Vaiables to Standard Variables
            string setText = Text.Value;
            int textColorRed = red.Value;
            int textColorGreen = green.Value;
            int textColorBlue = blue.Value;
            int textColorAlpha = alpha.Value;

            textObject.text = setText;

            if (setColor)
            {
                byte bColor1 = (byte)textColorRed;
                byte bColor2 = (byte)textColorGreen;
                byte bColor3 = (byte)textColorBlue;
                byte bColor4 = (byte)textColorAlpha;

                textObject.color = new Color32(bColor1, bColor2, bColor3, bColor4);

            }

            Finish();
        }


	}

}
