using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lhitbox : MonoBehaviour
{
    public GameObject score;
    public GameObject text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //当たった処理
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Box>().name == "blue")
        {
            Debug.Log("10点");
            score.GetComponent<Score>().Scoreadd(10);
        }
        else
        {
            Debug.Log("ミス！-10点");
            score.GetComponent<Score>().Scoreadd(-10);
            text.GetComponent<Count>().Miss();
        }

        Destroy(collision.gameObject);
    }
}
