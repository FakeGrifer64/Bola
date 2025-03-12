using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private GameObject coinPrefab; 
    [SerializeField] private int numberOfCoins = 6;
    [SerializeField] private Vector2 spawnAreaSize = new Vector2(3f, 3f);
    [SerializeField] private float spawnHeight = 1.5f; 

    private void Start()
    {
        SpawnCoins();
    }

    private void SpawnCoins()
    {
        for (int i = 0; i < numberOfCoins; i++)
        {
            Vector3 randomOffset = new Vector3(
                Random.Range(-spawnAreaSize.x / 4, spawnAreaSize.x / 4),
                0,
                Random.Range(-spawnAreaSize.y / 4, spawnAreaSize.y / 4)
            );

            
            Vector3 spawnPosition = transform.position + randomOffset + Vector3.up * spawnHeight;

            GameObject coin = Instantiate(coinPrefab, spawnPosition, Quaternion.identity);
            coin.tag = "Coin"; 
        }
    }
}
