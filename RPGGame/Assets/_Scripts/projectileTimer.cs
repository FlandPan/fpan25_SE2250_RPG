﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileTimer : MonoBehaviour
{
    // Start is called before the first frame update
    public int time;
    void Start()
    {
        time = 0;
        StartCoroutine(e());
    }
    IEnumerator e()
    {
        yield return new WaitForSeconds(2);
        Destroy(this.gameObject);
    }

    // Update is called once per frame
}
