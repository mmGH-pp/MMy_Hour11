using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prefab_Gen2 : MonoBehaviour
{
    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
         
    
    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
    
        for (int i = 0; i < 10; i++)
        {
            Vector3 spawnPosition = transform.position + new Vector3(-i + 3, -1, -3);

            Instantiate(prefab, spawnPosition, transform.rotation);

            
        }
    
    }
}
