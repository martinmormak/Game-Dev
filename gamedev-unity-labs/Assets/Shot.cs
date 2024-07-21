using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{

    [SerializeField] GameObject objectToSpawn;
    [SerializeField] Transform spawnPoint;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnObject();
        }
    }

    void SpawnObject(){

        if (objectToSpawn != null && spawnPoint != null){

            Vector3 spawnPosition = spawnPoint.position;
            spawnPosition.y -= 5.0f;

            GameObject spawnedObject = Instantiate(objectToSpawn, spawnPosition, spawnPoint.rotation);

            Rigidbody rb = spawnedObject.GetComponent<Rigidbody>();
            if (rb == null)
            {
                rb = spawnedObject.AddComponent<Rigidbody>();
            }
            rb.useGravity = true;
        }
        else if(objectToSpawn == null)  Debug.LogWarning("Object to spawn is not assigned!");
        else Debug.LogWarning("Spawn point is not assigned!");

    }
}
