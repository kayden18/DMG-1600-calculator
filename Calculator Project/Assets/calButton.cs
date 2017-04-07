using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class calButton : MonoBehaviour {

    public numberInput leftNum;
    public numberInputTwo rightNum;

    public void buttonClick()
    {
        print(leftNum.numberOnetoFloat() + rightNum.numberTwotoFloat());  
    }
    public void button2Click()
    {
        print(leftNum.numberOnetoFloat() - rightNum.numberTwotoFloat());
    }
    public void button3click()
    {
        print(leftNum.numberOnetoFloat() * rightNum.numberTwotoFloat());
    }
    public void button4click()
    {
        print(leftNum.numberOnetoFloat() / rightNum.numberTwotoFloat());
    }
}
