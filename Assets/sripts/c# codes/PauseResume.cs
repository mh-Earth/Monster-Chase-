using UnityEngine;
using UnityEngine.UI;
public class PauseResume : MonoBehaviour
{
    // Start is called before the first frame update


    [SerializeField]
    private Button button;

    [SerializeField]
    private Sprite PauseImage;
    [SerializeField]
    private Sprite ResumeImage;


    public void PauseResumeFunc()
    {
        if (Time.timeScale > 0)
        {
            Time.timeScale = 0;
            // Debug.Log("game has been pause");
            button.image.sprite = ResumeImage;
            // Debug.Log(button);
            // Debug.Log(ResumeImage);

        }

        else if (Time.timeScale < 1)
        {
            Time.timeScale = 1;
            // Debug.Log("game has been Resume");
            button.image.sprite = PauseImage;
        }

    }

    
}
