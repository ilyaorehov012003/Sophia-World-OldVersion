using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Karma : MonoBehaviour
{
    public static int count;
    public Text text;

    private void Start()
    {
        count = 0;
        text.text = count.ToString();
    }

    public void ButClick()
    {
        count++;
        text.text = count.ToString();
        Debug.Log(count);
    }
}
