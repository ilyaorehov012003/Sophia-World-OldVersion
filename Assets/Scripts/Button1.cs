using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button1 : MonoBehaviour
{
    public static int buttonStatus1 = 0;

    public void But1()
    {
        buttonStatus1 = 1;
        Debug.Log("Нажата 1");
    }
}