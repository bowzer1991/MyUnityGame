using System.Collections;
using UnityEngine;

public class PlayerDetails : MonoBehaviour
{
    public float currentSpeed;
    private float delay = 1.0f;
    private Vector3 newPos, oldPos;

    void Start()
    {
        oldPos = transform.position;
    }

    private void Update()
    {
        calculateVelocity();
    }

    private void calculateVelocity()
    {
        newPos = transform.position;
        currentSpeed = (newPos - oldPos).normalized.magnitude / Time.deltaTime;
        oldPos = newPos;
    }
}
