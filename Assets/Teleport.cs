using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject plane;
    public float minY = 0f;  // ����������� ������
    public float maxY = 3f;  // ������������ ������
    public float teleportInterval = 5f;
    private float timer;

    void Start()
    {
        timer = teleportInterval;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            Tel();
            timer = teleportInterval;
        }
    }

    void Tel()
    {
        // ������� ���������
        Renderer planeRenderer = plane.GetComponent<Renderer>();
        float planeWidth = planeRenderer.bounds.size.x;
        float planeHeight = planeRenderer.bounds.size.z;

        // ��������� ���������� ������ ���������
        float randomX = Random.Range(-planeWidth / 2, planeWidth / 2);
        float randomZ = Random.Range(-planeHeight / 2, planeHeight / 2);
        // ������ ����
        float randomY = Random.Range(minY, maxY);
        // ������� ����
        transform.position = new Vector3(randomX, randomY, randomZ);
    }
}