using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCanvas : MonoBehaviour
{
    public GameObject canvas;

    private void OnMouseDown()
    {
        canvas.SetActive(true);
        Camera.main.GetComponent<CameraPan>().isEnabled = false;
    }
}
