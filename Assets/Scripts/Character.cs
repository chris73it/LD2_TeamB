using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public enum CharacterType {Player, Enemy, Object, Troop,};

    public float speed;
    public int health;
    private int maxHealth;

    public CharacterType Type;

}
