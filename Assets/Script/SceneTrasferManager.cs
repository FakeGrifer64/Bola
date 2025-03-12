using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTrasferManager : MonoBehaviour
{
    public string targetSceneName = "AlternateScene";
    public KeyCode transferkey = KeyCode.T;

    void Update()
    {
        if (Input.GetKeyUp(transferkey))
        {
            MoveObjectToAnotherScene();
        }
    }
    void MoveObjectToAnotherScene()
    {
        Scene targetScene = SceneManager.GetSceneByName(targetSceneName);
        if (targetScene.IsValid())
        {
            SceneManager.MoveGameObjectToScene(gameObject, targetScene);
            Debug.Log($"objeto{gameObject.name}movido pra ceba{ targetSceneName}.");

        }
        else
        {
            Debug.LogError($"Cena{targetSceneName} does not exist.");
        }
    }
}
