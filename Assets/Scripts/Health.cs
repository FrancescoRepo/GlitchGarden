using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float health = 200f;
    [SerializeField] private GameObject dieEffect;

    public void DealDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        GameObject deathVFX = Instantiate(dieEffect, transform.position, Quaternion.identity);
        Destroy(deathVFX, 1f);
        FindObjectOfType<StarDisplay>().AddStars(10);
        Destroy(gameObject);
        
    }
}
