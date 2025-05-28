using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushExitButton : MonoBehaviour
{
    public void OnMouseUpAsButton()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
# else
Application.Quit();
#endif
    }
}
