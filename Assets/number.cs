using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class number : MonoBehaviour
{

    public Text text;

    void Start()
    {
        
    }


    public void sayıGir()
    {

        text.text += GetComponentInChildren<Text>().text;
        Calculator.a = Convert.ToInt32(text.text);

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
