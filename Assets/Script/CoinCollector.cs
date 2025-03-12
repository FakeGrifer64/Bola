using UnityEngine;
using UnityEngine.SceneManagement;

public class CoinCollector3D : MonoBehaviour
{
    private int coinCount = 0;
    public int coinsToWin = 6;
    public string victorySceneName = "VictoryScene";
    public GameObject coinPrefab; 

    private void OnTriggerEnter(Collider other)
    {
       
        if (PrefabIgual(other.gameObject, coinPrefab))
        {
            Destroy(other.gameObject); 
            coinCount++;

            if (coinCount >= coinsToWin)
            {
                SceneManager.LoadScene(victorySceneName); 
            }
        }
    }

    
    private bool PrefabIgual(GameObject obj, GameObject prefab)
    {
        return obj != null && prefab != null &&
               obj.name.Contains(prefab.name); 
    }
}
