using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveObject : MonoBehaviour
{

    
    // Update is called once per frame
    void Update()
    {
        RemoveObjs();
    }

    void RemoveObjs()
    {
        if (transform.position.x < -50)
        {
            Destroy(gameObject);
        }
    }
}
