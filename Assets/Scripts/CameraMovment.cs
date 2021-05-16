using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovment : MonoBehaviour
{
    public float speed = 100.0F;

    private Vector3 startMarker;
    private Vector3 endMarker;
    private float startTime;
    private float journeyLength;
    private bool leaveRoom;

    private void Start()
    {
        leaveRoom = true;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            leaveRoom = false;
            startTime = Time.time;
            startMarker = Camera.main.transform.position;
            endMarker = new Vector3(transform.position.x, transform.position.y, -1);
            journeyLength = Vector3.Distance(startMarker, endMarker);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        leaveRoom = true;
    }

    private void Update()
    {
        if (!leaveRoom)
        {
            float distCovered = (Time.time - startTime) * speed;
            float fracJourney = distCovered / journeyLength;
            Camera.main.transform.position = Vector3.Lerp(startMarker, endMarker, fracJourney);
        }

    }
}
