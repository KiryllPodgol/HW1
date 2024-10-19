using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scene : MonoBehaviour
{
    void Update()
    {
        // Проверяем, нажата ли клавиша N
        if (Input.GetKeyDown(KeyCode.N))
        {
            SwitchScene();
        }
    }

    void SwitchScene()
    {
        // Получаем индекс текущей сцены
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        // Рассчитываем индекс следующей сцены
        int nextSceneIndex = (currentSceneIndex + 1) % SceneManager.sceneCountInBuildSettings;
        // Загружаем следующую сцену
        SceneManager.LoadScene(nextSceneIndex);
    }
}

