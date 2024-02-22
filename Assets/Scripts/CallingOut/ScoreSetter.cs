using TMPro;
using UnityEngine;

public class ScoreSetter : MonoBehaviour
{
    TextMeshProUGUI m_TextMeshPro;
    public static int score;
    void Start()
    {
        score = 0;
        m_TextMeshPro = GetComponent<TextMeshProUGUI>();
    }
    public void setText()
    {
        if(score >= 20)
        {
            SceneHandler.NextScene();
        }
        m_TextMeshPro.text = ("Score: "+ score);
    }
}
