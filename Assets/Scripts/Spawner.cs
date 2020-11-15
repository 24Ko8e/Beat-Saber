using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] cubes;
    public Transform[] spawnPoints;
    public float beat = 120/130;
    float timer;

    void Start()
    {
        
    }

    void Update()
    {
        if (timer > beat)
        {
            GameObject cube = Instantiate(cubes[UnityEngine.Random.Range(0, 2)], spawnPoints[UnityEngine.Random.Range(0, 4)]);
            cube.transform.localPosition = Vector3.zero;
            cube.transform.Rotate(transform.forward, 90 * UnityEngine.Random.Range(0, 4));
            timer -= beat;
        }

        timer += Time.deltaTime;
    }
}
