using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{

    public enum State {Die}
    public float jump;

    Rigidbody2D rigid;

    
    public UnityEvent onHit;

    void Start() 
    {
        rigid = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        if (GameManager.Gamestart) {
            if(Input.GetKey(KeyCode.Space)){
                    rigid.velocity = Vector2.up * jump;
                }
        }
    }
    
    void OnTriggerEnter2D(){
        rigid.simulated = false;
        GameManager.Gamestart = false;
        onHit.Invoke();
    }
}
