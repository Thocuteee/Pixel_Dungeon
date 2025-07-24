using UnityEngine;

public class HeroMove : MonoBehaviour
{
    public float speed = 5f;
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        // Di chuyển
        Vector3 move = new Vector3(moveX, moveY, 0f).normalized;
        transform.position += move * speed * Time.deltaTime;

        // Gửi hướng vào Animator
        anim.SetFloat("moveX", moveX);
        anim.SetFloat("moveY", moveY);
    }
}