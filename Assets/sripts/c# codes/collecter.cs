using UnityEngine;
using UnityEngine.SceneManagement;
public class collecter : MonoBehaviour
{
    private int highScore;
    // Start is called before the first frame update
    void Start()
    {
        highScore = PlayerPrefs.GetInt("HighScore");
        
    }

    // Update is called once per frame


    private void OnTriggerEnter2D(Collider2D collision) {
        // Debug.Log(collision.gameObject.name);
        if(collision.gameObject.name == "Players1"){
            if(showScore.playScore > highScore){
                highScore = showScore.playScore;
                PlayerPrefs.SetInt("HighScore",showScore.playScore);
            }
            SceneManager.LoadScene("gameOver");
        }

        else{

            Destroy(collision.gameObject);
        }


    }
}
