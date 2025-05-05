using UnityEngine;


public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 5;
    private int currentHealth;
    private CoinManager coinManager;


    void Start()
    {
        currentHealth = maxHealth;
        coinManager = FindObjectOfType<CoinManager>();

    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log("โดนตี! HP: " + currentHealth);

        if (currentHealth <= 0)
        {
            Die();
        }

        if (currentHealth < 0) currentHealth = 0;

        
    }


    public void Heal(int amount)
    {
        currentHealth += amount;
        if (currentHealth > maxHealth)
            currentHealth = maxHealth;  

        Debug.Log("ได้ Heal! HP: " + currentHealth);
        
        
        
    }

    void Die()
    {
        Debug.Log("Player ตายแล้ว!");
        // ทำลายตัวละคร / เล่นอนิเมชัน / รีเซ็ตฉากได้ที่นี่
    }
    public int GetCurrentHealth()
    {
        return currentHealth;
    }

}

