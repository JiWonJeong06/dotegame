using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Infinity : MonoBehaviour
{
    public UnityEvent onMove;

    void LateUpdate() {
        if (transform.position.x > -120) {
            return;
        }

       transform.Translate(280,0,0, Space.Self);
       onMove.Invoke();
    }
}
