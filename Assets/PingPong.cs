using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPong : MonoBehaviour
{
    public Vector3 pointA = new Vector3(0, -1, 0); // ������ �����
    public Vector3 pointB = new Vector3(0, 6, 0); // ������ �����
    public float speed = 2.0f; // �������� ��������

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float time = Mathf.PingPong(Time.time * speed, 1);
        transform.position = Vector3.Lerp(pointA, pointB, time);
    }
}
