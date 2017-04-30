using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class calButton : MonoBehaviour {

    public InputField input;
    public InputField input2;
    public Text Answer;
    public List<Text> randNum;

    static private bool chooseInputField = true;
    public int numsToInput;

    public void boolClick(){
        chooseInputField = true;
    }
    public void bool2Click(){
        chooseInputField = false;
    }

    public void SteveHatesYou()
    {
        foreach (Text randInt in randNum)
        {
              if (Answer.text == randInt.text)
            {
               print("answers match");
               randInt.enabled = false;
            }
        }
    }

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
    public void button5Click()
    {
        if (chooseInputField)
        {
            input.text += numsToInput.ToString();
        }
        else
        {
            input2.text += numsToInput.ToString();
        }
    }
}