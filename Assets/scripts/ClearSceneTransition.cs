using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearSceneTransition : MonoBehaviour
{
    [SerializeField]
    ScoreChanger_ scoreChanger;

    [SerializeField]
    GameObject ClearUI;
   
    // Update is called once per frame
    public void Update()
    {
        if (scoreChanger.numberOfItem == 0)
        {
            SceneManager.LoadScene("GameClearScene");
        }
        
    }
}
