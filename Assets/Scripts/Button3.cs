using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button3 : MonoBehaviour
{
    public static int buttonStatus3 = 0;
    public void But3()
    {
        buttonStatus3 = 3;
        Debug.Log("Нажата 3");
    }
}