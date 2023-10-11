using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BulletmoveDestroyed : MonoBehaviour
{
    //움직이는 코드 변수
    public float BulletmoveSpeed = 10.0f;
    public float BulletmoveDirection = 10.0f;
    
    // Start is called before the first frame update
    
    
        void Start()
        {
            SpawnCheckTime = SpawnTime;
        }
    
    

   
    void Update()
    {
        // 총알 움직이는 코드
        Vector3 moveDirection = new Vector3(0.0f, 0.0f, BulletmoveDirection);
        this.transform.Translate(moveDirection * BulletmoveDirection * Time.deltaTime);
        //총알 시간지나면 삭제하는코드
        
        SpawnCheckTime -= Time.deltaTime;

        if (SpawnCheckTime <= 0.0f)
        {
            SpawnCheckTime = SpawnTime;
            Destroy(gameObject);

        }
    }
    //시간지나면 삭제 변수
    

    public float SpawnTime = 3.0f;
    public float SpawnCheckTime = 0.0f;

   
    
    


    
}



