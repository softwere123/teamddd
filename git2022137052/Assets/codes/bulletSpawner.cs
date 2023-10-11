using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class bulletSpawner : MonoBehaviour
{
    public GameObject Prefabs;
    public float MoveForce = 10.0f;
    public float MoveSpeed = 5.0f;
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {

           
            
            GameObject Temp = (GameObject)Instantiate(Prefabs);
            Temp.transform.position = this.gameObject.transform.position;

           

        }
    }
}
