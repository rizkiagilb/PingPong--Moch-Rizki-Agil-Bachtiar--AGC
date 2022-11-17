using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BallControl : MonoBehaviour
{

    public Vector2 speed;
    public Vector2 resetPos;

    private Rigidbody2D rig;

    public bool isPU_active;
    private float PU_fx_cooldown_current;
    private float PU_fx_cooldown_max;


    public PU_SpeedUp pu_speedup;

    // Start is called before the first frame update
    private void Start()
    { 
        rig = GetComponent<Rigidbody2D>();
        rig.velocity = speed; 

    }

    // Update is called once per frame
    private void Update()
    {
        // rig.velocity = speed * Time.deltaTime; rigidbody (pyhisic) tidk perlu deltatime
        // rig.velocity = speed; pindah ke start saja
        // transform.position = transform.position + (new Vector3(0.1f, 0, 0) * Time.deltaTime);
        // transform.Translate(speed * Time.deltaTime);

        //if (PU_fx_cooldown > 0)
        //{
        //    isPU_active = true;
        //    PU_fx_cooldown -= Time.deltaTime;
        //}
        //if (PU_fx_cooldown == 1)
        //{
        //    ResetFxPU();
        //}
        //if (PU_fx_cooldown <= 0)
        //{
        //    isPU_active = false;
        //}
        //Debug.Log(isPU_active);

        if (PU_fx_cooldown_max > 0)
        {
            PU_fx_cooldown_current += Time.deltaTime;
            isPU_active = true;
        }
        if (PU_fx_cooldown_current >= PU_fx_cooldown_max && isPU_active == true)
        {
            PU_fx_cooldown_max = 0;
            PU_fx_cooldown_current = PU_fx_cooldown_max;
            isPU_active = false;
            ResetFxPU();
            Debug.Log("Stop");
        }
    }

    

    public void resetBall()
    {
        transform.position = new Vector3(resetPos.x, resetPos.y, 2);
        
    }


    //Reset All Fx PU

    public void ResetFxPU()
    {
        //speed up
        rig.velocity /= pu_speedup.GetComponent<PU_SpeedUp>().magnitude;
    }

    //Activate PU


    public void ActivatePU_SpeedUp(float magnitude, float time)
    {
        rig.velocity *= magnitude;
        PU_fx_cooldown_max = time;
    } 
}
