using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int maxHealth;
    int currentHealth;

    public HealthBarScript healthBar;
    public Animator animator;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    public void TakeDamage (int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);

        if (currentHealth <= 0)
        {
            Die();

        }
    }

    void Die()
    {
        animator.SetBool("IsDead", true);
        GetComponent<Collider2D>().enabled = false;
        GetComponent<CircleCollider2D>().enabled = false;
    }
}
