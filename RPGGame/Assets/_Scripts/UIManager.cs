﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private Text _timer;
    private Text _healthText;
    public int _hp = 100;
    public UIManager(){

    }
    void Start()
    {
        GameEvents.current.OnPlayerDamage += DecreaseHealth;
        _timer = GameObject.Find("Timer").GetComponent<Text>();
        _healthText = GameObject.Find("Health").GetComponent<Text>();
        Timer.StartCountDown(new System.TimeSpan(0,2,0));

    }
    void Update()
    {
        _timer.text = "Timer: " + Mathf.Round((float)Timer.TimeLeft.TotalSeconds);
        _healthText.text = "HP:   " + _hp;
    }
    private void DecreaseHealth(int hp){
        if(_hp >= hp){
            _hp -= hp;
        }
    }
}
