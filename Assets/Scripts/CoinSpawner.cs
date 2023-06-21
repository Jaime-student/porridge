using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    // the prefeab we want to instanciate
    [SerializeField] private GameObject coinPrefab;

    // Update is called once per frame
    void Update()
    {
        

           if (Input.GetKeyDown(KeyCode.Space))
           {

            Instantiate(coinPrefab, transform.position, Quaternion.identity, transform);
           }
        

    }
}
