using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthUI : MonoBehaviour
{
    public Slider healthSlider;
    public PlayerHealth playerHealth;

    void Update()
    {
        if (healthSlider != null && playerHealth != null)
        {
            healthSlider.maxValue = playerHealth.maxHealth;
            healthSlider.value = playerHealth.GetCurrentHealth();
        }
    }
}