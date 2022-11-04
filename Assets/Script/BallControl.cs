using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BallControl : MonoBehaviour
{

    public Vector2 speed;
    public Vector2 resetPos;

    private Rigidbody2D rig;

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
    }

    public void resetBall()
    {
        transform.position = new Vector3(resetPos.x, resetPos.y, 2);
        
    }
}
