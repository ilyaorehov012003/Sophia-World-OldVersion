using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button2 : MonoBehaviour
{
    public static int buttonStatus2 = 0;
    public void But2()
    {
        buttonStatus2 = 2;
        Debug.Log("Нажата 2");
    }
}