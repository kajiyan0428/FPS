using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PushGamestart : MonoBehaviour
{
    public void OnMouseUpAsButton()
    {
        SceneManager.LoadScene("MainScene");
    }
}
