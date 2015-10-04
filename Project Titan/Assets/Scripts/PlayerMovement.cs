
using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	float speed = 5.0f;
	float moveX = 0;
	float moveY = 0;
    float acceleration = 0.1f;
	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update() {
        bool left = Input.GetKey(KeyCode.LeftArrow);
        bool right = Input.GetKey(KeyCode.RightArrow);
        bool down = Input.GetKey(KeyCode.DownArrow);
        bool up = Input.GetKey(KeyCode.UpArrow);
        if(left == right)
        {
            moveX = 0;
        }
        else if (left)
        {
            moveX = Mathf.Max(moveX - acceleration, -1);
        }
        else if (right)
        {
            moveX = Mathf.Min(moveX + acceleration, 1);
        }

        if(down == up)
        {
            moveY = 0;
        }
        else if (down)
        {
            moveY = Mathf.Max(moveY - acceleration, -1);
        }
        else if (up)
        {
            moveY = Mathf.Min(moveY + acceleration, 1);
        }
	}
	void FixedUpdate(){
			GetComponent<Rigidbody2D>().velocity = new Vector2 (moveX * speed, moveY * speed);
	}
}

