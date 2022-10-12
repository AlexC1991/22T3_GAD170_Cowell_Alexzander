using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AlexzanderCowell
{

}
public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private GameObject coinPrefab;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            SpawnCoin();
        }
        
    }

    private void SpawnCoin()
    {
        
        
            int xPosition = Random.Range(-8, 8);
            int yPosition = Random.Range(-8, 8);
            int zPosition = Random.Range(-8, 8);
            Instantiate(coinPrefab, new Vector3(xPosition, yPosition, zPosition), Quaternion.identity); 
            
        
        
    }
}
