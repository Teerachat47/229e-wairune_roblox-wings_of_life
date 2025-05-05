using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jetpackForce = 7f;
    public float jetCooldown = 0.3f; // เวลารอระหว่างการใช้ jet (วินาที)

    float moveX;
    float nextJetTime = 0f;

    Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        moveX = Input.GetAxis("Horizontal");
    }

    void FixedUpdate()
    {
        rb2d.velocity = new Vector2(moveX * moveSpeed, rb2d.velocity.y);

        // เช็กว่ากด Space และผ่านคูลดาวน์แล้วหรือยัง
        if (Input.GetKey(KeyCode.Space) && Time.time >= nextJetTime)
        {
            rb2d.AddForce(Vector2.up * jetpackForce, ForceMode2D.Impulse);

            // อัปเดตเวลาครั้งถัดไปที่จะใช้ jet ได้
            nextJetTime = Time.time + jetCooldown;
        }
    }
}