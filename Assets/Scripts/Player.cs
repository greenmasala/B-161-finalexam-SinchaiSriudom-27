using UnityEngine;

public class Player : MonoBehaviour
{
    private float moveSpeed = 5f;
    public float MoveSpeed
    {
        get { return moveSpeed; }
        private set { moveSpeed = value; }
    }

    private bool isVulnerable;
    public bool IsVulnerable
    {
        get { return isVulnerable; }
        private set { isVulnerable = value; }
    }

    private float jumpForce = 10f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

    void Update()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2(moveInput * MoveSpeed, rb.linearVelocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        PowerUpBase item = other.GetComponent<PowerUpBase>();
        if (item != null)
        {

        }
    }

    public void SetMoveSpeed(float newSpeed)
    {
        MoveSpeed *= newSpeed;
        Debug.Log($"Speed increased by {newSpeed}! Current Speed: {MoveSpeed}");
    }

    public void SetInvulnerability(bool isEnabled)
    {
        IsVulnerable = isEnabled;
        Debug.Log("Invulnerable state: "+ isEnabled);
    }
}
