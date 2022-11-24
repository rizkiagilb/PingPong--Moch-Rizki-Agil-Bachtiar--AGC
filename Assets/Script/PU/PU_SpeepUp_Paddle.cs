using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PU_SpeepUp_Paddle : MonoBehaviour
{
    public PowerUpManager manager;
    public Collider2D ball;
    public PaddleManager padd;


    public float speed;


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
            padd.ActivatePU_SpeedUp_pddl(speed, PU_fx_cooldown, 0);

            //Destroy(gameObject);
            manager.RemovePowerUp(gameObject);
        }
    }
}
