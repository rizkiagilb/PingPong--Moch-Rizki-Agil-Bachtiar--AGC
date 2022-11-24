using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PU_SpeedUp : MonoBehaviour
{
    public PowerUpManager manager;
    public Collider2D ball;


    public float magnitude;


    public float PU_cooldown; //spawn orb
    public float PU_fx_cooldown; // for fx

    private void Update()
    {
        PU_cooldown -= Time.deltaTime;
        
        if (PU_cooldown <= 0)
        {
            manager.RemovePowerUp(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball && !manager.GetComponent<PowerUpManager>().isPU_active)
        {
            ball.GetComponent<BallControl>().ActivatePU_SpeedUp(magnitude, PU_fx_cooldown);
            //Destroy(gameObject);
            manager.RemovePowerUp(gameObject);
        }
    }
}
