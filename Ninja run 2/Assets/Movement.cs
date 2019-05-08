using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    /// <summary>
    /// The
    /// </summary>
    private int movementSpeed=6;
    Animator animate;
    // Use this for initialization
    void Start() {
        animate = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update() {

        //moveLeft();
        animate.SetBool("Running", false);

        if (Input.GetKey(KeyCode.A)  /*Input.GetKey(KeyCode.LeftArrow)*/)
        {
            moveLeft();
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            moveLeft();
        }

        if (Input.GetKey(KeyCode.D)  /*Input.GetKey(KeyCode.RightArrow)*/)
        {
            moveRight();
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            moveRight();
        }
        if (Input.GetKey(KeyCode.W)  /*Input.GetKey(KeyCode.UpArrow)*/)
        {
            moveForward();
        
        }
   
       

        if (Input.GetKey(KeyCode.UpArrow))
        {
            moveForward();
        }
        if (Input.GetKey(KeyCode.S)  /*Input.GetKey(KeyCode.DownArrow)*/)
        {
            moveBackward();
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            moveBackward();
        }
     


    }

    /// <summary>
    /// When the w key or up arrow key is pressed the player character will move forward
    /// </summary>
    public void moveForward()
    {
        transform.rotation = Quaternion.LookRotation(Vector3.forward);
        transform.position += movementSpeed * Vector3.forward * Time.deltaTime;
        animate.SetBool("Running", true);
    }

    /// <summary>
    /// When the s key or down arrow key is pressed the player character will move backwords
    /// </summary>
    public void moveBackward()
    {
        transform.rotation = Quaternion.LookRotation(Vector3.back);
        transform.position -= movementSpeed * Vector3.forward * Time.deltaTime;
        animate.SetBool("Running", true);
    }

    /// <summary>
    /// When the a key or left arrow key is pressed the player character will move left
    /// </summary>
    public void moveLeft()
    {
        transform.rotation = Quaternion.LookRotation(Vector3.left);
        transform.position -= movementSpeed * Vector3.right * Time.deltaTime;
        animate.SetBool("Running", true);

    }

    /// <summary>
    /// When the d key or right arrow key is pressed the player character will move right
    /// </summary>
    public void moveRight()
    {
        transform.rotation = Quaternion.LookRotation(Vector3.right);
        transform.position += movementSpeed * Vector3.right * Time.deltaTime;
        animate.SetBool("Running", true);

    }
}
