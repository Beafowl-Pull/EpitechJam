using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private Transform playerTransform;
    private Transform mainCamera;
    private float zPos = 10;
    [Range(0,1)] [SerializeField]
    private float cameraSpeed = 10;

    void Start()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        playerTransform = player.GetComponent<Transform>();
        mainCamera = gameObject.GetComponent<Transform>();
    }

    void FixedUpdate()
    {
        Vector3 pos = playerTransform.position;
        pos.z -= zPos;
        Vector3 lerpPosition = Vector3.Lerp(transform.position, pos, cameraSpeed);
        mainCamera.position = lerpPosition;
    }
}