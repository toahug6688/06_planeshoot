using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Plane : MonoBehaviour
{
    public GameObject BulletPrefab;
    public float moveSpeed = 1; // ���ʳt��
                                // Update is called once per frame
    void Start()
    {
    }

    void FixedUpdate()
    {
        //²�檺���k����A�o�ӽd�һP�L�h���߫}���ʳ��O������
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
            //�l�u�ͦ�����m�ھھԾ�����m�A�A���W�[0.6f
            Instantiate(BulletPrefab, pos, transform.rotation); //�̾ڤW�z��pos��m�A�ͦ��l�u
        }

    }
}
