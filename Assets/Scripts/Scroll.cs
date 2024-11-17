using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    public int Count;
    public float Scrollspeed;
    // Start is called before the first frame update
    void Start()
    {
        Count = transform.childCount;
    }
    // Update is called once per frame
    void Update()
    {
            
        float totalSpeed = 3 * Scrollspeed * Time.deltaTime * -1f;
        transform.Translate(totalSpeed, 0, 0);
    
    }
}
