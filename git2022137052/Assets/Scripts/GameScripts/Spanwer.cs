using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spanwer : MonoBehaviour
{
    public GameObject MapData;
    public float mapMoveSpeed = 10.0f;

    public float changeTimer = 0.0f;
    public float changeCheckTime = 10.0f;

   
    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.position += new Vector3(0.0f, 0.0f, mapMoveSpeed * Time.deltaTime);

        changeTimer += Time.deltaTime;

        if (changeCheckTime <= changeTimer)
        {
            GameObject temp = (GameObject)Instantiate(MapData);
            transform.position = this.gameObject.transform.position;
            Destroy(this.gameObject);

            changeTimer = 0.0f;
        }


    }

}
