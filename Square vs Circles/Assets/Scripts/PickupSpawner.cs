using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSpawner : MonoBehaviour
{
    public GameObject pickup;
    //Used for random spawning
    float randX;
    float randY;
    Vector2 whereToSpawn;
    public float spawnRate = 30f;
    float nextSpawn = 0.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randX = Random.Range(-10f, 10f);
            randY = Random.Range(-10f, 10f);
            whereToSpawn = new Vector2(randX, randY);
            Instantiate(pickup, whereToSpawn, Quaternion.identity);
        }
    }
}
