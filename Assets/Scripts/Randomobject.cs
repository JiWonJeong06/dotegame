using System.Collections;
using UnityEngine;

public class RandomObject : MonoBehaviour
{
    public GameObject[] objs;
  
    public GameObject[] fish;

   
    public float spawnInterval;

    void Start()
    {
        StartCoroutine(SpawnObject());
    }

    IEnumerator SpawnObject()
    {
        while (GameManager.Gamestart)
        {
            int fish_objs = Random.Range(1,11);
            //고래 장애물 80%확률로 소환
            if (fish_objs <= 8) {
            int ran = Random.Range(0, objs.Length);
            GameObject randomObj = objs[ran];
            Instantiate(randomObj, new Vector3(30, -0.5f, 0), Quaternion.identity);
            yield return new WaitForSeconds(spawnInterval);
            }
            if (fish_objs > 8) {
            //점수 생선 20%확률로 소환
            int ran = Random.Range(0, fish.Length);
            GameObject randomObj = fish[ran];
            Instantiate(randomObj, new Vector3(30, -7.5f, 0), Quaternion.identity);
            yield return new WaitForSeconds(spawnInterval);
            }

        }
    }
}
