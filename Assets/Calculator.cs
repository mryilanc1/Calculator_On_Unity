using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{
    // Start is called before the first frame update

    public int a;
    public int b;
    public int islem;
    public Text text;
    
    

    void Start()
    {
        
    }



    
    public void sayıGir()
    {

        text.text +=gameObject.transform.GetChild(0).GetComponent<Text>().text;
        a = Convert.ToInt32(text.text);

    }


    public void topla ()
    {

        islem = islem + a;
        text.text = islem.ToString();

    }

    public void cikar()
    {

        islem = islem - a;
        text.text = islem.ToString();

    }

    public void carp()
    {

        islem = a * islem;

        text.text = islem.ToString();
    }

    public void bol()
    {

        islem = islem / a;

        text.text = islem.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
