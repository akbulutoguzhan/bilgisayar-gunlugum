using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] float delay;
    [SerializeField] float height;
    [SerializeField] GameObject pipes;
    float time = 0;

    private void Update()
    {

        if (time > delay)
        {
            GameObject spawner = Instantiate(pipes);
            spawner.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);

            time = 0;

            Destroy(spawner, 8);
        }

        time += Time.deltaTime;
    }
}
