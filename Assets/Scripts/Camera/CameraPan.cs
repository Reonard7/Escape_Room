using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPan : MonoBehaviour
{
    Vector3 touchStart;
    public float xRange;
    public bool isEnabled = true;

    // Update is called once per frame
    void Update()
    {
        if (isEnabled)
        {
            if (Input.GetMouseButtonDown(0))
            {
                touchStart = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            }
            else if (Input.GetMouseButton(0))
            {
                Vector3 direction = touchStart - Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Camera.main.transform.position += direction;
                if (Camera.main.transform.position.x < -xRange)
                {
                    Camera.main.transform.position = new Vector3(-xRange, Camera.main.transform.position.y, Camera.main.transform.position.z);
                }
                if (Camera.main.transform.position.x > xRange)
                {
                    Camera.main.transform.position = new Vector3(xRange, Camera.main.transform.position.y, Camera.main.transform.position.z);
                }
                if (Camera.main.transform.position.y != 0)
                {
                    Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, 0, Camera.main.transform.position.z);
                }
            }
        }
    }
}
