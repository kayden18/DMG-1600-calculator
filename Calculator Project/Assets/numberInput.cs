using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class numberInput : MonoBehaviour {

    public InputField input;
    public float numberOnetoFloat(){
        return float.Parse(input.text);
    }
}