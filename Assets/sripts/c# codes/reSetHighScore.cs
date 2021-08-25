using UnityEngine;
using UnityEngine.UI;
// using UnityEngine.SceneManagement;
public class reSetHighScore : MonoBehaviour
{   
    [SerializeField]
    private Text HighScore;
    // Start is called before the first frame update

    public void ResetHighScore(){
        HighScore.text = "HighSocre Score:0";
        PlayerPrefs.SetInt("HighScore",0);
        UnityEngine.SceneManagement.SceneManager.LoadScene("High scores");
    }
}
