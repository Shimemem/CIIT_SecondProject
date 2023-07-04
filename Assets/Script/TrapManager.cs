using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapManager : MonoBehaviour
{
    private Animator anim;
    public PlayerMovement player;

    public int TrapDamage;
    // Checks if the player is on the trap
    public bool isPlayeronTrap;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        isPlayeronTrap = true;
        if (collision.gameObject.CompareTag("Player"))
        {
            anim.SetBool("IsActive", true);       

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        isPlayeronTrap = false;
        if (collision.gameObject.CompareTag("Player"))
        {
            anim.SetBool("IsActive", false);

        }
    }

    public void PlayerDamage()
    {
        if (isPlayeronTrap)
        {
            player.Health -= TrapDamage;
        }
        
    }

}
