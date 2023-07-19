using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using RandomRange = System.Random;

public class UITextUpdater : MonoBehaviour
{
    //when this button is clicked
    //Update the game Text
    //We need a reference to our text object
    [SerializeField] private TextMeshProUGUI messageLable;
    [SerializeField] private string message;

    public void UpdateText()
    {
        messageLable.text = "Whatever you have on the ... yep" + message;
       
    }
}
