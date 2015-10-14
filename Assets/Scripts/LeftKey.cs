using UnityEngine;
using System.Collections;

public class LeftKey : MonoBehaviour {
	private GameObject Parent_BLOCK;
	
	private Vector3 ICE_BLOCK1Pos;
	private Vector3 ICE_BLOCK2Pos;
	private Vector3 ICE_BLOCK3Pos;
	
	private bool clicked;
	private float destination;
	private float speed;
	// Use this for initialization
	void Start () {
		speed = 1.5f;
		clicked = false;
	}
	
	// Update is called once per frame
	void Update () {
		Parent_BLOCK = this.transform.parent.gameObject;
		Vector3 newpos = Parent_BLOCK.transform.position;
		if (clicked) {
			if ((destination - 0.05f) <= newpos.x && newpos.x <= (destination + 0.05f)) {
				newpos.x = destination;
				Parent_BLOCK.transform.position = newpos;
				destination = 0.0f;
				clicked = false;
				CircleScript.Circle.isMoving = false;
				if (newpos.x == -1.5f && newpos.y == 0.5f) {
					CircleScript.Circle.isSuceess = true;
				}
			} else {
				newpos.x -= speed * Time.deltaTime;
				Parent_BLOCK.transform.position = newpos;
				Debug.Log (destination);
			}
		}
	}

	void OnMouseDown ()
	{
		if (CircleScript.Circle.isMoving) {
			return;
		}
		CircleScript.Circle.isMoving = true;

		Debug.Log ("left");
		
		Parent_BLOCK = this.transform.parent.gameObject;
		//Debug.Log (Parent_BLOCK.transform.position);
		
		ICE_BLOCK1Pos = GameObject.Find("ICE_FINAL1").transform.position;
		ICE_BLOCK2Pos = GameObject.Find("ICE_FINAL2").transform.position;
		ICE_BLOCK3Pos = GameObject.Find("ICE_FINAL3").transform.position;
		
		if (Parent_BLOCK.transform.position == ICE_BLOCK1Pos) {
			//Debug.Log ("I'm here");
			float block1x = ICE_BLOCK1Pos.x;
			float block2x = ICE_BLOCK2Pos.x;
			float block3x = ICE_BLOCK3Pos.x;
			
			if (block2x >= block1x && block3x >= block1x) {
				destination = -6.5f;
			} else if (block2x >= block1x && block3x < block1x) {
				if (ICE_BLOCK1Pos.y == ICE_BLOCK3Pos.y) {
					destination = block3x + 2.5f;
				} else {
					destination = -6.5f;
				}
			} else if (block2x < block1x && block3x >= block1x) {
				if (ICE_BLOCK1Pos.y == ICE_BLOCK2Pos.y) {
					destination = block2x + 2.5f;
				} else {
					destination = -6.5f;
				}
			} else {
				if (ICE_BLOCK1Pos.y == ICE_BLOCK2Pos.y) {
					destination = block2x + 2.5f;
				} else if (ICE_BLOCK1Pos.y == ICE_BLOCK3Pos.y) {
					destination = block3x + 2.5f;
				} else {
					destination = -6.5f;
				}
			}
		} 
		else if (Parent_BLOCK.transform.position == ICE_BLOCK2Pos) {
			float block1x = ICE_BLOCK1Pos.x;
			float block2x = ICE_BLOCK2Pos.x;
			float block3x = ICE_BLOCK3Pos.x;
			
			if (block1x >= block2x && block3x >= block2x) {
				destination = -6.5f;
			} else if (block1x >= block2x && block3x < block2x) {
				if (ICE_BLOCK2Pos.y == ICE_BLOCK3Pos.y) {
					destination = block3x + 2.5f;
				} else {
					destination = -6.5f;
				}
			} else if (block1x < block2x && block3x >= block2x) {
				if (ICE_BLOCK2Pos.y == ICE_BLOCK1Pos.y) {
					destination = block1x + 2.5f;
				} else {
					destination = -6.5f;
				}
			} else {
				if (ICE_BLOCK2Pos.y == ICE_BLOCK1Pos.y) {
					destination = block1x + 2.5f;
				} else if (ICE_BLOCK2Pos.y == ICE_BLOCK3Pos.y) {
					destination = block3x + 2.5f;
				} else {
					destination = -6.5f;
				}
			}	
		} 
		else if (Parent_BLOCK.transform.position == ICE_BLOCK3Pos) {
			float block1x = ICE_BLOCK1Pos.x;
			float block2x = ICE_BLOCK2Pos.x;
			float block3x = ICE_BLOCK3Pos.x;
			
			if (block2x >= block3x && block1x >= block3x) {
				destination = -6.5f;
			} else if (block1x >= block3x && block2x < block3x) {
				if (ICE_BLOCK3Pos.y == ICE_BLOCK2Pos.y) {
					destination = block2x + 2.5f;
				} else {
					destination = -6.5f;
				}
			} else if (block1x < block3x && block2x >= block3x) {
				if (ICE_BLOCK3Pos.y == ICE_BLOCK1Pos.y) {
					destination = block1x + 2.5f;
				} else {
					destination = -6.5f;
				}
			} else {
				if (ICE_BLOCK3Pos.y == ICE_BLOCK1Pos.y) {
					destination = block1x + 2.5f;
				} else if (ICE_BLOCK3Pos.y == ICE_BLOCK2Pos.y) {
					destination = block2x + 2.5f;
				} else {
					destination = -6.5f;
				}
			}	
		} 
		else {
			Debug.Log ("Bad...");
		}
		
		clicked = true;
		Debug.Log (destination);
	}
}
