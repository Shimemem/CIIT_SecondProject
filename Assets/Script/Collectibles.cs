using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectibles : MonoBehaviour
{

    public bool Speed, Health;
    public int speedBoost, healthBoost, duration;
    private int baseMovespeed;
    public PlayerMovement player;

    // Start is called before the first frame update
    private void Start()
    {
        baseMovespeed = player.Speed;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Speed)
        {
            player.Speed += speedBoost;
            StartCoroutine(BackToBaseSpeed());
        }

        if (Health)
        {
            player.Health += healthBoost;
        }
    }

    IEnumerator BackToBaseSpeed()
    {
        yield return new WaitForSeconds(duration);
        player.Speed = baseMovespeed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
