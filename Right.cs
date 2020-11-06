using UnityEngine;

/*
 * 右のボタン
 */
public class Right : MonoBehaviour
{
    //オブジェクト
    public GameObject right;

    //アニメーション
    public Animator _animator;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (right.transform.rotation.y <= -0.3f) _animator.SetBool("move", false);
        //Debug.Log(right.transform.rotation);
    }

    public void Touch()
    {
        _animator.SetBool("move", true);
        
    }
}
