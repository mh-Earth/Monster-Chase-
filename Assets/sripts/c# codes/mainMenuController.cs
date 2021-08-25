using UnityEngine;
using UnityEngine.SceneManagement;
public class mainMenuController : MonoBehaviour
{

    public void gamePlay(){
        SceneManager.LoadScene("Main game");
        showScore.playScore = 0;

        // string onClickobj = 

        // int onClickobj = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);

        // Debug.Log(onClickobj);

    }
    public void highScoreScene(){
        SceneManager.LoadScene("High scores");
        // string onClickobj = 

        // int onClickobj = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);

        // Debug.Log(onClickobj);

    }
    public void helpScene(){
        SceneManager.LoadScene("helpSecne");
        // string onClickobj = 

        // int onClickobj = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);

        // Debug.Log(onClickobj);

    }
    public void homeScene(){
        SceneManager.LoadScene("startup");
        // string onClickobj = 

        // int onClickobj = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);

        // Debug.Log(onClickobj);

    }
    public void ExitGame(){
        Debug.Log("Exiting");
        Application.Quit();

    }
}
