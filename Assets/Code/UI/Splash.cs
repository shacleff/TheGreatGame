﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Splash : MonoBehaviour
{
    public Text _text;
    private int timer = 3;

    // Start is called before the first frame update
    void Start()
    {
        _text.text = timer.ToString();
        StartCoroutine(CountDown());    
    }

    IEnumerator CountDown()
    {
        yield return new WaitForSeconds(1.0f);
        timer--;
        _text.text = timer.ToString();
        if (timer <= 0)
        {
            GameSceneManager.LoadScene("Login");
        }
        else
        {
            StartCoroutine(CountDown());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
