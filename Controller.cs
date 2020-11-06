using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public GameObject Leftbar;
    public GameObject Rightbar;
    public Animator Leftanima;
    public Animator Rightanima;
    public bool play;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Rightbar.transform.rotation.y <= -0.3f) Rightanima.SetBool("move", false);
        if (Leftbar.transform.rotation.y >= 0.3f) Leftanima.SetBool("move", false);

        if (play)
        {
            //キー入力
            if (Input.GetKey(KeyCode.RightArrow)) Rightanima.SetBool("move", true);
            if (Input.GetKey(KeyCode.LeftArrow)) Leftanima.SetBool("move", true);
        }
    }
}
