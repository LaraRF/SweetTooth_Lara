using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private float maxHealth;
    public Healthbar Healthbar;

    private float currentHealth;
    
private void Start()
    {
    currentHealth = maxHealth;
    Healthbar.SetSliderMax(maxHealth);
    }

    private void Update()
    {
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    public void TakeDamage(float amount)
    {
        currentHealth -= amount;
        Healthbar.SetSlider(currentHealth);
    }

    private void Die()
    {
        Debug.Log("You died!");

        //Play death animation

        //Activate death screen

    }

}
