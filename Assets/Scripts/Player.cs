using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed;

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move() {

        if(Input.GetKey(KeyCode.A)){
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.D)){
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.W)){
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.S)){
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }
    }
}
