using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class randomNum : MonoBehaviour
{
    
    private int randomNumGenerator;
    public Text randInt;

    public void Start()
    {
        randomNumGenerator = Random.Range(1, 10);
        randInt.text = randomNumGenerator.ToString();
    }
}