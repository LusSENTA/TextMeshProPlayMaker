// Developed by Lus SENTA (2024). Licensed under MIT License
using TMPro;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{

	[ActionCategory("TextMeshPro")]
	[Tooltip("Set Face Color of a TextMeshPro object.")]
	public class SetFaceColorTMP : FsmStateAction
	{

        // Get TextMeshPro object
        [RequiredField]
        [Tooltip("The TextMeshPro object you want to change.")]
        public TextMeshProUGUI textObject;

        // Get RGBA values
        [Tooltip("The Face Color of the TextMeshPro object.")]
        public int faceColorRed;
        public int faceColorGreen;
        public int faceColorBlue;
        public int faceColorAlpha;

        // Code that runs on entering the state.
        public override void OnEnter()
		{

            // Convert Int to Byte
            byte bColor1 = (byte)faceColorRed;
            byte bColor2 = (byte)faceColorGreen;
            byte bColor3 = (byte)faceColorBlue;
            byte bColor4 = (byte)faceColorAlpha;

            // Set TextMeshPro object Face Color
            textObject.faceColor = new Color32(bColor1, bColor2, bColor3, bColor4);
            Finish();
		}


	}

}
