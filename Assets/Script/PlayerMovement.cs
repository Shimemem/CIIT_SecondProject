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
        if (Input.GetKeyDown(KeyCode.W))
        {
            // The Trigger ForwardAnimation will play
            anim.SetTrigger("ForwardAnimation");
        }
        // If we release the key W
        if (Input.GetKeyUp(KeyCode.W))
        {
            anim.SetTrigger("ForwardAnimationPause");
        }
        // If we press the key A
        if (Input.GetKeyDown(KeyCode.A))
        {
            // The Trigger ForwardAnimation will play
            anim.SetTrigger("LeftAnimation");
        }
        // If we release the key A
        if (Input.GetKeyUp(KeyCode.A))
        {
            anim.SetTrigger("LeftAnimationPause");
        }
        // If we press the key S
        if (Input.GetKeyDown(KeyCode.S))
        {
            // The Trigger ForwardAnimation will play
            anim.SetTrigger("BackwardsAnimation");
        }
        // If we release the key S
        if (Input.GetKeyUp(KeyCode.S))
        {
            anim.SetTrigger("BackwardsAnimationPause");
        }
        // If we press the key D
        if (Input.GetKeyDown(KeyCode.D))
        {
            // The Trigger ForwardAnimation will play
            anim.SetTrigger("RightAnimation");
        }
        // If we release the key D
        if (Input.GetKeyUp(KeyCode.D))
        {
            anim.SetTrigger("RightAnimationPause");
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
