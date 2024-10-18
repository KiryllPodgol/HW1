using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Vector3 targetScale = new Vector3(0.1f, 0.1f, 0.1f); // Целевой размер
    public float resizeSpeed = 1f;
    private bool isResizing = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            // Интерполируем размер от начального до целевого
            isResizing = true;
        }
        if (isResizing)
        {
            transform.localScale = Vector3.Lerp(transform.localScale, targetScale, Time.deltaTime * resizeSpeed);


            if (Vector3.Distance(transform.localScale, targetScale) < 0.01f)
            {
                isResizing = false;
                transform.localScale = targetScale;
            }
        }
    }
}
