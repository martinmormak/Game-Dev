using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class Enemy : MonoBehaviour
{
    [SerializeField] public VisualEffect explosion;

    private void OnCollisionEnter(Collision collision)
    {
        /*Debug.Log($"I'm hit! by {collision.gameObject.name}");
        Destroy(gameObject);
        Explosion();*/
        
        Debug.Log($"I'm hit! by {collision.gameObject.name}");

        // Instantiate the explosion effect at the position of the projectile
        Instantiate(explosion, transform.position, Quaternion.identity);

        // Destroy the projectile
        Destroy(gameObject);
    }

    void Explosion() {
        explosion.Play();
    }

}