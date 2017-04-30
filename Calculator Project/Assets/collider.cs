using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collider : MonoBehaviour
{
    public Text gameEnder;

    public void OnCollisionEnter(Collision collision)
    {
        foreach( ContactPoint contact in collision.contacts)
        {
            print("Game over");
            gameEnder.text = "GAME OVER";
        }
    }
}
