using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SetText : MonoBehaviour
{
    private int index = 0; 
    public TextAsset[] input;
    public TextMeshProUGUI output;
    // Start is called before the first frame update
    void Start()
    {
        output.text = input[index].text;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IndexRight()
    {
        if (input.Length != 1 && index < input.Length - 1)
        {
            index += 1;
        } else
        {
            index = 0;
        }

        output.text = input[index].text;
    }

    public void IndexLeft()
    {
        if (input.Length != 1 && index > 0)
        {
            index -= 1;
        } else
        {
            index = input.Length - 1;
        }

        output.text = input[index].text;
    }
}
