using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSpawner : MonoBehaviour
{
    public GameObject boss;
    private Wave currentWave;
    

    // Start is called before the first frame update
    void Start()
    {
        SpawnBoss();
    }

    void SpawnBoss()
    {
        var spawn = new Vector3(7f, 7f, 0f);
        Instantiate(boss, spawn, Quaternion.identity);

    }
}
