using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    /*[SerializeField] float controlSpeed = 30f;
    [SerializeField] float rotationSpeed = 5f;

    void Update()
    {
        // Get input values
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        // Calculate movement offsets
        float yOffset = verticalInput * Time.deltaTime * controlSpeed;

        // Calculate new positions
        float newYPos = transform.localPosition.y + yOffset;

        // Update the position
        transform.localPosition = new Vector3(transform.localPosition.x, newYPos, transform.localPosition.z);

        // Rotate the plane based on the input
        float rotation = horizontalInput * rotationSpeed;
        transform.Rotate(Vector3.up, rotation * Time.deltaTime);

        // Move forward at a constant speed
        float forwardSpeed = controlSpeed; // You can adjust this value
        transform.Translate(Vector3.forward * forwardSpeed * Time.deltaTime);
    }*/

    [SerializeField] float controlSpeed = 50f;
    [SerializeField] float xRange = 20f;
    [SerializeField] float yRange = 20f;
    private Terrain terrain;

    void Start()
    {
        /*terrain = Terrain.activeTerrains[0];
        Debug.Log(terrain.terrainData.size);
        Debug.Log(terrain.GetPosition());*/
    }

    void Update()
    {

        float xThrow = Input.GetAxis("Horizontal");
        float yThrow = Input.GetAxis("Vertical");

        float xOffset = xThrow * Time.deltaTime * controlSpeed;
        float newXPos = transform.localPosition.x + xOffset;
        float clampedXPos = Mathf.Clamp(newXPos, -xRange+transform.localPosition.x, xRange+transform.localPosition.x);
        //clampedXPos = Mathf.Clamp(clampedXPos, terrain.GetPosition().x, terrain.GetPosition().x+terrain.terrainData.size.x);

        float yOffset = yThrow * Time.deltaTime * controlSpeed;
        float newYPos = transform.localPosition.y + yOffset;
        float clampedYPos = Mathf.Clamp(newYPos, -yRange+transform.localPosition.y, yRange+transform.localPosition.y);
        //clampedYPos = Mathf.Clamp(clampedYPos, terrain.GetPosition().y, terrain.GetPosition().y+terrain.terrainData.size.y);

        transform.localPosition = new Vector3 (clampedXPos, clampedYPos, transform.localPosition.z);
    }
}
