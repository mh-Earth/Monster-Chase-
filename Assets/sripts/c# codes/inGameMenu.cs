using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class inGameMenu : MonoBehaviour
{

    [SerializeField]
    private Sprite ResumeImage;
    [SerializeField]
    private Sprite PauseImage;
    [SerializeField]
    private Button pauseButton;
    public void RestartRunningGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        showScore.playScore = 0;

    }

    public void RestartGamePlay(){
        SceneManager.LoadScene("Main game");
        showScore.playScore = 0;
    }

    public void Home(){
        SceneManager.LoadScene("startup");
        showScore.playScore = 0;

    }


    }
