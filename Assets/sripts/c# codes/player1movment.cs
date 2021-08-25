// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class player1movment : MonoBehaviour

{
    [SerializeField]
    private float jumpForce = 14;
    [SerializeField]
    private float moveForce = 1.2f;

    // private Joystick joystick;
    public FixedJoystick joystick;
    private Rigidbody2D mybody;
    private Animator anime;
    private SpriteRenderer sr;

    private float movementX = 11f;
    private string Walk_animation = "walk";
    private string Jump_animation = "jump";
    private bool isGround = true;
    private string GROUND_TAG = "Ground";
    private string ENEMY_TAG = "Enemy";
    private int highScore;

    private void Awake()
    {

        mybody = GetComponent<Rigidbody2D>();
        anime = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();

    }
    // Start is called before the first frame update
    void Start()
    {
        highScore = PlayerPrefs.GetInt("HighScore",0);
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovementKeyboard();
        // PlayerMovementJoyjoystick();
        animePlayer();
    }

    private void FixedUpdate(){
        playerJump();

        
    }

    void PlayerMovementKeyboard()
    {

        movementX = Input.GetAxisRaw("Horizontal");
        

        transform.position += new Vector3(movementX, 0f, 0f) * Time.deltaTime * moveForce;
        
    }

    void PlayerMovementJoyjoystick()
    {

        if(joystick.Horizontal >= .5f){
            movementX  = 1.1f;

        }

        else if (joystick.Horizontal <= -.5f){
            movementX  = -1.1f;

        }
        

        transform.position += new Vector3(movementX, 0f, 0f) * Time.deltaTime * moveForce;

        
    }

    void animePlayer()
    {
        if (movementX > 0)
        {
            anime.SetBool(Walk_animation, true);
            sr.flipX = false;
        }

        else if (movementX < 0)
        {
            anime.SetBool(Walk_animation, true);
            sr.flipX = true;
        }
        else
        {
            anime.SetBool(Walk_animation, false);
        }
    }


    void playerJump(){
        if (Input.GetKeyDown("space") && isGround){
            isGround = false;
            mybody.AddForce(new Vector2(0f ,jumpForce),ForceMode2D.Impulse);
            anime.SetBool(Jump_animation,true);
            anime.SetBool(Walk_animation, false);

        }

    }


    // public void OnMouseDown() {
    //         if (isGround)
    //         {
    //             isGround = false;
    //             mybody.AddForce(new Vector2(0f ,jumpForce),ForceMode2D.Impulse);
    //             anime.SetBool(Jump_animation,true);
    //             anime.SetBool(Walk_animation, false);
    //         }

    // }



    private void OnCollisionEnter2D(Collision2D collistion)
    {
        if (collistion.gameObject.CompareTag(GROUND_TAG))
        {
            isGround = true;
            anime.SetBool(Jump_animation,false);
        }

        if (collistion.gameObject.CompareTag(ENEMY_TAG))
        {
            Destroy(gameObject);
            if(showScore.playScore > highScore){
                highScore = showScore.playScore;
                PlayerPrefs.SetInt("HighScore",showScore.playScore);
            }

            SceneManager.LoadScene("gameOver");
            showScore.playScore = 0;

        }
    }

    private void OnTriggerEnter2D(Collider2D collision) {

        if (collision.CompareTag(ENEMY_TAG))
        {
            Destroy(gameObject);
            if(showScore.playScore > highScore){
                highScore = showScore.playScore;
                PlayerPrefs.SetInt("HighScore",showScore.playScore);
            }

            SceneManager.LoadScene("gameOver");
            showScore.playScore = 0;

            
            
        }
            
        
    }
}
