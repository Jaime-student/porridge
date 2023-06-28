using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    // we want to store a reference to each car in our game
    [SerializeField] private Car audi;
    [SerializeField] private Car vw;
    [SerializeField] private Car ford;
    [SerializeField] private Car tesla;
    [SerializeField] private Car[] allRacecarsArray;
    [SerializeField] private List<Car> allRacecarsList = new List<Car>();

    private void Start()
    {
        // We want to output the names of all our race cars
        Debug.Log(allRacecarsArray.Length);
        Debug.Log(allRacecarsArray[3].name);

        Debug.Log(allRacecarsList.Count);
        Debug.Log(allRacecarsList[3].name);
        CheckWhichCarsHaveCrased();
    }

    // Update is called once per frame
    private void CheckWhichCarsHaveCrased()
    //use a for loop
    {
        for (int selectedCarIndex = 0; selectedCarIndex < allRacecarsArray.Length; selectedCarIndex++)
        {
            if (allRacecarsList[selectedCarIndex].isCrashed == true)
            {
                Debug.Log("CRASHED " + selectedCarIndex);
                Debug.Log("A car has crahsed: " + allRacecarsList[selectedCarIndex].name + "!");
            }

        }
    }








    public void HelloWorldButton()
    {
        Debug.Log("Hello World for UI");
    }
}
