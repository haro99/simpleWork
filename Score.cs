using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameObject scoreString;
    //得点
    public int point;

    // Start is called before the first frame update
    void Start()
    {
        point = 0;
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<Text>().text = point.ToString() + "$";
    }

    public void Scoreadd(int add)
    {
        point += add;
    }

    public void scoreStringset()
    {
        scoreString.SetActive(true);
    }
}
