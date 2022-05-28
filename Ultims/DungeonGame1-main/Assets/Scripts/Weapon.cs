using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : Collidable
{
    // Damage structure
    public int damagePoint = 1;
    public float pushForce = 2.0f;

    // public 
    int weaponLevel = 0;
    private SpriteRenderer spriteRenderer;

    protected override void Start()
    {
        base.Start();
        spriteRenderer = 
    }
}
