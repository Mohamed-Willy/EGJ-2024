using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneScitcher : MonoBehaviour
{
    [SerializeField] int index;
    private void OnEnable()
    {
        if (index == -1)
        {
            SceneHandler.NextScene();
        }
        else
        {
            SceneManager.LoadScene(index);
        }
    }
}
