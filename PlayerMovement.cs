using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	float speed;
	float moveX=0;
	float moveY=0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.LeftArrow)
		   		moveX = -1;
		else if (Input.GetKey(KeyCode.RightArrow)
		   		moveX = 1;
		else 
		         moveX = 0;
		if (Input.GetKey(KeyCode.DownArrow)
		   		moveY = -1;
		else if (Input.GetKey(KeyCode.UpArrow)
		   		moveY = 1;
		else 
		         moveY =0;
		}
	void FixedUpdate(){

			rigidbody2D.velocity = new Vector2 (moveX * speed, moveY * speed);
		
		
		
		}



	}
}
