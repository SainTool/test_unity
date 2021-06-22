using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject[] objVariant;
    private float timeObjSpawn;
    public float startTimeObjSpawn;
    public float decreaseTime;
    public float minTime = 0.65f;
    private void Update()
    {
            if (timeObjSpawn <= 0)
            {
                int rand = Random.Range(0, objVariant.Length);
                Instantiate(objVariant[rand], transform.position, Quaternion.identity);
                timeObjSpawn = startTimeObjSpawn;
                if (startTimeObjSpawn > minTime)
                {
                    startTimeObjSpawn -= decreaseTime;
                }
            }
            else
            {
                timeObjSpawn -= Time.deltaTime;
            }
        }
}
