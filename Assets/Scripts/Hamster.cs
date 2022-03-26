using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hamster : MonoBehaviour
{
    public float speed = 3;
    void Start()
    {

    }

    void Update()
    {
        Transform camTransform = Camera.main.transform;
        Vector3 camPosition = new Vector3(camTransform.position.x - 1, transform.position.y, camTransform.position.z);
        Vector3 direction = (transform.position - camPosition).normalized;
        Vector3 forwardMovement = direction * Input.GetAxis("Vertical");
        Vector3 horizontalMovement = camTransform.right * Input.GetAxis("Horizontal");
        Vector3 movement = Vector3.ClampMagnitude(forwardMovement + horizontalMovement, 1);
        transform.Translate(movement * speed * Time.deltaTime, Space.World);
    }
}