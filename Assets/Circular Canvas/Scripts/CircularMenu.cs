using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BNG;
using Xamin;

public class CircularMenu : MonoBehaviour
{
    public CircleSelector circleS;
    void Update()
    {
        if (InputBridge.Instance.XButton || Input.GetKeyDown(KeyCode.G))
        {
            Debug.Log(" open Menu");
            circleS.Open();
        }
        if (InputBridge.Instance.YButton || Input.GetKeyDown(KeyCode.H))
        {
            circleS.Close();
        }
    }

    public void Press1()
    {
        Debug.Log("HI");
    }
    public void Press2()
    {
        Debug.Log("Hello");
    }
    public void Press3()
    {
        Debug.Log("Bye");
    }

    public void Press4()
    {
        Debug.Log("YO YO");
    }
}
