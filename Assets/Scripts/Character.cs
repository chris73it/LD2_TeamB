using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public enum CharacterType {Player, Enemy, Object, Troop,};

    public float speed;
    public float currentHealth;
    public float maxHealth;
    public HealthBar healthBar;
    public CharacterType Type;

    void Start()
    {
        currentHealth = maxHealth;
        //healthBar.SetMaxHealth(maxHealth);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(2);
        }
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth < 0)
        {
            currentHealth = 0;
        }
        //healthBar.SetHealth(currentHealth);

    }
    public void Heal(int health)
    {
        currentHealth += health;
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        //healthBar.SetHealth(currentHealth);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log("Collided with: " + other.name);
        if (other.tag == "projectile")
        {
            //if (other.GetComponent<Projectile>().exclude != this.gameObject.name)
            //{
            //    TakeDamage(other.GetComponent<Projectile>().damage);
            //}
        }
        if (other.tag == "melee")
        {
            if (other.GetComponent<Melee>().exclude != this.gameObject.name)
            {
                TakeDamage(other.GetComponent<Melee>().damage);
            }
        }
    }
}
