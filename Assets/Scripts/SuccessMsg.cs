using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SuccessMsg : MonoBehaviour {
	Text SucceeText;

	// Use this for initialization
	void Start () {
		SucceeText = gameObject.GetComponent<Text> ();
		SucceeText.text = "";
	}
	
	// Update is called once per frame
	void Update () {
		if (CircleScript.Circle.isSuceess) {
			SucceeText.text = "CONGRATULATIONS! YOU WIN!";
		}
	}
}
