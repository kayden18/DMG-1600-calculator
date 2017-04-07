using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class numberInputTwo : MonoBehaviour {

    public InputField input2;
    public float numberTwotoFloat()
    {
     return float.Parse(input2.text);
    }
}
