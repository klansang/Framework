using UnityEngine;
using System.Collections;

public class Movement_Kasra : MonoBehaviour {

    //Variables to be set in Unity Editor
    public float moveSpeed;
    public float jumpHeight;
    public float slideSpeed;
    public LayerMask walls;

    //Private variables
    float move; //Is set each frame based on the movement keys or joypad. Between -1 & 1.

    //Constants
    const string jumpButton = "space"; //Button that is assigned to jumping

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {

        //Horizontal movement
        move = Input.GetAxis("Horizontal");
        move *= moveSpeed * Time.deltaTime * 100; //Delta time is used to set speed by time rather than frames.
        moveX(move);

        //Jumping
        if(Input.GetKeyDown(jumpButton) && GetComponent<Rigidbody2D>().velocity.y == 0)
        {
            jump(jumpHeight);
        }

        //Wall Interactions
        if(GetComponent<Rigidbody2D>().IsTouchingLayers(walls))
        {
            jump(GetComponent<Rigidbody2D>().velocity.y / slideSpeed);
        }

	}

    //Horizontal Movement
    void moveX (float velocity)
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(velocity, GetComponent<Rigidbody2D>().velocity.y);
    }

    //Jumping (Not vertical movement)
    void jump (float jumpSpeed)
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpSpeed);
    }
}
