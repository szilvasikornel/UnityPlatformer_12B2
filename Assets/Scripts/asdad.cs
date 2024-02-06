using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asdad : MonoBehaviour
{
    [SerializeField] private GameObject explosionEffect;
    [SerializeField] private float damage;

    private ProjectileController projectileController;

    private void Awake()
    {
        projectileController = GetComponent<ProjectileController>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Destroyable"))
        {
            projectileController.Stop();
            Instantiate(explosionEffect, transform.position,transform.rotation);
            Destroy(gameObject);
        }
    }
}
