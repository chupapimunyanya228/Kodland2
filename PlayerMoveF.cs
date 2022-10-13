using UnityEngine;

public class PlayerMoveF : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float jumpSpeed;
    Rigidbody rb;
    Vector3 direction;
    Vector3 startPosition;
    bool isGrounded;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        startPosition = transform.position;
    }
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        if (x==0 && z==0)
        { 
            GetComponent<Animator>().SetBool("Run", false);
            GetComponent<Animator>().SetBool("Slide", false);
        }
        else
        {
            GetComponent<Animator>().SetBool("Run", true);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            GetComponent<Animator>().SetBool("RunLeft", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("RunLeft", false);
        }
        if ((Input.GetKeyDown(KeyCode.LeftShift)) && (x!=0 && z!=0))
        {
            GetComponent<Animator>().SetBool("Slide", true);
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            GetComponent<Animator>().SetBool("Slide", false);    
        }


        direction = transform.TransformDirection(x, 0, z);
        if(isGrounded)
        {
            GetComponent<Animator>().SetBool("JumpStart", false);
            GetComponent<Animator>().SetBool("Jump", false);
            GetComponent<Animator>().SetBool("JumpEnd", false);
            if(Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(new Vector3(0, jumpSpeed, 0), ForceMode.Impulse);
            }
            
        }
        else
        {
            GetComponent<Animator>().SetBool("JumpStart", true);
            GetComponent<Animator>().SetBool("Jump", true);
            GetComponent<Animator>().SetBool("JumpEnd", true);
        }
        
        if (transform.position.y < -480)
        {
            transform.position = startPosition;
        }
    }
    private void FixedUpdate()
    {
        rb.MovePosition(transform.position + direction * speed * Time.fixedDeltaTime);
    }

    private void OnCollisionStay(Collision other)
    {
        if (other != null)
        {
            isGrounded = true;
        }
    }
    private void OnCollisionExit(Collision other)
    {
        isGrounded = false;

        if(CompareTag("Chekpoint"))
        {
            startPosition = transform.position;    
        }
    }
    
}