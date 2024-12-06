using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Plane : MonoBehaviour
{
    public GameObject BulletPrefab;
    public float moveSpeed = 1; // 移動速度
                                // Update is called once per frame
    void Start()
    {
    }

    void FixedUpdate()
    {
        //簡單的左右控制，這個範例與過去的貓咪移動都是類似的
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(moveSpeed, 0, 0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-moveSpeed, 0, 0) * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 pos = transform.position + new Vector3(0, 0.6f, 0);
            //子彈生成的位置根據戰機的位置，再往上加0.6f
            Instantiate(BulletPrefab, pos, transform.rotation); //依據上述的pos位置，生成子彈
        }

    }
}
