<<<<<<< HEAD
using System.Collections;
using System.Collections.Generic;
=======
>>>>>>> b512a37e5f6adc94afaf824e093fda796fb06d1b
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    [SerializeField] private float projectileSpeed = 15f;

    private Rigidbody2D rigidbody2d;

    private void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        rigidbody2d.AddForce(new Vector2(transform.rotation.z == 0 ? 1 : -1, 0) * projectileSpeed, ForceMode2D.Impulse);
    }
}
