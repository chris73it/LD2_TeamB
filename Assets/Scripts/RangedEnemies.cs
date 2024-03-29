using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedEnemies : MonoBehaviour
{
    public GameObject player;
    public Character stat;
    public RangedAttack Bow;
    public float range;
    public float distance;
    public Character.CharacterType Type;

    private float speedMutation;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
        speedMutation = Random.Range(-1, 1);

        Bow.setTarget(player.transform);
    }
    void Update()
    {
        if (player != null) {
            distance = Vector2.Distance(transform.position, player.transform.position);
            Vector2 direction = player.transform.position - transform.position;
            direction.Normalize();
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

            if (distance > range)
            {
                transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, (stat.speed + speedMutation) * Time.deltaTime);
                Bow.canShoot = false;
            }

            else
            {
                transform.position = Vector2.MoveTowards(this.transform.position, this.transform.position, (stat.speed + speedMutation) * Time.deltaTime);
                //Destroy(this.gameObject);
                Bow.canShoot = true;
            }
        }

        
        
    }
}
