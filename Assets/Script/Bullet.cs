using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float lifeTime = 5f;

    void Start()
    {
        Destroy(gameObject, lifeTime); // ทำลายตัวเองหลัง 5 วินาที
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Breakable"))
        {
            Destroy(collision.gameObject); // ทำลายวัตถุที่ยิงโดน
        }

        Destroy(gameObject); // ทำลายกระสุน
    }
}
