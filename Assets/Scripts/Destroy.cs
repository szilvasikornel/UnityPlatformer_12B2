<<<<<<< HEAD
using System.Collections;
using System.Collections.Generic;
=======
>>>>>>> b512a37e5f6adc94afaf824e093fda796fb06d1b
using UnityEngine;

public class Destroy : MonoBehaviour
{
    [SerializeField] float aliveTime = 3f;

    private void Awake() => Destroy(gameObject, aliveTime);
}
