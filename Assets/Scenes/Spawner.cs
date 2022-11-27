using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float time;

    [SerializeField] private GameObject[] box;

    private void Start()
    {
        Instantiate(box[Random.Range(0, box.Length)], transform.position, Quaternion.identity);
        StartCoroutine(Spawnobj());
    }
    private IEnumerator Spawnobj()
    {
        yield return new WaitForSeconds(time);

        Instantiate(box[Random.Range(0, box.Length)], transform.position, Quaternion.identity);
        StartCoroutine(Spawnobj());
    }
}
