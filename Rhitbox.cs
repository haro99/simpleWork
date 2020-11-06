using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rhitbox : MonoBehaviour
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

    //回収ボックスに当たったら
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Box>().name == "red")
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
