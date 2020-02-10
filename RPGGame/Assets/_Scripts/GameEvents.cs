﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvents : MonoBehaviour
{
    public static GameEvents current;

    void Awake()
    {
        current =this;
    }

    public event Action<int> OnPlayerDamage;

    public void playerGetsDamaged(int hp){
        if (OnPlayerDamage != null){
            OnPlayerDamage(hp);
        }
    }
}
