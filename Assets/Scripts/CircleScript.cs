using UnityEngine;
using System.Collections;

public class CircleScript : MonoBehaviour {
	public static CircleScript Circle;
	public bool isSuceess;
	public bool isMoving;
	// Use this for initialization
	void Start () {
		Circle = this;
		isSuceess = false;
		isMoving = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (isSuceess) {
			Debug.Log ("You Win!");
		}
	}
}
