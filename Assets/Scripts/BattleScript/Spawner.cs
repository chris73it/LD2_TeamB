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

    //public float spawnRangeXMin;
    //public float spawnRangeXMax;
    //public float spawnRangeYMin;
    //public float spawnRangeYMax;
    public Wave[] waves;
    //public Transform[] spawnPoints;
    public Animator animator;
    public Text waveName;
    private Wave currentWave;
    private int currentWaveNumber;
    private float nextSpawnTime;
    private bool canSpawn = true;
    private bool canAnimate = false;

    //private void Start()
    //{
    //    currentWave = waves[currentWaveNumber];
    //    SpawnWave();
    //}

    private void Update()
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

    void SpawnNextWave()
    {
        currentWaveNumber++;
        canSpawn = true;
    }

    void SpawnWave()
    {
        if (!canSpawn || nextSpawnTime > Time.time)
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
        }

        canSpawn = false;
    }

    //void SpawnWaveOld()
    //{
    //    if (canSpawn && nextSpawnTime < Time.time)
    //    {
    //        GameObject randomEnemy = currentWave.typeOfEnemies[Random.Range(0, currentWave.typeOfEnemies.Length)]; //creates the enemies
    //        Vector3 v3Pos = Camera.main.ViewportToWorldPoint(new Vector3(Random.Range(spawnRangeXMin,
    //                                                         spawnRangeXMax), Random.Range(spawnRangeYMin, spawnRangeYMax), 0.5f));
    //        //Transform randomPoint = spawnPoints[Random.Range(0, spawnPoints.Length)]; // spawn location
    //        //Instantiate(randomEnemy, randomPoint.position, Quaternion.identity);
    //        Instantiate(randomEnemy, v3Pos, Quaternion.identity); // Spawns enemy
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
    //private IEnumerator spawnEnemy(float interval, List<GameObject> enemy)
    //{
    //    for (int i = 0; i <= numToSpawnPerInterval; i++)
    //    {
    //        int selectEnemy = Random.Range(0, enemyList.Count - 1);
    //        Vector3 v3Pos = Camera.main.ViewportToWorldPoint(new Vector3(Random.Range(spawnRangeXMin, spawnRangeXMax), Random.Range(spawnRangeYMin, spawnRangeYMax), 0.5f));
    //        v3Pos.z = -0.2f;
    //        GameObject spawn = Instantiate(enemy[selectEnemy], v3Pos, Quaternion.identity);

    //    }
    //    yield return new WaitForSeconds(2f);
    //    yield return new WaitForSeconds(interval);
    //    StartCoroutine(spawnEnemy(interval, enemy));
    //}
