// Developed by Lus SENTA (2024). Licensed under MIT License
using TMPro;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{

	[ActionCategory("TextMeshPro")]
	[Tooltip("Set Outline Width of a TextMeshPro object.")]
	public class SetOutlineWidthTMP : FsmStateAction
	{

        // Get TextMeshPro object
        [RequiredField]
        [Tooltip("The TextMeshPro object you want to change.")]
        public TextMeshProUGUI textObject;

		// Get width as float
		[Tooltip("The Outline Width of the TextMeshPro object.")]
		public FsmFloat outlineWidth;

        // Set TextMeshPro object Outline Width
        public override void OnEnter()
		{
			float width = outlineWidth.Value;
			textObject.outlineWidth = width;
			Finish();
		}


	}

}
