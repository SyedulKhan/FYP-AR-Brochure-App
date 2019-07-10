using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothCamera : MonoBehaviour
{
    public GameObject arCamera;
    private float posX, posY, posZ;

    // Update is called once per frame
    void Update()
    {
        Vector3 arCameraPosition = arCamera.transform.position;
        posX += ((arCameraPosition.x - posX) / 8);
        posY += ((arCameraPosition.y - posY) / 8);
        posZ += ((arCameraPosition.z - posZ) / 8);

        Vector3 newARCameraPosition = transform.position;
        newARCameraPosition.x = posX;
        newARCameraPosition.y = posY;
        newARCameraPosition.z = posZ;
        transform.position = newARCameraPosition;
    }
}
