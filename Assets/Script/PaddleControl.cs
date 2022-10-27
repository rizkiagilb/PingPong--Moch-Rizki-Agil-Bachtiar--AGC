using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleControl : MonoBehaviour
{
    //komen buat riwayat catatan gk perlu di hapus biarin nyampah '-'
    public float speeed;
    public KeyCode keyUp;
    public KeyCode keyDown;
    private Rigidbody2D rig;
    // private Vector2 speed; pindah ke bawah

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // private Vector2 speed;
        // speed = new Vector2(0,0);
        // Vector2 speed = Vector2.zero;

        // if (Input.GetKey(KeyCode.W))
        // {
        //     // speed = new Vector2(0, 1);
        //     speed = Vector2.up * speeed;
        // }
        // if (Input.GetKey(KeyCode.S))
        // {
        //     speed = Vector2.down * speeed;
        // }

        // Vector2 speed = GetInput();
        // MoveObject(speed);

        MoveObject(GetInput());
        // Debug.Log(transform.position.y); cara mengetahui self position  
    }

    //ngatur nilai posisi
    private Vector2 GetInput()
    {

        if (Input.GetKey(keyUp))
        {
            return Vector2.up * speeed;
        }
        else if (Input.GetKey(keyDown))
        {
            return Vector2.down * speeed;
        } 
        return Vector2.zero;
    }
    //gerakin object nya 
    private void MoveObject(Vector2 speed)
    {
        // transform.Translate(speed * Time.deltaTime); karena udah pakek rig
        rig.velocity = speed;
    }

























}
