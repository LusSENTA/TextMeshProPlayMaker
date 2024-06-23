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

        // Get text
        [UIHint(UIHint.TextArea)]
        [Tooltip("The text of the TextMeshPro object.")]
        public string setText;

        // Set color Y/N
        public bool color;

        // Get RGBA values
        [Tooltip("The Face Color of the TextMeshPro object.")]
        public int textColorRed;
        public int textColorGreen;
        public int textColorBlue;
        public int textColorAlpha;

        // Set TextMeshPro object to entered text
        public override void OnEnter()
		{
            textObject.text = setText;
            Finish();

            if (color)
            {
                byte bColor1 = (byte)textColorRed;
                byte bColor2 = (byte)textColorGreen;
                byte bColor3 = (byte)textColorBlue;
                byte bColor4 = (byte)textColorAlpha;

                textObject.color = new Color32(bColor1, bColor2, bColor3, bColor4);
                Finish();

            }
        }


	}

}
