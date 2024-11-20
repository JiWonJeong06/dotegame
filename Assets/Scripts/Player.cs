using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    public enum State {Seagull, Die}
    public float jump;
    Rigidbody2D rigid;
    public UnityEvent onHit;
    Animator animator;

    void Start() 
    {
        rigid = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
       
    }
    // Update is called once per frame
    void Update()
    {
        if (GameManager.Gamestart) {
            if(Input.GetMouseButton(0)) {
                    rigid.velocity = Vector2.up * jump;
                }
            if(GameManager.Enregy <= 0) {
            rigid.simulated = false;
            AnimatorChange(State.Die);
            onHit.Invoke();
            }
        }
    }

    void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("Bang-eo")){
            Debug.Log("방어 획득");
            Destroy(collision.gameObject);
            GameManager.Enregy += 2f;
            GameManager.score += 100f;
            GameManager.bbangeo += 1f;
        }

        if(collision.CompareTag("Gajami")){
            Debug.Log("가자미 획득");
            Destroy(collision.gameObject);
            GameManager.Enregy += 3f;
            GameManager.score += 150f;
            GameManager.ggajami += 1f;
        }

        if(collision.CompareTag("Domi")){
            Debug.Log("도미 획득");
            Destroy(collision.gameObject);
            GameManager.Enregy += 5f;
            GameManager.score += 200f;
            GameManager.ddomi += 1f;
        }

        if(collision.CompareTag("Calamari")){
            Debug.Log("오징어 획득");
            Destroy(collision.gameObject);
            GameManager.Enregy += 8f;
            GameManager.score += 300f;
            GameManager.ccalamari += 1f;
        }

        if(collision.CompareTag("Tuna")){
            Debug.Log("참치 획득");
            Destroy(collision.gameObject);
            GameManager.Enregy += 10f;
            GameManager.score += 500f;
            GameManager.ttuna += 1f;
        }
    }
    void AnimatorChange(State state) {
       animator.SetInteger("State", (int)state);
    }  
//고래 박기
    void OnCollisionEnter2D(Collision2D collision){
        if (collision.collider.CompareTag("Whale"))
        {
            Debug.Log("고래와 충돌");
            rigid.simulated = false;
            AnimatorChange(State.Die);
            onHit.Invoke();
        }
    }


}
