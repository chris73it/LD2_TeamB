using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Melee : MonoBehaviour
{

    public int damage;
    public float rate;

    float lifeTime = 0;
    float maxLife = 0.5f;
    //float knockback = 55f;

    public string exclude;

    public Collider2D col;
    public Renderer sprite;
    //public Animator anim;
    public Transform body;

    public void Setup(int dmg, string excludeName, LayerMask layer)
    {
        damage = dmg;
        this.gameObject.layer = layer;
        exclude = excludeName;
    }

    
    void Update()
    {
        if (lifeTime < maxLife + 1)
        {
            lifeTime += Time.deltaTime;
        }

        if (lifeTime > maxLife)
        {
           //disable();
        }
    }

    public void enable()
    {
        lifeTime = 0;
        col.enabled = true;
    //    sprite.enabled = true;
    //    if (anim.enabled)
    //    {
    //        anim.SetBool("Chomp Time", true);
    //    }
    }
    public void disable()
    {
        col.enabled = false;
        sprite.enabled = false;
    //    if (anim.enabled)
    //    {
    //        anim.SetBool("Chomp Time", false);
    //    }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name != exclude)
        {
            if (other.GetComponent<Character>())
            {
                if (other.GetComponent<Character>().Type != Character.CharacterType.Object)
                {
                    //Debug.Log("Melee attack connected");
                    Rigidbody2D rb2d = other.GetComponent<Rigidbody2D>();
    //                if (rb2d != null)
    //                {

    //                    if (rb2d != null)
    //                    {
    //                        //Debug.Log("Attempting to knockback" + rb2d);
    //                        Vector2 dir = (other.transform.position - body.position).normalized;
    //                        //rb2d.velocity += dir * knockback;
    //                        rb2d.AddForce(dir * knockback, ForceMode2D.Impulse);
    //                    }
    //                }
                }
            }
        }
    }
}
