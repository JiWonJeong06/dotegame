using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
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
//물고기 잡아 먹기
    void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("Bang-eo")){
            Debug.Log("방어 획득");
            Destroy(collision.gameObject);
            GameManager.Enregy += 3f;
        }

        if(collision.CompareTag("Gajami")){
            Debug.Log("가자미 획득");
            Destroy(collision.gameObject);
            GameManager.Enregy += 5f;
        }

        if(collision.CompareTag("Domi")){
            Debug.Log("도미 획득");
            Destroy(collision.gameObject);
            GameManager.Enregy += 6.5f;
        }

        if(collision.CompareTag("Calamari")){
            Debug.Log("오징어 획득");
            Destroy(collision.gameObject);
            GameManager.Enregy += 8f;
        }

        if(collision.CompareTag("Tuna")){
            Debug.Log("참치 획득");
            Destroy(collision.gameObject);
            GameManager.Enregy += 10f;
        }
    }
//고래 박기
    void OnCollisionEnter2D(Collision2D collision){
         if (collision.collider.CompareTag("Whale"))
        {
            Debug.Log("고래와 충돌");
            rigid.simulated = false;
            onHit.Invoke();
        }
    }


}
