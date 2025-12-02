using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    public float MoveSpeed //made property of each variable that needs to be changed 
    {
        get { return moveSpeed; }
        private set { moveSpeed = value; }
    }

    [SerializeField] private bool isVulnerable;
    public bool IsVulnerable
    {
        get { return isVulnerable; }
        private set { isVulnerable = value; }
    }

    [SerializeField] private float jumpForce = 7f;
    public float JumpForce
    {
        get { return jumpForce; }
        private set { jumpForce = value; }
    }

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
            item.ApplyEffect(this);
            Destroy(item.gameObject);
        }
    }

    public void SetMoveSpeed(float newSpeed) //variables with properties can only be changed via methods. 
    {
        MoveSpeed *= newSpeed;
        Debug.Log($"Speed multiplied by {newSpeed}! Current Speed: {MoveSpeed}");
    }

    public void SetJumpForce(float newForce)
    {
        JumpForce *= newForce;
        Debug.Log($"Jump force multiplied by {newForce}! Current Jump Force: {JumpForce}");
    }

    public void SetInvulnerability(bool isEnabled)
    {
        IsVulnerable = isEnabled;
        Debug.Log("Invulnerable state: "+ isEnabled);
    }
}
