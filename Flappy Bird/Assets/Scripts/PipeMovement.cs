using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    [SerializeField] float movementSpeed;

    private void Update()
    {
        transform.position += Vector3.left * movementSpeed * Time.deltaTime;
    }
}
