using UnityEngine;

public class monsterMovment : MonoBehaviour
{

    [HideInInspector]
    public float speed;
    // Start is called before the first frame update
    private Rigidbody2D mybody;
    void Awake(){
        mybody = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        mybody.velocity = new Vector2(speed,mybody.velocity.y);
    }
}
