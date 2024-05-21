using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlanetMovement : MonoBehaviour
{

    private Transform sunPosition;

    [SerializeField] private float speed = 5.0f;

    private void Start()
    {
        sunPosition = GameObject.FindGameObjectWithTag("Sun").transform;
    }

    private void Update()
    {
        transform.RotateAround(sunPosition.position, Vector3.up, speed * Time.deltaTime);
    }

}