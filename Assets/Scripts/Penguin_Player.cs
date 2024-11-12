using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Penguin_Player : MonoBehaviour
{

    public float speed;

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move() {

        if(Input.GetKeyDown(KeyCode.Space)){
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
    }
}
