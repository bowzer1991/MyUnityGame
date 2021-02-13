
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float speedScaler = 5f;

    public float rotateSpeed = 3.0f;

    public bool isWalking = false;
    public bool isIdle = true;
    public bool isRunning = false;

    public float horizontal;
    public float vertical;

    private float walk = 0.333f;
    private float run = 0.744f;
    private float sprint = 1.0f;
    private float rwalk = 0.1f;

    private void Start()
    {
        speed = 0f;
    }
    // Update is called once per frame
    void LateUpdate()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        Move();
    }

    private void Move()
    {
        Vector3 move = new Vector3(horizontal, 0.0f, vertical);
        if (move.x == 0f && move.z == 0f) // if a button isn't being pressed on both virtual axis then
        {
            isWalking = false; // we aren't walking
            isIdle = true; // we are stood still/idle
            isRunning = false; // we aren't running
        }

        if (move.z > 0f) // if we're pressing forward on the vertical axies 
        {
            isIdle = false; // we aren't idle anymore
            speed = walk; // we need some form of speed even if it's update later
        }

        if (Input.GetKey(KeyCode.LeftShift)) // if we hold left shift 
        {
            speed = run; // Increase our speed
            isRunning = true; // We are now running
            isWalking = false; // we aren't walking
        }

        if (Input.GetKeyUp(KeyCode.LeftShift)) // If we let go of left shift
        {
            speed = walk; // reset back to walk speed
            isRunning = false; // we aren't  running anymore
            isWalking = true; // we are assuming we are walking again
        }
        if (Input.GetKey(KeyCode.S)) // If we press S then we need to set speed to rwalk (reverse walk)
        {
            speed = rwalk; // set to reverse walk speed
            isRunning = false; // we aren't running anymore
            isWalking = true; // we are assuming we are walking again
        }

        transform.Translate(move * (speed * speedScaler) * Time.deltaTime);

        //if (Input.GetKeyDown(KeyCode.W) && !Input.GetKeyDown(KeyCode.LeftShift)) // If we press W and left shift isn't held set variables
        //{
        //    speed = 0.333f;
        //    isWalking = true;
        //    isIdle = false;
        //    isRunning = true;
        //}
        //if (Input.GetKeyDown(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.W)) // If left shift is held down we run
        //{
        //    speed = 0.666f;
        //    isWalking = false;
        //    isIdle = false;
        //    isRunning = true;
        //}
        //if (Input.GetKeyUp(KeyCode.LeftShift)) // If left shift is comes up reset the speed
        //{
        //    speed = 0.333f;
        //    isWalking = true;
        //    isIdle = false;
        //    isRunning = false;
        //}

        // Move


        // Rotate

        // Move Backwards

        // Strafe Left

        // Strafe Right
    }
}
