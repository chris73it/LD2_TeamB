using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public enum AttackType { Ranged, Melee, Special }
public class TroopAI : MonoBehaviour
{
    public bool active = false;

    [SerializeField]
    private AttackType type;

    public Transform target;
    public Character stat;
    public RangedAttack Bow;
    public float range;
    public float distance;

    public GameObject[] enemies;

    // Update is called once per frame
    void Update()
    {
        if (active)
        {
            enemies = GameObject.FindGameObjectsWithTag("Enemy");
            if (enemies.Length == 0)
            {
                //Debug.Log("enemies.Length == 0");
            }
            sortByDistance(enemies);

            if (enemies != null && enemies.Length > 0)
            {
                target = enemies[0].transform;
                Bow.setTarget(target.transform);

                distance = Vector2.Distance(transform.position, target.position);
                Vector2 direction = target.transform.position - transform.position;
                direction.Normalize();
                float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;


                if (distance > range)
                {
                    Bow.canShoot = false;
                }

                else
                {
                    Bow.canShoot = true;
                }
            }
        }
    }

    void sortByDistance(GameObject[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            float d1 = Vector2.Distance(transform.position, array[i].transform.position);
            float d2 = Vector2.Distance(transform.position, array[0].transform.position);
            if (d1 < d2)
            {
                GameObject temp = array[0];
                array[0] = array[i];
                array[i] = temp;
            }
        }
    }
}
