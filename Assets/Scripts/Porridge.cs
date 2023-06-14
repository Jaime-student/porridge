using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Porridge : MonoBehaviour
{
  [SerializeField]  private float temperature;
    private void Start()
    {
        temperature = 100;
    }
    private void Update()
    {
        temperature = temperature - Time.deltaTime;

        if (temperature > 70)
        {
            Debug.Log("The temperature is to hot" + (int)temperature);
        }
        else if (temperature < 40)
        {
            Debug.Log("The temperature is to cold" + (int)temperature);
        }
        else
        {
            Debug.Log("The temperature is just right" + (int)temperature);
        }
            
    }
}

