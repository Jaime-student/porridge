using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    // i want this one to be an audi

    [SerializeField] private string brand = "audi";
    [SerializeField] private int speedLimit = 220;
    public bool isCrashed = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
