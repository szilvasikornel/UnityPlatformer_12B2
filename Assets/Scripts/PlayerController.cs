using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float maxSpeed = 7f;
    [SerializeField] private float jumpHeight = 150f;
<<<<<<< HEAD
    [SerializeField] private float fireRate = 0.5f;
=======
    [SerializeField] private float fireRate = .5f;
>>>>>>> b512a37e5f6adc94afaf824e093fda796fb06d1b

    [SerializeField] private Transform groundChecker;
    [SerializeField] private LayerMask groundLayer;

    [SerializeField] private Transform gunMuzzle;
    [SerializeField] private GameObject projectile;

    private Animator animator;
    private Rigidbody2D rigidbody2d;
    private bool isFacingRight;
    private bool isGrounded;
    private float nextFire;
<<<<<<< HEAD

=======
>>>>>>> b512a37e5f6adc94afaf824e093fda796fb06d1b

    private void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody2d = GetComponent<Rigidbody2D>();
        isFacingRight = true;
        isGrounded = false;
        nextFire = 0f;
    }

    private void Update()
    {
        if (isGrounded && Input.GetAxis("Jump") > 0)
        {
            isGrounded = false;
            animator.SetBool("isGrounded", false);
            rigidbody2d.AddForce(new Vector2(x:0, y:jumpHeight));
            rigidbody2d.AddForce(new(x:0, y:jumpHeight));
        }

        if (Time.time >= nextFire && Input.GetAxisRaw("Fire1") != 0)
        {
            nextFire = Time.time + fireRate;
<<<<<<< HEAD
            Instantiate(projectile, gunMuzzle.position, Quaternion.Euler(x: 0, y: 0,z: isFacingRight ? 0 : 180));
=======
            Instantiate(projectile, gunMuzzle.position, 
                Quaternion.Euler(x: 0, y: 0, z: isFacingRight ? 0 : 180));
>>>>>>> b512a37e5f6adc94afaf824e093fda796fb06d1b
        }
    }

    private void FixedUpdate()
    {
        float move = Input.GetAxis("Horizontal");
        animator.SetFloat("speed", Mathf.Abs(move));
        rigidbody2d.velocity = new(
            x: move * maxSpeed,
            y: rigidbody2d.velocity.y);
        if ((move > 0 && !isFacingRight) || (move < 0 && isFacingRight)) Flip();

        isGrounded = Physics2D.OverlapCircle(groundChecker.position, .15f, groundLayer);
        animator.SetBool("isGrounded", isGrounded);
        animator.SetFloat("verticalSpeed", rigidbody2d.velocity.y);
    }
    private void Flip()
    {
        isFacingRight = !isFacingRight;
        transform.localScale = new(
            x: transform.localScale.x * -1,
            y: transform.localScale.y,
            z: transform.localScale.z);
    }
}
