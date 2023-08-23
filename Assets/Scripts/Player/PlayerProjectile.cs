using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectile : MonoBehaviour
{
    public GameObject prefabProjectile;
    public Transform origenProjectile;

    public float tiempoProjectile = 1.5f;
    public float fuerzaDisparo = 1000f;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject nuevaProjectile = Instantiate(prefabProjectile, origenProjectile.position, origenProjectile.rotation);


            nuevaProjectile.GetComponent<Rigidbody2D>().AddForce(new Vector2(origenProjectile.lossyScale.x* fuerzaDisparo, 0));
            StartCoroutine(DestruirProjectile(nuevaProjectile));
        }
    }

    IEnumerator DestruirProjectile(GameObject nuevaProjectile)
    {
        yield return new WaitForSeconds(tiempoProjectile);
        Destroy(nuevaProjectile);
    }
}
