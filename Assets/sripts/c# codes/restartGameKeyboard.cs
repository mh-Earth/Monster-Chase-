// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;

public class restartGameKeyboard : MonoBehaviour
{
    // Update is called once per frame
    void FixedUpdate()
    {   
        
        if(Input.GetKeyDown("space")){
            UnityEngine.SceneManagement.SceneManager.LoadScene("Main game");
            showScore.playScore = 0;

        }

        
    }
}
