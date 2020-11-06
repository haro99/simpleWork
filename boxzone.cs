using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxzone : MonoBehaviour
{
    public GameObject box;
    public float count;
    public float settime;
    public bool drop;
    // Start is called before the first frame update
    void Start()
    {
        //1個目を生成
        Instantiate(box, this.transform.position, Quaternion.identity);
        drop = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (drop)
        {
            count += Time.deltaTime;

            //settimeの間隔で生成する
            if (count > settime)
            {
                Instantiate(box, this.transform.position, Quaternion.identity);
                count = 0f;
            }
        }
    }

    public void GameStop()
    {
        drop = false;
    }
}
