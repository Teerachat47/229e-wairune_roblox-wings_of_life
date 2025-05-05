using UnityEngine;

public class WinOnCollision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) // ตรวจแค่ Player เท่านั้น
        {
            Debug.Log("ชนะแล้ว! Player ชนเป้าหมาย");
            // ทำอะไรก็ได้ เช่น แสดง UI ชนะ หรือเปลี่ยนฉาก
            Time.timeScale = 0f; // หยุดเกม
        }
    }
}
