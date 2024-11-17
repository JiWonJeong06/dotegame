using System.Collections;
using UnityEngine;

public class RandomObject : MonoBehaviour
{
    public GameObject[] objs;
  
    public float spawnInterval;

    void Start()
    {
        StartCoroutine(SpawnObject());
    }

    IEnumerator SpawnObject()
    {
        while (true)
        {
        
            int ran = Random.Range(0, objs.Length);
            GameObject randomObj = objs[ran];
            Instantiate(randomObj, new Vector3(30, -0.5f, 0), Quaternion.identity);
            yield return new WaitForSeconds(spawnInterval);

        }
    }
}
