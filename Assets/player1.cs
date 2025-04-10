using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player1 : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        

        
    }

    // Update is called once per frame
    void Update()
    {
        bool isup =Input.GetKey(KeyCode.W);
        bool isdown =Input.GetKey(KeyCode.S);
        bool isright =Input.GetKey(KeyCode.D);
        bool isleft =Input.GetKey(KeyCode.A);
        Vector2 direction = isup ? Vector2.up : isdown ? Vector2.down : isright ? Vector2.right : isleft ? Vector2.left: Vector2.zero;
        float interval = Time.deltaTime;
        transform.Translate(interval * speed * direction);
        

    }
}
