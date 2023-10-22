using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed = 10f;
    public float JumpPower = 5f;

    private Rigidbody2D _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        if (horizontal != 0)
        {
            transform.Translate(horizontal * Speed * Time.deltaTime * Vector2.right);
        }

        if (Input.GetButtonDown("Jump"))
        {
            _rb.AddForce(Vector2.up * JumpPower, ForceMode2D.Impulse);
        }
    }
}
