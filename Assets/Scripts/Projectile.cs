using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public int damage;
    float speed = 20;
    bool speedFallOff = false;

    float lifeTime = 0;
    float maxLife = 1.5f;

    public string exclude;
    public SpriteRenderer projectileRenderer;

    public void Setup(int dmg, float spd, bool fallOff, Sprite sprite, string excludeName, LayerMask layer)
    {
        damage = dmg;
        speed = spd;
        speedFallOff = fallOff;
        this.gameObject.layer = layer;
        exclude = excludeName;
        projectileRenderer.sprite = sprite;
    }
    void Update()
    {
        lifeTime += Time.deltaTime;
        transform.position += transform.right * speed * Time.deltaTime;

        if (speedFallOff)
        {
            speed -= 1f * Time.deltaTime;
        }

        if (lifeTime > maxLife)
        {
            Destroy(this.gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name != exclude)
        {
            Destroy(this.gameObject);
        }
    }
}
