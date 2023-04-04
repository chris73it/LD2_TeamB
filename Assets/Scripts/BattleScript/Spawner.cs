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
    [SerializeField] int waiter;
    private int count = -1;
    public bool finished = false;

    private void Start()
    {
        StartCoroutine(Waiter());
    }

    private void Update()
    {
        if (count == waiter)
        {
            currentWave = waves[currentWaveNumber];
            SpawnWave();
            GameObject[] totalEnemies = GameObject.FindGameObjectsWithTag("Enemy");

            if (totalEnemies.Length == 0)
            {
                count = -1;
                if (currentWaveNumber + 1 != waves.Length)
                {
                    SpawnNextWave();

                    if (canAnimate)
                    {
                        //waveName.text = waves[currentWaveNumber + 1].waveName;
                        //animator.SetTrigger("WaveComplete");
                        //canAnimate = false;
                    }
                }
                else
                {
                    Debug.Log("GameFinish");
                    finished = true;
                }
            }
        }
    }

    void SpawnNextWave()
    {
        currentWaveNumber++;
        canSpawn = true;
        StartCoroutine(Waiter());
    }
    private IEnumerator Waiter()
    {
        yield return new WaitForSeconds(waiter);
        count = waiter;
    }
    void SpawnWave()
    {
        if (!canSpawn || nextSpawnTime >= Time.time)
        {
            return;
        }
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
            currentWave.noOfEnemies--;
        
        }
        nextSpawnTime = Time.time + currentWave.spawnInterval;
        if (currentWave.noOfEnemies == 0)
        {
            canSpawn = false;
            canAnimate = true;
        }

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