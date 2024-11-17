using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float jump;

    Rigidbody2D rigid;

    void Start() 
    {
        rigid = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
       if(Input.GetKey(KeyCode.Space)){
            rigid.velocity = Vector2.up * jump;
        }
    }
}
