using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obj : MonoBehaviour
{
    [SerializeField] private float speed;
    private void Start()
    {
        Destroy(gameObject, 10f);
    }
    private void Update()
    {
        transform.Translate(new Vector2(0, -speed * Time.deltaTime));
    }
}
