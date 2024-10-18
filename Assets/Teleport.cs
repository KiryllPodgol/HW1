using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject plane;
    public float minY = 0f;  // Минимальная высота
    public float maxY = 3f;  // Максимальная высота
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
        // Размеры плоскости
        Renderer planeRenderer = plane.GetComponent<Renderer>();
        float planeWidth = planeRenderer.bounds.size.x;
        float planeHeight = planeRenderer.bounds.size.z;

        // Случайные координаты внутри плоскости
        float randomX = Random.Range(-planeWidth / 2, planeWidth / 2);
        float randomZ = Random.Range(-planeHeight / 2, planeHeight / 2);
        // Высота куба
        float randomY = Random.Range(minY, maxY);
        // Позиция куба
        transform.position = new Vector3(randomX, randomY, randomZ);
    }
}