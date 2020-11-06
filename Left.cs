using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * 左のボタン
 */
public class Left : MonoBehaviour
{
    //オブジェクト
    public GameObject left;

    //アニメーション
    public Animator _animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (left.transform.rotation.y >= 0.3f) _animator.SetBool("move", false);
    }

    //←キーされたときの
    public void Touch()
    {
        _animator.SetBool("move", true);

    }
}
