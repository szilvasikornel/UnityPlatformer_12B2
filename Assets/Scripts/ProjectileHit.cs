using UnityEngine;

public class ProjectileHit : MonoBehaviour
{
    [SerializeField] private GameObject explosionEffect;
    [SerializeField] private float damage = 1f;

    private ProjectileController controller;

    private void Awake()
    {
        controller = GetComponentInParent<ProjectileController>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Destroyable"))
        {
            controller.Stop();
            Instantiate(explosionEffect, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
