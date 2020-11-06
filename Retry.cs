using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Retry : MonoBehaviour
{
    public GameObject sheet;
    public GameObject box;
    public GameObject timer;
    public GameObject stopscript;
    public GameObject scorepanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Restart()
    {
        //boxの生成時に呼び出すのでtimerとstopは先にリスタートさせて置く
        timer.GetComponent<Timer>().Restart();
        stopscript.GetComponent<Stopscript>().Restart();
        Instantiate(box);
        sheet.GetComponent<Sheetscript>().Restart();
    }
}
