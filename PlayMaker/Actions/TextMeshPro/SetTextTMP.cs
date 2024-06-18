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
        [RequiredField]
        [Tooltip("The TextMeshPro object you want to change.")]
        public TextMeshProUGUI textObject;

        [UIHint(UIHint.TextArea)]
        [Tooltip("The text of the TextMeshPro object.")]
        public string setText;

        // Set TextMeshPro object to entered text
        public override void OnEnter()
		{
            textObject.text = setText;
            Finish();
		}


	}

}
