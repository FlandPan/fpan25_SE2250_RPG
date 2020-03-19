﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snakeHits : MonoBehaviour
{
    private static int health = 50;
    void OnTriggerEnter2D(Collider2D other)
    {
        health--;
    }
    void Update()
    {
        if(health <= 0)
        {   
            GameObject temp = this.gameObject;
            Destroy(GameObject.Find("Projectile(Clone)"));
            temp.SetActive(false);
        }
    }
}