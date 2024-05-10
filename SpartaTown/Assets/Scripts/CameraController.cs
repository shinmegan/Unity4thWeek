using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float cameraspeed = 5.0f;

    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = player.transform.position - this.transform.position;
        Vector3 moveVector = new Vector3(direction.x * cameraspeed * Time.deltaTime,
            direction.y * cameraspeed * Time.deltaTime, 0.0f);
        this.transform.Translate(moveVector);
    }
}
