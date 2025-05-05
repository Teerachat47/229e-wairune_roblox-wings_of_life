using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 5;
    private int currentHealth;
    private CoinManager coinManager;
    
    public Transform spawnPoint; // ตัวแปรสำหรับตำแหน่งจุดเริ่มต้น

    void Start()
    {
        currentHealth = maxHealth;
        coinManager = FindObjectOfType<CoinManager>();

        // ถ้ามี spawnPoint ก็จะตั้งตำแหน่งตัวละครที่จุดเริ่มต้น
        if (spawnPoint != null)
        {
            transform.position = spawnPoint.position;
        }
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
        // รีเซ็ตตำแหน่งตัวละครไปยังจุดเริ่มต้น
        if (spawnPoint != null)
        {
            transform.position = spawnPoint.position;
        }
    }

    public int GetCurrentHealth()
    {
        return currentHealth;
    }
}
