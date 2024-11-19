using System.Collections;
using UnityEngine;

public class RandomObject : MonoBehaviour
{
    public GameObject[] objs;
  
    public GameObject[] fish;

    public int per;

    public float spawnInterval;

    void Start()
    {
        StartCoroutine(SpawnObject());
    }

    IEnumerator SpawnObject()
    {
        while (GameManager.Gamestart)
        {
            int fish_objs = Random.Range(1,101);

            int random_pos = Random.Range(-7, 4);
            if (fish_objs <= per) {
            int ran = Random.Range(0, objs.Length);
            GameObject randomObj = objs[ran];
            Instantiate(randomObj, new Vector3(30, -0.5f, 0), Quaternion.identity);
            yield return new WaitForSeconds(spawnInterval);
            }


            if (fish_objs > per) {
            int ran = Random.Range(0, fish.Length);
            GameObject randomObj = fish[ran];
            Instantiate(randomObj, new Vector3(30, random_pos, 0), Quaternion.identity);
            yield return new WaitForSeconds(spawnInterval);
            }

        }
    }
}
