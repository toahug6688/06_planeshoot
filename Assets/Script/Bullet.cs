using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Bullet : MonoBehaviour
{
    public float moveSpeed = 1; // 移動速度
                                // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 2); //設定2秒後子彈物件被刪除
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += new Vector3(0, moveSpeed, 0) * Time.deltaTime; //子彈會不斷往上移動
    }
}

