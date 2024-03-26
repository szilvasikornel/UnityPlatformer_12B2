using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    [SerializeField] private float projectileSpeed = 15f;

    private Rigidbody2D rigidbody2d;
    private AudioSource audioSource;

    private void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();

        rigidbody2d.AddForce(new Vector2(transform.rotation.z == 0 ? 1 : -1, 0) * projectileSpeed, ForceMode2D.Impulse);
    }

    public void Stop()
    {
<<<<<<< HEAD
        audioSource.mute = true;
=======
>>>>>>> 8baaeebb60a4f8d70389a5883b84c013acc11a5d
        rigidbody2d.velocity = new(0, 0);
    }
}
