using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleManager : MonoBehaviour
{
    public PowerUpManager manager;


    public PaddleControl pdl_kiri;
    public PaddleControl pdl_kanan;

    public PU_SpeepUp_Paddle spd;
    public PU_Expand_Paddle expnd;

    



    public void res_expnd()
    {
        Debug.Log("Expand Stop");
        //sementara rset semua paddle
        pdl_kiri.transform.localScale = new Vector2(pdl_kiri.transform.localScale.x, pdl_kiri.transform.localScale.y / expnd.scale);
        pdl_kanan.transform.localScale = new Vector2(pdl_kanan.transform.localScale.x, pdl_kanan.transform.localScale.y / expnd.scale);
    }

    public void res_spd_pdl()
    {
        Debug.Log("Paddle Speed Stop");
        pdl_kanan.speeed /= spd.speed;
        pdl_kiri.speeed /= spd.speed;
    }


    public void ActivatePU_Expand_pddl(float scale, float time,int sisii) // Masih belum bisa ngambil atau menentukan harus paddle mana yang kena effect
    {
        //if (sisii == 0)
        //{
        //    pdl_kanan.transform.localScale = new Vector2(pdl_kanan.transform.localScale.x, pdl_kanan.transform.localScale.y * scale);
        //}
        //else if (sisii == 1)
        //{
        //    pdl_kiri.transform.localScale = new Vector2(pdl_kiri.transform.localScale.x, pdl_kiri.transform.localScale.y * scale);
        //}
        transform.localScale = new Vector2(transform.localScale.x, transform.localScale.y * scale); //sementara yang ngefect kesemua paddle
        manager.setType("Expand");
        manager.setCdMax(time);
       
    }

    public void ActivatePU_SpeedUp_pddl(float speed, float time, int sisii)
    {
        pdl_kanan.speeed *= speed;
        pdl_kiri.speeed *= speed;
        manager.setType("SpeedupPaddle");
        manager.setCdMax(time);
    }
}
