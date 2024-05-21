using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    [SerializeField] private Transform[] planets;

    int currentPlanet = 0;
    int cameraOffsetFromPlanet = -1;

    private void Update()
    {
        if(planets.Length > 0)
        {
            Vector3 planetPosition = new Vector3 (planets[currentPlanet].position.x, planets[currentPlanet].position.y, planets[currentPlanet].position.z + cameraOffsetFromPlanet);
            transform.position = Vector3.Lerp(transform.position, planetPosition, 10 * Time.deltaTime);
        }

        if(Input.GetButtonDown("Submit"))
        {
            SwitchPlanet();
        }
    }

    private void SwitchPlanet()
    {
        currentPlanet++;

        if(currentPlanet == planets.Length)
            currentPlanet = 0;
    }
}