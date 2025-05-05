using UnityEngine;

public class Enemyball : MonoBehaviour
{
    void Update()
    {
        // ใส่ logic อื่น ๆ ในการเคลื่อนที่หรือเวลาได้ที่นี่ (ถ้ามี)
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Break"))
        {
            Destroy(collision.gameObject); // ทำลายวัตถุที่โดนชน
        }

     
    }
}
