using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private GameObject bloodDrops;
    [SerializeField] private float maxHealth = 10f;
    [SerializeField] private Slider healthBar;
    [SerializeField] private Image bloodScreenFX;
    [SerializeField] private float fadeSmooth = 2f;

    private float currentHealt;
    private bool getDamage;

    private void Start()
    {
        getDamage = false;
        currentHealt = maxHealth;
        healthBar.maxValue = maxHealth;
        healthBar.value = maxHealth;
    }

    private void Update()
    {
        if (getDamage) bloodScreenFX.color = new(255, 255, 255, .8f);
        else
        {
            bloodScreenFX.color = Color.Lerp(
                bloodScreenFX.color,
                new(255, 255, 255, 0f),
                Time.deltaTime * fadeSmooth);
        }
        getDamage = false;
    }

    public void TakeDamage(float damage)
    {
        currentHealt -= damage;
        getDamage = true;
        healthBar.value = currentHealt;
        Instantiate(bloodDrops, transform.position, transform.rotation);

        if (currentHealt <= 0)
        {
            MakeDead();
        }
    }

    private void MakeDead()
    {
        Destroy(gameObject);
        bloodScreenFX.color = new(255, 255, 255, 1f);
    }
}
