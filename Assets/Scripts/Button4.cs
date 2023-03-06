using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button4 : MonoBehaviour
{
    public static int buttonStatus4 = 0;
    public void But4()
    {
        buttonStatus4 = 4;
        Debug.Log("Нажата 4");
    }
}