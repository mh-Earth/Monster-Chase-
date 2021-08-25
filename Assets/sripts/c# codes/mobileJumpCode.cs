using UnityEngine;

public class mobileJumpCode : MonoBehaviour
{
    [SerializeField]
    private float MobilejumpForce = 14;


    private Rigidbody2D mybody;
    private Animator anime;
    private SpriteRenderer sr;

    private string Walk_animation = "walk";
    private string Jump_animation = "jump";
    private bool isGround = true;
    private string GROUND_TAG = "Ground";

    private void Awake()
    {

        mybody = GetComponent<Rigidbody2D>();
        anime = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();

    }
    private void FixedUpdate(){
        playerJumpMobile();
        
    }

    // void PlayerMovementKeyboard()
    // {

    //     movementX = Input.GetAxisRaw("Horizontal");
        

    //     transform.position += new Vector3(movementX, 0f, 0f) * Time.deltaTime * moveForce;

        
    // }


    public void playerJumpMobile(){
        if (Input.anyKeyDown && isGround){
            Debug.Log("JUMP..........");
            isGround = false;
            mybody.AddForce(new Vector2(0f ,MobilejumpForce),ForceMode2D.Impulse);
            anime.SetBool(Jump_animation,true);
            anime.SetBool(Walk_animation, false);

        }

    }


    private void OnCollisionEnter2D(Collision2D collistion)
    {
        if (collistion.gameObject.CompareTag(GROUND_TAG))
        {
            isGround = true;
            anime.SetBool(Jump_animation,false);
        }

    }

}
