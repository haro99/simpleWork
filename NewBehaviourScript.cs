using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 *  滑らせる地面
 */
public class NewBehaviourScript : MonoBehaviour
{
    List<Rigidbody> rigidbys = new List<Rigidbody>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //foreach (var col in rigidbys)
        //{
        //    col.AddForce(Vector3.right, ForceMode.Force);
        //}
    }
    private void OnCollisionEnter(Collision collision)
    {
        var rigidbody = collision.gameObject.GetComponent<Rigidbody>();
        //rigidbys.Add(rigidbody);
        //リジットボディ自体に力を加える
        rigidbody.AddForce(5, 0, 0, ForceMode.VelocityChange);
    }

    //void OnCollisionExit(Collision collision)
    //{
    //    var rigidBody = collision.gameObject.GetComponent<Rigidbody>();
    //    rigidbys.Remove(rigidBody);
    //}
}
