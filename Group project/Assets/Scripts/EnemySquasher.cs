using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySquasher : MonoBehaviour
{
    playerMovement pm;
    // Start is called before the first frame update
    void Start()
    {
		pm = GameObject.Find("Player").
        GetComponent<playerMovement>();
	}

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
	{
        if(other.gameObject.CompareTag("Enemy") && pm.Smashing == true)
		{
			Destroy(other.gameObject);
		}
	}
}
