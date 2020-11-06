using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    //当たったら削除
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Box>().name == "blue")
        {
            Debug.Log("10点");
        }

        Destroy(collision.gameObject);
    }
}
