using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BallControl : MonoBehaviour
{

    public Vector2 speed;
    public Vector2 resetPos;

    private Rigidbody2D rig;

    public PU_SpeedUp pu_speedup;
    public PU_SpeedDown pu_speeddown;

    public PowerUpManager manager;

    public int sisi; //di gunakan untuk mengetahui ball ini di pukul oleh siapa, tadinya mau pakai string...[1]
                      //ibarakan saja kiri = 0, kanan = 1
    public Collider2D col_paddle_L;
    public Collider2D col_paddle_R;







    // Start is called before the first frame update
    private void Start()
    { 
        rig = GetComponent<Rigidbody2D>();
        rig.velocity = speed;
        sisi = Random.Range(0,1); //[1]... tapi kurang ngerti kalau mau bikin pick random string, misal choose("Kiri","Kanan")
                                  //ibarakan saja kiri = 0, kanan = 1

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



    }

    

    public void resetBall()
    {
        transform.position = new Vector3(resetPos.x, resetPos.y, 2);
        sisi = Random.Range(0, 1);
    }


    //Reset All Fx PU

    public void res_spup() //reset speedup
    {
        Debug.Log("speedup Stop"); // knp reset speed up nya jadi gk work....? >:(   (kadang seperti kembali melambat tapi...) debug nya aja gk muncul
        rig.velocity /= pu_speedup.magnitude; 
    }
    public void res_spdn() //resset speeddown
    {
        Debug.Log("speeddown Stop");
        rig.velocity *= pu_speeddown.magnitude;
    }
    

    //Activate PU


    public void ActivatePU_SpeedUp(float magnitude, float time)
    {
        rig.velocity *= magnitude;
        manager.setType("SpeedUP");
        manager.setCdMax(time);
    }

    public void ActivatePU_SpeedDown(float magnitude, float time)
    {
        rig.velocity /= magnitude;
        manager.setType("SpeedDown");
        manager.setCdMax(time);
    }



    //di gunakan untuk mengetahui ball ini di pukul oleh siapa
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == col_paddle_L) //kenapa nggk work
        {
            sisi = 0;
            Debug.Log(sisi);
        }
        if (collision == col_paddle_R)
        {
            sisi = 1;
            Debug.Log(sisi);

        }
    }//masalah di sini
    // Masih belum bisa ngambil atau menentukan harus paddle mana yang kena effect







}




