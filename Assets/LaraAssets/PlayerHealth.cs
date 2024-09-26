using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private float maxHealth;

    private float currentHealth;
    public HealthBar HealthBar;
private void Start(){
    currentHealth = maxHealth;
    HealthBar.SetSliderMax(maxHealth);
    }

    public void TakeDamage(float amount)
    {
        currentHealth -= amount;
        HealthBar.SetSlider(currentHealth);
    }

}
