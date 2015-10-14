using UnityEngine;
using System.Collections;

public class DownKey : MonoBehaviour {
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
			if ((destination - 0.05f) <= newpos.y && newpos.y <= (destination + 0.05f)) {
				newpos.y = destination;
				Parent_BLOCK.transform.position = newpos;
				destination = 0.0f;
				clicked = false;
				CircleScript.Circle.isMoving = false;
				if (newpos.x == -1.5f && newpos.y == 0.5f) {
					CircleScript.Circle.isSuceess = true;
				}
			} else {
				newpos.y -= speed * Time.deltaTime;
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

		Debug.Log ("down");
		
		Parent_BLOCK = this.transform.parent.gameObject;
		//Debug.Log (Parent_BLOCK.transform.position);
		
		ICE_BLOCK1Pos = GameObject.Find("ICE_FINAL1").transform.position;
		ICE_BLOCK2Pos = GameObject.Find("ICE_FINAL2").transform.position;
		ICE_BLOCK3Pos = GameObject.Find("ICE_FINAL3").transform.position;
		
		if (Parent_BLOCK.transform.position == ICE_BLOCK1Pos) {
			//Debug.Log ("I'm here");
			float block1y = ICE_BLOCK1Pos.y;
			float block2y = ICE_BLOCK2Pos.y;
			float block3y = ICE_BLOCK3Pos.y;
			
			if (block2y >= block1y && block3y >= block1y) {
				destination = -2.0f;
			} else if (block2y >= block1y && block3y < block1y) {
				if (ICE_BLOCK1Pos.x == ICE_BLOCK3Pos.x) {
					destination = block3y + 2.5f;
				} else {
					destination = -2.0f;
				}
			} else if (block2y < block1y && block3y >= block1y) {
				if (ICE_BLOCK1Pos.x == ICE_BLOCK2Pos.x) {
					destination = block2y + 2.5f;
				} else {
					destination = -2.0f;
				}
			} else {
				if (ICE_BLOCK1Pos.x == ICE_BLOCK2Pos.x) {
					destination = block2y + 2.5f;
				} else if (ICE_BLOCK1Pos.x == ICE_BLOCK3Pos.x) {
					destination = block3y + 2.5f;
				} else {
					destination = -2.0f;
				}
			}
		} 
		else if (Parent_BLOCK.transform.position == ICE_BLOCK2Pos) {
			float block1y = ICE_BLOCK1Pos.y;
			float block2y = ICE_BLOCK2Pos.y;
			float block3y = ICE_BLOCK3Pos.y;
			
			if (block1y >= block2y && block3y >= block2y) {
				destination = -2.0f;
			} else if (block1y >= block2y && block3y < block2y) {
				if (ICE_BLOCK2Pos.x == ICE_BLOCK3Pos.x) {
					destination = block3y + 2.5f;
				} else {
					destination = -2.0f;
				}
			} else if (block1y < block2y && block3y >= block2y) {
				if (ICE_BLOCK2Pos.x == ICE_BLOCK1Pos.x) {
					destination = block1y + 2.5f;
				} else {
					destination = -2.0f;
				}
			} else {
				if (ICE_BLOCK2Pos.x == ICE_BLOCK1Pos.x) {
					destination = block1y + 2.5f;
				} else if (ICE_BLOCK2Pos.x == ICE_BLOCK3Pos.x) {
					destination = block3y + 2.5f;
				} else {
					destination = -2.0f;
				}
			}	
		} 
		else if (Parent_BLOCK.transform.position == ICE_BLOCK3Pos) {
			float block1y = ICE_BLOCK1Pos.y;
			float block2y = ICE_BLOCK2Pos.y;
			float block3y = ICE_BLOCK3Pos.y;
			
			if (block2y >= block3y && block1y >= block3y) {
				destination = -2.0f;
			} else if (block1y >= block3y && block2y < block3y) {
				if (ICE_BLOCK3Pos.x == ICE_BLOCK2Pos.x) {
					destination = block2y + 2.5f;
				} else {
					destination = -2.0f;
				}
			} else if (block1y < block3y && block2y >= block3y) {
				if (ICE_BLOCK3Pos.x == ICE_BLOCK1Pos.x) {
					destination = block1y + 2.5f;
				} else {
					destination = -2.0f;
				}
			} else {
				if (ICE_BLOCK3Pos.x == ICE_BLOCK1Pos.x) {
					destination = block1y + 2.5f;
				} else if (ICE_BLOCK3Pos.x == ICE_BLOCK2Pos.x) {
					destination = block2y + 2.5f;
				} else {
					destination = -2.0f;
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
