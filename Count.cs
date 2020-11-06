using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Count : MonoBehaviour
{
    public GameObject timer;
    public int count;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Text>().text = count.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Miss()
    {
        count--;
        gameObject.GetComponent<Text>().text = count.ToString();

        if (count == 0)
        {
            timer.GetComponent<Timer>().play = false;
        }
    }
}
