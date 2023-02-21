using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public List<GameObject> enemyList = new List<GameObject>();
    
    [SerializeField]
    private int skeletonCount = 1;
    [SerializeField]
    private int armoredCount = 1;

    public bool randomInterval = true;
    public int SpawnCd;

    void Start()
    {
        StartCoroutine(spawnEnemy(SpawnCd, enemyList));
    }

    private IEnumerator spawnEnemy(float interval, GameObject enemy, int count)
    {
        yield return new WaitForSeconds(randomInterval ? interval + Random.Range(-2f, 5f) : interval); ;

        for (int i = 0; i < count; i++)
        {
            Vector3 spawnPos = this.transform.position;
            Vector3 randomRange = new Vector3(Random.Range(-5f, 5), Random.Range(-6f, 6f), 0);
            spawnPos += randomRange;

            GameObject newEnemy = Instantiate(enemy, spawnPos, Quaternion.identity);
        }
        StartCoroutine(spawnEnemy(interval, enemy, count));
    }
}
