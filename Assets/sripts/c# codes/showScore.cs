using UnityEngine;
using UnityEngine.UI;
public class showScore : MonoBehaviour
{
    [SerializeField]
    private Text score;
    private float timer = 0;

    public static int playScore;
    // Update is called once per frame
    void FixedUpdate()
    {
        updateScore();
    }

    void updateScore()
    {

        timer = Time.time;
        if (Time.timeScale > 0)
        {

            if (timer > 10f)
            {

                playScore += 1;
                timer = 0f;
                score.text = "Score: " + playScore.ToString("0");
            }

        }

    }


}
