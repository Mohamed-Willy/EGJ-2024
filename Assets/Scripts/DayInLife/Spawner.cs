using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] List<GameObject> obstacles;
    [SerializeField] List<Transform> locations;
    private void OnEnable()
    {
        StartCoroutine(Cloner());
    }
    IEnumerator Cloner()
    {
        int index = 0;
        System.Random rnd = new();
        while (true)
        {
            if (!obstacles[index].activeSelf)
            {
                obstacles[index].transform.position = locations[rnd.Next(locations.Count)].position;
                obstacles[index].SetActive(true);
                if(obstacles[index].transform.position.x > 0)
                {
                    obstacles[index].transform.eulerAngles = new(0, -90, 0);
                }
                if (obstacles[index].transform.position.x < 0)
                {
                    obstacles[index].transform.eulerAngles = new(0, 90, 0);
                }
            }
            index++;
            index %= obstacles.Count;

            yield return new WaitForSeconds(0.15f);
           
        }
    }
}
