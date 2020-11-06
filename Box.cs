using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Box : MonoBehaviour
{
    public GameObject text;
    public string name;
    public int number;

    // Start is called before the first frame update
    void Start()
    {
        System.Random rand = new System.Random();
        number = rand.Next(1, 3);

        if (number == 1)
        {
            name = "red";
            this.GetComponent<Renderer>().material.color = Color.red;
        }
        else
        {
            name = "blue";
            this.GetComponent<Renderer>().material.color = Color.blue;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (0.5f >= this.transform.position.y)
        {
            Destroy(this.gameObject);
        }
    }

    //void OnBecameInvisible()
    //{
    //    Destroy(this.gameObject);
    //}
}
