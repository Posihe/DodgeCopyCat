using Unity.VisualScripting;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    [SerializeField]
    [Range(1, 10)]
    private int speed;

    private Rigidbody rb;
    private Animator anim;
    public int hp;

    private bool isWalk;
    private bool isDie;
   
   
   

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        isWalk = false;
        isDie = false;
        hp = 10;
       
    }

    void Update()
    {
        Move();

        Jump();

        
    }

    void Move()
    {
        float xinput = Input.GetAxis("Horizontal");
        float zinput = Input.GetAxis("Vertical");

        float xspeed = xinput * speed;
        float zspeed = zinput * speed;

        Vector3 m = new Vector3(xspeed, 0, zspeed);
        rb.linearVelocity = m;


        if (xinput != 0 || zinput != 0 )
        {
            isWalk = true;
            anim.SetBool("Walk", true);
        }
        else
        {
            isWalk = false;
            anim.SetBool("Walk", false);
        }
    }
    private void Jump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (anim.GetCurrentAnimatorStateInfo(1).normalizedTime > 0.5f)
            {

                anim.SetLayerWeight(1, 0); 
                anim.SetTrigger("Jump");

            }
           
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Potal1"))
        {
            other.gameObject.GetComponent<Potal>().StartCoroutine("teleport1");
           

        }
    }

    public void Die()
    {

        if(hp<=0)
        {
            
            isDie = true;
            Destroy(gameObject,3);
            
        }


    }


}

