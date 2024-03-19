using UnityEngine;
using UnityEngine.UIElements;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private float maximumHealth = 5f;
    [SerializeField] private GameObject destroyFX;
    [SerializeField] private Slider healthBar;
    private float currentHealth;

    private void Start()
    {
        currentHealth = maximumHealth;
        healthBar.value = currentHealth;
    }

    public void AddDamage(float damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0) MakeDead();
    }

    private void MakeDead()
    {
        Destroy(gameObject);
        Instantiate(destroyFX, transform.position, transform.rotation);
    }
}
