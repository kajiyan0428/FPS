using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleChange : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.B))
        {
            SceneManager.LoadScene("Title Scene");
        }
    }
}
