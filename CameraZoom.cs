using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour {

    private float timer;
    private float duration;
    private bool isActive;

    public void Zoom(float m_duration)
    {
        duration = m_duration;
        isActive = true;
    }

    void Update()
    {
        if (isActive == true)
        {
            print("dab");
            transform.rotation = new Quaternion(0, 0, -0.05f, 1);
            GetComponent<Camera>().orthographicSize = 4.0f;
            timer += Time.deltaTime;
            if (timer > duration)
            {
                duration = 0;
                timer = 0;
                isActive = false;
            }
        }
        else
        {
            GetComponent<Camera>().orthographicSize = 5.0f;
            transform.rotation = new Quaternion(0,0,0,1);
        }
    }
}
