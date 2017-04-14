using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class calButton : MonoBehaviour {

    public InputField input;
    public InputField input2;
    public Text Answer;

   
    public void buttonClick() {
        int numberOutPut;
        numberOutPut = int.Parse(input.text) + int.Parse(input2.text);
        Answer.text = numberOutPut.ToString();
        gameObject.GetComponent<Button>().interactable = false;
    }
    public void button2Click() {
        int numberOutPut;
        numberOutPut = int.Parse(input.text) - int.Parse(input2.text);
        Answer.text = numberOutPut.ToString();
        gameObject.GetComponent<Button>().interactable = false;
    }
    public void button3click() {
        int numberOutPut;
        numberOutPut = int.Parse(input.text) * int.Parse(input2.text);
        Answer.text = numberOutPut.ToString();
        gameObject.GetComponent<Button>().interactable = false;
    }
    public void button4click() {
        int numberOutPut;
        numberOutPut = int.Parse(input.text) / int.Parse(input2.text);
        Answer.text = numberOutPut.ToString();
        gameObject.GetComponent<Button>().interactable = false;
    }


    
}