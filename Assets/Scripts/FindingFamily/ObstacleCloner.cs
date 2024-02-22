using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCloner : MonoBehaviour
{
    [SerializeField] List<GameObject> obstacles;
    [SerializeField] List<Transform> spawnLocations;
    public static float timer;
    private void OnEnable()
    {
        StartCoroutine(Cloner());
        timer = 0;
    }
    IEnumerator Cloner()
    {
        int index = 0;
        System.Random rnd = new();
        while (true)
        {
                if (!obstacles[index].activeSelf)
                {
                    obstacles[index].transform.position = spawnLocations[rnd.Next(spawnLocations.Count)].position;
                    obstacles[index].SetActive(true);
                }
                index++;
                index%=obstacles.Count;
            
            yield return new WaitForSeconds(0.15f);
            timer += 0.15f;
            if (timer > 60)
            {
                SceneHandler.NextScene();
            }
        }
    }
}
