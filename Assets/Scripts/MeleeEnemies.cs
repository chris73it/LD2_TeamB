using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeEnemies : MonoBehaviour
{
    public GameObject player;
    public Character stat;
    public float distanceBetween;
    public float distance;

    private float speedMutation;

    void Start()
    {
        player = GameObject.Find("Player");
        speedMutation = Random.Range(-1, 3);
    }
    void Update()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;
        direction.Normalize();
        //float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg; ;

        if (distance < distanceBetween)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, (stat.speed + speedMutation) * Time.deltaTime);
        }
        else if (distance > distanceBetween + 5)
        {
            Destroy(this.gameObject);
        }
    }
}
