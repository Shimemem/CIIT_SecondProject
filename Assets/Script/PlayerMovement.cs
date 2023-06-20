using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    // Speed (How fast the player will navigate on our Game)
    public float moveSpeed;
    // RigidBody (Handles Physics)
    public Rigidbody2D rigidBody;
    // Dictates where the player is moving
    private Vector2 movementInput;
    // Access our Animator to play Animations
    public Animator anim;
     
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // If we press the key W
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            // The Trigger ForwardAnimation will play
            anim.enabled = true;
            anim.SetTrigger("ForwardAnimation");
        }
        // If we press the key A
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            // The Trigger ForwardAnimation will play
            anim.enabled = true;
            anim.SetTrigger("LeftAnimation");
        }
        // If we press the key S
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            // The Trigger ForwardAnimation will play
            anim.enabled = true;
            anim.SetTrigger("BackwardsAnimation");
        }
        // If we press the key D
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            // The Trigger ForwardAnimation will play
            anim.enabled = true;
            anim.SetTrigger("RightAnimation");
        }
        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D))
        {
            anim.enabled = false;
        }
    }
    // Fixed update for physics calculations.
    private void FixedUpdate()
    {
        // makes our player move
        rigidBody.velocity = movementInput * moveSpeed;
    }

    private void LatestUpdate()
    {

    }

    // To get the Input System Clicks
    private void OnMove(InputValue inputValue)
    {
        // If I Press A =
        movementInput = inputValue.Get<Vector2>();
    }
}
