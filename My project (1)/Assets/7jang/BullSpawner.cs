using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullSpawner : MonoBehaviour
{


    public GameObject bulletPrefab;
    public float spawnRateMin = 0.5f;
    public float spawnRateMax = 3f;


    public Transform target;
    float spwnRate;
    float timeAfterSpawn;



    // Start is called before the first frame update
    void Start()
    {
        timeAfterSpawn = 0f;
        spwnRate = Random.Range(spawnRateMin, spawnRateMax);
        target = FindObjectOfType<playercontroll>().transform;
        

    }

    // Update is called once per frame
    void Update()
    {
        timeAfterSpawn += Time.deltaTime;

        if(timeAfterSpawn > spwnRate)
        {
            timeAfterSpawn = 0;

            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
            bullet.transform.LookAt(target);

        }



    }
}
