using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwcitcher : MonoBehaviour
{
    [SerializeField] int index = -1;
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
