using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PU_Expand_Paddle : MonoBehaviour
{

    public PowerUpManager manager;
    public Collider2D ball;
    public BallControl baall;
    public PaddleManager padd;


    public float scale;


    public float PU_cooldown; //spawn orb
    public float PU_fx_cooldown; // for fx
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        PU_cooldown -= Time.deltaTime;

        if (PU_cooldown <= 0)
        {
            manager.RemovePowerUp(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball && baall.sisi == 0 && !manager.GetComponent<PowerUpManager>().isPU_active) // punya nya kiri b
        {
            padd.ActivatePU_Expand_pddl(scale, PU_fx_cooldown, 0);
            manager.RemovePowerUp(gameObject);
        }
        if (collision == ball && baall.sisi == 1 && !manager.GetComponent<PowerUpManager>().isPU_active) // punya nya kiri a
        {
            padd.ActivatePU_Expand_pddl(scale, PU_fx_cooldown, 1);
            manager.RemovePowerUp(gameObject);
        }
    }
}
