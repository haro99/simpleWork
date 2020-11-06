using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sheetscript : MonoBehaviour
{
    public float xangle, zangle, xzadd;
    //public Quaternion startposition;

    // Start is called before the first frame update
    void Start()
    {
        //startposition = this.transform.rotation;
        xangle = 0f;
        zangle = 0f;
        xzadd = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {


        zangle = Input.GetAxis("Horizontal") * -20;
        xangle = Input.GetAxis("Vertical") * 20;

        this.transform.eulerAngles = new Vector3(xangle, 0, zangle);
    }

    public void Restart()
    {
        this.transform.Rotate(new Vector3(0f, 0f, 0f));
    }
}
