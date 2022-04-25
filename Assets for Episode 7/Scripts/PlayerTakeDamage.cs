using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerTakeDamage : MonoBehaviour
{

    public int maxHealth = 100;
    public int currentHealth;

    public string Level;

    public HealthBar HealthBar;

    void Start()
    {
        currentHealth = maxHealth;
        HealthBar.SetMaxHealth(maxHealth);
    }

    void Update()
    {
        if(currentHealth <= 0)
        {
            SceneManager.LoadScene(Level);
        }
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        HealthBar.SetHealth(currentHealth);
    }

    public void MedKit()
    {
        currentHealth = maxHealth;

        HealthBar.SetHealth(currentHealth);
    }
}
