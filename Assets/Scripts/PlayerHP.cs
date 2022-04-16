using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{

    public int maxHealth = 100;
    public int currentHealt;
    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealt = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            TakeDamage(20);
        }
    }

    void TakeDamage(int damage)
    {
        currentHealt -= damage;

        healthBar.SetHealth(currentHealt);
    }
}
