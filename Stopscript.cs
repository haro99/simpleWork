using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stopscript : MonoBehaviour
{
    public GameObject Scorepanel;
    public bool play;

    // Start is called before the first frame update
    void Start()
    {
        play = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (play)
        {
            StartCoroutine("Wait");
        }
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(3.5f); // 3.5秒待つ
        this.gameObject.SetActive(false);
        play = false;
        Scorepanel.SetActive(true);
    }

    public void Restart()
    {
        this.gameObject.SetActive(true);
        play = true;
    }
}
