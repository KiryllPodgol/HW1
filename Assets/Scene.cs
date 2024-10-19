using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scene : MonoBehaviour
{
    void Update()
    {
        // ���������, ������ �� ������� N
        if (Input.GetKeyDown(KeyCode.N))
        {
            SwitchScene();
        }
    }

    void SwitchScene()
    {
        // �������� ������ ������� �����
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        // ������������ ������ ��������� �����
        int nextSceneIndex = (currentSceneIndex + 1) % SceneManager.sceneCountInBuildSettings;
        // ��������� ��������� �����
        SceneManager.LoadScene(nextSceneIndex);
    }
}

