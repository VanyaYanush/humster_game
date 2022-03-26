using UnityEngine;
using System.Collections;

public class Camera_move : MonoBehaviour
{
    float camSens = 0.15f;
    private Vector3 lastMouse = new Vector3(255, 255, 255);
    public GameObject player;
    private Vector3 offset_obj;

    private void Start()
    {
        offset_obj = transform.position - player.transform.position;
    }

    void LateUpdate()
    {
        lastMouse = Input.mousePosition - lastMouse;
        lastMouse = new Vector3(-lastMouse.y * camSens, lastMouse.x * camSens, 0);
        lastMouse = new Vector3(transform.eulerAngles.x + lastMouse.x, transform.eulerAngles.y + lastMouse.y, 0);
        transform.eulerAngles = lastMouse;
        lastMouse = Input.mousePosition;

        transform.position = player.transform.position + offset_obj;
    }
}