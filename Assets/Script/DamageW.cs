using UnityEngine;

public class DamageW : MonoBehaviour
{
    public int damageAmount = 2 ;

    private void OnTriggerEnter2D(Collider2D other)
    {
        // ตรวจสอบว่า Player ชนกับวัตถุนี้หรือไม่
        PlayerHealth player = other.GetComponent<PlayerHealth>();
        if (player != null)
        {
            player.TakeDamage(damageAmount); // ลดเลือด
        }
    }
}
