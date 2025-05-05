using UnityEngine;
using TMPro; // สำหรับ TextMeshPro

public class CoinManager : MonoBehaviour
{
    public int coinCount = 0;

    public TextMeshProUGUI coinText; // ลากจาก Inspector

    void Start()
    {
        UpdateCoinUI();
    }

    public void AddCoin(int amount)
    {
        coinCount += amount;
        UpdateCoinUI();
        Debug.Log("เก็บเหรียญ! ตอนนี้มีเหรียญ: " + coinCount);
    }

    void UpdateCoinUI()
    {
        if (coinText != null)
        {
            coinText.text = "Coins: " + coinCount.ToString();
        }
    }

    public int GetCoinCount()
    {
        return coinCount;
    }
}
