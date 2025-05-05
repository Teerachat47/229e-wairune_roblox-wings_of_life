using UnityEngine;

public class Coin : MonoBehaviour
{
    public int coinValue = 1;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            CoinManager coinManager = FindObjectOfType<CoinManager>();
            if (coinManager != null)
            {
                coinManager.AddCoin(coinValue);
            }

            Destroy(gameObject); // ลบเหรียญหลังเก็บ
        }
    }
}
