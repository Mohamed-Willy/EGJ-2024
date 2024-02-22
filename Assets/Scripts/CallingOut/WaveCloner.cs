using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class WaveCloner : MonoBehaviour
{
    [SerializeField] List<GameObject> waves;
    void Start()
    {
        StartCoroutine(Clone());
    }
    IEnumerator Clone()
    {
        int index = 0;
        while (true)
        {
            if (!waves[index].activeSelf)
            {
                waves[index].SetActive(true);
            }
            index++;
            index %= waves.Count;
            yield return new WaitForSeconds(0.2f);
        }
    }
}
