using UnityEngine;
enum Typo
{
    Destroyer, 
    Win,
    Lose
}
public class ObstacleDestroier : MonoBehaviour
{
    [SerializeField] Typo ColiderType;
    [SerializeField] ScoreSetter setter;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            other.gameObject.SetActive(false);
            if(ColiderType == Typo.Win)
            {
                ScoreSetter.score++;
                setter.setText();
            }
            if(ColiderType == Typo.Lose)
            {
                ScoreSetter.score--;
                setter.setText();
            }
        }
    }
}
