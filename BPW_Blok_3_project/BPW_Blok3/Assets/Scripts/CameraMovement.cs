﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    Vector3 mouseLook;
    Vector3 smoothV;
    public float CameraSensitivity = 5.0f;
    public float smoothing = 2.0f;

    GameObject player;

    void Start()
    {
        player = this.transform.parent.gameObject;  
    }

    // Update is called once per frame
    void Update()
    {
        var md = new Vector3(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));

        md = Vector3.Scale(md, new Vector3(CameraSensitivity * smoothing, CameraSensitivity * smoothing));
        smoothV.x = Mathf.Lerp(smoothV.x, md.x, 1f / smoothing);
        smoothV.y = Mathf.Lerp(smoothV.y, md.y, 1f / smoothing);
        mouseLook += smoothV;

        transform.localRotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.right);
        player.transform.localRotation = Quaternion.AngleAxis(mouseLook.x, player.transform.up);
    }
}
