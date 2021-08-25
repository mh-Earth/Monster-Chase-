using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2movment : MonoBehaviour
{   
    [SerializeField]
    private float jumpForce = 14;
    [SerializeField]
    private float moveForce = 10f;

    private Rigidbody2D mybody;
    private Animator anime;
    private SpriteRenderer sr;

    private float movementX = 11f;
    private string Walk_animation = "walk";
    private bool isGround = true;
    private string GROUND_TAG = "Ground";

    private void Awake(){

        mybody = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        anime = GetComponent<Animator>();
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

        private void FixedUpdate(){
        playerJump();
        
    }

    // Update is called once per frame
    void Update()
    {
        playerMovementKeyboard();
        playeranime();
    }


    private void playerMovementKeyboard(){
        movementX = Input.GetAxisRaw("Horizontal");

        transform.position += new Vector3 (movementX,0f,0f) *moveForce * Time.deltaTime;
    }


    private void playeranime(){

        if (movementX > 0)
        {
            anime.SetBool(Walk_animation,true);
            sr.flipX = false;

        }


        else if (movementX < 0){

            anime.SetBool(Walk_animation,true);
            sr.flipX = true;

        }

        else{
            anime.SetBool(Walk_animation,false);
        }


    }

    
    public void playerJump(){
        if (Input.GetKeyDown("space") && isGround){
            isGround = false;
            mybody.AddForce(new Vector2(0f ,jumpForce),ForceMode2D.Impulse);

        }

    }


    private void OnCollisionEnter2D(Collision2D collistion)
    {
        if (collistion.gameObject.CompareTag(GROUND_TAG))
        {
            isGround = true;
        }

    }
}
