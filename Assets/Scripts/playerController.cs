using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour {
	private Vector3 playerPos = new Vector3 (0.0f, 0.0f, 0.0f); 
	private Vector3 ICE1 = new Vector3(0.0f, 0.0f, 0.0f);
	private Vector3 ICE2 = new Vector3(0.0f, 0.0f, 0.0f);
	private Vector3 ICE3 = new Vector3(0.0f, 0.0f, 0.0f);

	private float Speed;
	private float Destination;

	// Use this for initialization
	void Start () {
		playerPos = this.transform.localPosition;
		ICE1 = GameObject.Find ("ICE1").transform.localPosition;
		ICE2 = GameObject.Find ("ICE2").transform.localPosition;
		ICE3 = GameObject.Find ("ICE3").transform.localPosition;
		Speed = 1.25f;
		Debug.Log (playerPos);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.DownArrow) && playerPos.y > -4.0f) {
			if (ICE1.x == playerPos.x && ICE1.y == playerPos.y-2.0f) {
				if (ICE1.x == ICE2.x && ICE2.x == ICE3.x) {
					Destination = ICE1.x;
				}
				else if (ICE1.x == ICE2.x && ICE1.y > ICE2.y) {
					Destination = ICE2.y + 2.0f;
				} 
				else if (ICE1.x == ICE3.x && ICE1.y > ICE3.y) {
					Destination = ICE3.y + 2.0f;
				}
				else {
					Destination = -2.0f;
				}
				while (ICE1.y > Destination) {
					ICE1.y -= Speed*Time.deltaTime;
					GameObject.Find("ICE1").transform.localPosition = ICE1;
				}
				ICE1.y = Destination;
				GameObject.Find("ICE1").transform.localPosition = ICE1;
			}
			else if (ICE2.x == playerPos.x && ICE2.y == playerPos.y-2.0f) {
				if (ICE1.x == ICE2.x && ICE2.x == ICE3.x) {
					Destination = ICE2.x;
				}
				else if (ICE2.x == ICE1.x && ICE2.y > ICE1.y) {
					Destination = ICE1.y + 2.0f;
				} 
				else if (ICE2.x == ICE3.x && ICE2.y > ICE3.y) {
					Destination = ICE3.y + 2.0f;
				}
				else {
					Destination = -2.0f;
				}
				while (ICE2.y > Destination) {
					ICE2.y -= Speed*Time.deltaTime;
					GameObject.Find("ICE2").transform.localPosition = ICE2;
				}
				ICE2.y = Destination;
				GameObject.Find("ICE2").transform.localPosition = ICE2;
			}
			else if (ICE3.x == playerPos.x && ICE3.y == playerPos.y-2.0f) {
				if (ICE1.x == ICE2.x && ICE2.x == ICE3.x) {
					Destination = ICE3.x;
				}
				else if (ICE3.x == ICE1.x && ICE3.y > ICE1.y) {
					Destination = ICE1.y + 2.0f;
				} 
				else if (ICE3.x == ICE2.x && ICE3.y > ICE2.y) {
					Destination = ICE2.y + 2.0f;
				}
				else {
					Destination = -2.0f;
				}
				while (ICE3.y > Destination) {
					ICE3.y -= Speed*Time.deltaTime;
					GameObject.Find("ICE3").transform.localPosition = ICE3;
				}
				ICE3.y = Destination;
				GameObject.Find("ICE3").transform.localPosition = ICE3;
			}
			else {
				playerPos.y -= 2.0f;
				this.transform.localPosition = playerPos;
			}
			Destination = 0.0f;
		} 
		else if (Input.GetKeyDown (KeyCode.UpArrow) && playerPos.y < 4.0f) {
			if (ICE1.x == playerPos.x && ICE1.y == playerPos.y+2.0f) {
				if (ICE1.x == ICE2.x && ICE2.x == ICE3.x) {
					Destination = ICE1.x;
				}
				else if (ICE1.x == ICE2.x && ICE1.y < ICE2.y) {
					Destination = ICE2.y - 2.0f;
				} 
				else if (ICE1.x == ICE3.x && ICE1.y < ICE3.y) {
					Destination = ICE3.y - 2.0f;
				}
				else {
					Destination = 2.0f;
				}
				while (ICE1.y < Destination) {
					ICE1.y += Speed*Time.deltaTime;
					GameObject.Find("ICE1").transform.localPosition = ICE1;
				}
				ICE1.y = Destination;
				GameObject.Find("ICE1").transform.localPosition = ICE1;
			}
			else if (ICE2.x == playerPos.x && ICE2.y == playerPos.y+2.0f) {
				if (ICE1.x == ICE2.x && ICE2.x == ICE3.x) {
					Destination = ICE2.x;
				}
				else if (ICE2.x == ICE1.x && ICE2.y < ICE1.y) {
					Destination = ICE1.y - 2.0f;
				} 
				else if (ICE2.x == ICE3.x && ICE2.y < ICE3.y) {
					Destination = ICE3.y - 2.0f;
				}
				else {
					Destination = 2.0f;
				}
				while (ICE2.y < Destination) {
					ICE2.y += Speed*Time.deltaTime;
					GameObject.Find("ICE2").transform.localPosition = ICE2;
				}
				ICE2.y = Destination;
				GameObject.Find("ICE2").transform.localPosition = ICE2;
			}
			else if (ICE3.x == playerPos.x && ICE3.y == playerPos.y+2.0f) {
				if (ICE1.x == ICE2.x && ICE2.x == ICE3.x) {
					Destination = ICE3.x;
				}
				else if (ICE3.x == ICE1.x && ICE3.y < ICE1.y) {
					Destination = ICE1.y - 2.0f;
				} 
				else if (ICE3.x == ICE2.x && ICE3.y < ICE2.y) {
					Destination = ICE2.y - 2.0f;
				}
				else {
					Destination = 2.0f;
				}
				while (ICE3.y < Destination) {
					ICE3.y += Speed*Time.deltaTime;
					GameObject.Find("ICE3").transform.localPosition = ICE3;
				}
				ICE3.y = Destination;
				GameObject.Find("ICE3").transform.localPosition = ICE3;
			}
			else {
				playerPos.y += 2.0f;
				this.transform.localPosition = playerPos;
			}
			Destination = 0.0f;
		} 
		else if (Input.GetKeyDown (KeyCode.LeftArrow) && playerPos.x > -6.5f) {
			if (ICE1.y == playerPos.y && ICE1.x == playerPos.x-2.0f) {
				if (ICE1.y == ICE2.y && ICE2.y == ICE3.y) {
					if (ICE2.x > ICE3.x) {
						Destination = ICE2.x + 2.0f;
					}
					else {
						Destination = ICE3.x + 2.0f;
					}
				}
				else if (ICE1.y == ICE2.y && ICE1.x > ICE2.x) {
					Destination = ICE2.x + 2.0f;
				} 
				else if (ICE1.y == ICE3.y && ICE1.x > ICE3.x) {
					Destination = ICE3.x + 2.0f;
				}
				else {
					Destination = -4.5f;
				}
				while (ICE1.x > Destination) {
					ICE1.x -= Speed*Time.deltaTime;
					GameObject.Find("ICE1").transform.localPosition = ICE1;
				}
				ICE1.x = Destination;
				GameObject.Find("ICE1").transform.localPosition = ICE1;
			}
			else if (ICE2.y == playerPos.y && ICE2.x == playerPos.x-2.0f) {
				if (ICE1.y == ICE2.y && ICE2.y == ICE3.y) {
					if (ICE1.x > ICE3.x) {
						Destination = ICE1.x + 2.0f;
					}
					else {
						Destination = ICE3.x + 2.0f;
					}
				}
				else if (ICE2.y == ICE1.y && ICE2.x > ICE1.x) {
					Destination = ICE1.x + 2.0f;
				} 
				else if (ICE2.y == ICE3.y && ICE2.x > ICE3.x) {
					Destination = ICE3.x + 2.0f;
				}
				else {
					Destination = -4.5f;
				}
				while (ICE2.x > Destination) {
					ICE2.x -= Speed*Time.deltaTime;
					GameObject.Find("ICE2").transform.localPosition = ICE2;
				}
				ICE2.x = Destination;
				GameObject.Find("ICE2").transform.localPosition = ICE2;
			}
			else if (ICE3.y == playerPos.y && ICE3.x == playerPos.x-2.0f) {
				if (ICE1.y == ICE2.y && ICE2.y == ICE3.y) {
					if (ICE2.x > ICE1.x) {
						Destination = ICE2.x + 2.0f;
					}
					else {
						Destination = ICE1.x + 2.0f;
					}
				}
				else if (ICE3.y == ICE1.y && ICE3.x > ICE1.x) {
					Destination = ICE1.x + 2.0f;
				} 
				else if (ICE3.y == ICE2.y && ICE3.x > ICE2.x) {
					Destination = ICE2.x + 2.0f;
				}
				else {
					Destination = -4.5f;
				}
				while (ICE3.x > Destination) {
					ICE3.x -= Speed*Time.deltaTime;
					GameObject.Find("ICE3").transform.localPosition = ICE3;
				}
				ICE3.x = Destination;
				GameObject.Find("ICE3").transform.localPosition = ICE3;
			}
			else {
				playerPos.x -= 2.0f;
				this.transform.localPosition = playerPos;
			}
			Destination = 0.0f;
		} 
		else if (Input.GetKeyDown (KeyCode.RightArrow) && playerPos.x < 5.5f) {
			if (ICE1.y == playerPos.y && ICE1.x == playerPos.x+2.0f) {
				if (ICE1.y == ICE2.y && ICE2.y == ICE3.y) {
					if (ICE2.x < ICE3.x) {
						Destination = ICE2.x - 2.0f;
					}
					else {
						Destination = ICE3.x - 2.0f;
					}
				}
				else if (ICE1.y == ICE2.y && ICE1.x < ICE2.x) {
					Destination = ICE2.x - 2.0f;
				} 
				else if (ICE1.y == ICE3.y && ICE1.x < ICE3.x) {
					Destination = ICE3.x - 2.0f;
				}
				else {
					Destination = 3.5f;
				}
				while (ICE1.x < Destination) {
					ICE1.x += Speed*Time.deltaTime;
					GameObject.Find("ICE1").transform.localPosition = ICE1;
				}
				ICE1.x = Destination;
				GameObject.Find("ICE1").transform.localPosition = ICE1;
			}
			else if (ICE2.y == playerPos.y && ICE2.x == playerPos.x+2.0f) {
				if (ICE1.y == ICE2.y && ICE2.y == ICE3.y) {
					if (ICE1.x < ICE3.x) {
						Destination = ICE1.x - 2.0f;
					}
					else {
						Destination = ICE3.x - 2.0f;
					}
				}
				else if (ICE2.y == ICE1.y && ICE2.x < ICE1.x) {
					Destination = ICE1.x - 2.0f;
				} 
				else if (ICE2.y == ICE3.y && ICE2.x < ICE3.x) {
					Destination = ICE3.x - 2.0f;
				}
				else {
					Destination = 3.5f;
				}
				while (ICE2.x < Destination) {
					ICE2.x += Speed*Time.deltaTime;
					GameObject.Find("ICE2").transform.localPosition = ICE2;
				}
				ICE2.x = Destination;
				GameObject.Find("ICE2").transform.localPosition = ICE2;
			}
			else if (ICE3.y == playerPos.y && ICE3.x == playerPos.x+2.0f) {
				if (ICE1.y == ICE2.y && ICE2.y == ICE3.y) {
					if (ICE2.x < ICE1.x) {
						Destination = ICE2.x - 2.0f;
					}
					else {
						Destination = ICE1.x - 2.0f;
					}
				}
				else if (ICE3.y == ICE1.y && ICE3.x < ICE1.x) {
					Destination = ICE1.x - 2.0f;
				} 
				else if (ICE3.y == ICE2.y && ICE3.x < ICE2.x) {
					Destination = ICE2.x - 2.0f;
				}
				else {
					Destination = 3.5f;
				}
				while (ICE3.x < Destination) {
					ICE3.x += Speed*Time.deltaTime;
					GameObject.Find("ICE3").transform.localPosition = ICE3;
				}
				ICE3.x = Destination;
				GameObject.Find("ICE3").transform.localPosition = ICE3;
			}
			else {
				playerPos.x += 2.0f;
				this.transform.localPosition = playerPos;
			}
			Destination = 0.0f;
		}

		if ((ICE1.x==-0.5f && ICE1.y==0.0f) || (ICE2.x==-0.5f && ICE2.y==0.0f) || (ICE3.x==-0.5f && ICE3.y==0.0f)) {
			CircleScript.Circle.isSuceess = true;
		}
	}
}
