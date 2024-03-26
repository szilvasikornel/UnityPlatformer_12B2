using UnityEngine.UIElements;
using UnityEngine.UI;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private float maximumHealth = 5f;
    [SerializeField] private GameObject destroyFX;
    [SerializeField] private UnityEngine.UI.Slider healthBar;

    private float currentHealth;

    private void Start()
    {
        currentHealth = maximumHealth;
        healthBar.maxValue = maximumHealth;
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
