using UnityEngine;
<<<<<<< HEAD
using UnityEngine.UIElements;
=======
using UnityEngine.UI;
>>>>>>> 043d641407a2189225633de14b0e15f92354a4ea

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private float maximumHealth = 5f;
    [SerializeField] private GameObject destroyFX;
    [SerializeField] private Slider healthBar;
<<<<<<< HEAD
=======

>>>>>>> 043d641407a2189225633de14b0e15f92354a4ea
    private float currentHealth;

    private void Start()
    {
        currentHealth = maximumHealth;
<<<<<<< HEAD
=======
        healthBar.maxValue = maximumHealth;
>>>>>>> 043d641407a2189225633de14b0e15f92354a4ea
        healthBar.value = currentHealth;
    }

    public void AddDamage(float damage)
    {
        currentHealth -= damage;
        if (!healthBar.IsActive()) healthBar.gameObject.SetActive(true);
        healthBar.value = currentHealth;
        if (currentHealth <= 0) MakeDead();
    }

    private void MakeDead()
    {
        Destroy(gameObject);
        Instantiate(destroyFX, transform.position, transform.rotation);
    }
}
