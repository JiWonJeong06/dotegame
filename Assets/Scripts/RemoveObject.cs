using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveObject : MonoBehaviour
{

    public bool Whale_objs;
    // Update is called once per frame
    void Update()
    {
        RemoveObjs();
    }

    void RemoveObjs()
    {
        if (transform.position.x < -25)
        {
            Destroy(gameObject);
            if(Whale_objs){
                GameManager.score += 10;
            }
        }
    }
}
