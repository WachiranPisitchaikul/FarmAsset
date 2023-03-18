using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
   
    [SerializeField] private float minZoomDist;
    [SerializeField] private float maxZoomDist;

    [SerializeField] private float zoomModifier;
    [SerializeField] private float zoomSpeed;

    private Camera cam;
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Zoom();
    }
    private void Zoom()
    {
        zoomModifier = Input.GetAxis("Mouse ScrollWheel");

        float dist = Vector3.Distance(transform.position, cam.transform.position);

        if (dist < minZoomDist && zoomModifier > 0f)
            return;
        else if (dist > maxZoomDist && zoomModifier < 0f)
            return;

        cam.transform.position += cam.transform.forward * zoomModifier * zoomSpeed;

    }
}
