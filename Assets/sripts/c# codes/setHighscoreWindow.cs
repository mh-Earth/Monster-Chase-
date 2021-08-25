using UnityEngine;
using UnityEngine.UI;
public class setHighscoreWindow : MonoBehaviour
{   
    [SerializeField]
    private Text setHighScore;
    private int highScore;
    // Start is called before the first frame update
    void Start()
    {
        highScore = PlayerPrefs.GetInt("HighScore");
    }

    // Update is called once per frame
    void Update()
    {

        setHighScore.text = "High Score:"+ highScore.ToString();
        
    }
}
