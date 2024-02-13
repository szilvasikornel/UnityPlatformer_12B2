using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private GameObject bloodDrops;
    [SerializeField] private float maxHealth = 10f;
    private float currentHealt;

    private void Start()
    {
        currentHealt = maxHealth;
    }

    public void TakeDamage(float damage)
    {
        currentHealt -= damage;
        Instantiate(bloodDrops, transform.position, transform.rotation);

        if (currentHealt <= 0)
        {
            MakeDead();
        }
    }

    private void MakeDead()
    {
        Destroy(gameObject);
    }
}
