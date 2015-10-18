
using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
    public bool wasdControls;

    float speed = 5.0f;
	float moveX = 0;
	float moveY = 0;
    float acceleration = 0.1f;
	public GameObject player;
	public Rigidbody2D projectile;
	public float interval;
	float lastFired;
	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player1");
	}

    // Update is called once per frame
    void Update() {
        bool left = wasdControls ? Input.GetKey(KeyCode.A) : Input.GetKey(KeyCode.LeftArrow);
        bool right = wasdControls ? Input.GetKey(KeyCode.D) : Input.GetKey(KeyCode.RightArrow);
        bool down = wasdControls ? Input.GetKey(KeyCode.S) : Input.GetKey(KeyCode.DownArrow);
        bool up = wasdControls ? Input.GetKey(KeyCode.W) : Input.GetKey(KeyCode.UpArrow);
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
		if (Input.GetKeyUp (KeyCode.RightControl) && Time.time > lastFired + interval) {
			Instantiate (projectile, player.transform.position, player.transform.rotation);
			lastFired = Time.time;
		}

	}
}

