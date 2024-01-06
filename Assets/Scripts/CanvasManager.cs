using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEditor;

public class CanvasManager : MonoBehaviour
{
    public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            canvas.SetActive(false);
            Camera.main.GetComponent<CameraPan>().isEnabled = true;
        }
    }

    public void Escape()
    {
        canvas.SetActive(false);
        Camera.main.GetComponent<CameraPan>().isEnabled = true;
    }
}
