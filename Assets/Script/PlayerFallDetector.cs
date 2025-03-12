using UnityEngine;
using UnityEngine.SceneManagement; 

public class PlayerFallDetector : MonoBehaviour
{
    [SerializeField] private float deathHeight = -5f; 
    [SerializeField] private string sceneToLoad = "GameOverScene"; 

    private void Update()
    {
        if (transform.position.y < deathHeight)
        {
            SceneManager.LoadScene(sceneToLoad); 
        }
    }
}
