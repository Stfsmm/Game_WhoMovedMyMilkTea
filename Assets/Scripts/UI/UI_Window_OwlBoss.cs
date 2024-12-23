using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Window_OwlBoss : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = this.transform.localPosition;
        Console.WriteLine("µ±«∞Œª÷√£∫" + pos.x);
        if (pos.x <= -246)
        {
            return;
        }
        pos.x -= 1.5f;
        this.transform.localPosition = pos;
    }
}
