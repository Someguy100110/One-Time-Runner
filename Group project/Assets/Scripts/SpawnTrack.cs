using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTrack : MonoBehaviour
{
    public GameObject[] array = new GameObject[4];

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i <= 12; i++)
        {
            Instantiate(array[Random.Range(0, 4)], new Vector3(0, 0, (i + 1) * 200 + 1), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
