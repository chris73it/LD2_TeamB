using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[System.Serializable]
public class Wave
{
    public string waveName;
    public int noOfEnemies;
    public GameObject[] typeOfEnemies;
    public float spawnInterval;
}
public class Spawner : MonoBehaviour
{
    public Transform[] corners;
    public Wave[] waves;
    public Animator animator;
    public Text waveName;
    private Wave currentWave;
    private int currentWaveNumber;
    private float nextSpawnTime;
    private bool canSpawn = true;
    private bool canAnimate = false;
    private int waiter = 5;
    private int count = 0;

    private void Start()
    {
        Debug.Log("Started");
        StartCoroutine(Waiter());
    }

    private void Update()
    {
        if (count == 5)
        {
            currentWave = waves[currentWaveNumber];
            SpawnWave();
            GameObject[] totalEnemies = GameObject.FindGameObjectsWithTag("Enemy");

            if (totalEnemies.Length == 0)
            {
                if (currentWaveNumber + 1 != waves.Length)
                {
                    if (canAnimate)
                    {
                        waveName.text = waves[currentWaveNumber + 1].waveName;
                        animator.SetTrigger("WaveComplete");
                        canAnimate = false;
                    }
                }
                else
                {
                    Debug.Log("GameFinish");
                }
            }
        }
    }

    void SpawnNextWave()
    {
        currentWaveNumber++;
        canSpawn = true;
    }
    private IEnumerator Waiter()
    {
        yield return new WaitForSeconds(5f);
        for (int i = 0; i < waiter; i++)
        {
            count++;
        }
    }
    void SpawnWave()
    {
        
        if (!canSpawn || nextSpawnTime > Time.time)
        {
            return;
        }
        Debug.Log("Continuing Forward");
        float playingFieldWidth = corners[1].transform.position.x - corners[0].transform.position.x;
        float playingFieldHeight = corners[2].transform.position.y - corners[0].transform.position.y;

        for (int index = 0; index < currentWave.noOfEnemies; index++)
        {
            float randomWidth = Random.Range(0, playingFieldWidth);
            float randomHeight = Random.Range(0, playingFieldHeight);
            Vector3 enemyPosition = new Vector3(corners[0].transform.position.x + randomWidth, corners[0].transform.position.y + randomHeight, 0);

            int randomEnemyIndex = Random.Range(0, currentWave.typeOfEnemies.Length);
            GameObject randomEnemy = currentWave.typeOfEnemies[randomEnemyIndex]; //choose the enemies

            Instantiate(randomEnemy, enemyPosition, Quaternion.identity); // Spawn enemy
            
            nextSpawnTime = Time.time + currentWave.spawnInterval;
        }

        canSpawn = false;

    }

    //void SpawnWaveOld()
    //{
    //    if (canSpawn && nextSpawnTime < Time.time)
    //    {
    //        GameObject randomEnemy = currentWave.typeOfEnemies[Random.Range(0, currentWave.typeOfEnemies.Length)]; //creates the enemies
    //        Transform randomPoint = spawnPoints[Random.Range(0, spawnPoints.Length)]; // spawn location
    //        Instantiate(randomEnemy, randomPoint.position, Quaternion.identity);
    //        currentWave.noOfEnemies--;
    //        nextSpawnTime = Time.time + currentWave.spawnInterval;
    //        if (currentWave.noOfEnemies == 0)
    //        {
    //            canSpawn = false;
    //            canAnimate = true;
    //        }
    //    }
    //}
}