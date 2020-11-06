using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * タイマークラス
 */
public class Timer : MonoBehaviour
{
    public GameObject Droppos;
    public GameObject Controller;
    public GameObject Lamplight;
    public GameObject Retry;
    public Animator Scoremove;
    public Text timertext;
    public int time;
    public float totaltime;
    public bool play;
    public int rushtime;

    // Start is called before the first frame update
    void Start()
    {
        play = true;
        rushtime = Random.Range(1, 4);
        Lamplight.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (play)
        {
            totaltime += Time.deltaTime;
            time = (int)totaltime;
            timertext.text = time.ToString();

            if (time >= rushtime * 5)
            {
                Droppos.GetComponent<boxzone>().settime = 2;
                Lamplight.SetActive(true);
            }
        }
        else
        {
            Droppos.GetComponent<boxzone>().GameStop();
            Controller.GetComponent<Controller>().play = false;
            Scoremove.SetBool("over", true);
            Retry.SetActive(true);
        }
    }

    public void Restart()
    {
        time = 0;
        totaltime = 0f;
        gameObject.SetActive(true);
        play = true;
    }
}
