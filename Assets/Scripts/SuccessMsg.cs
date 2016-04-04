using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SuccessMsg: MonoBehaviour {
	Text SucceeText;

	// Use this for initialization
	void Start () {
		SucceeText = this.GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (CircleScript.Circle.isSuceess) {
			Debug.Log(SucceeText.text);
			SucceeText.text = "YOU WIN!";
		}
	}
}
