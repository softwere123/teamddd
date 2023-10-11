using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BulletmoveDestroyed : MonoBehaviour
{
    //�����̴� �ڵ� ����
    public float BulletmoveSpeed = 10.0f;
    public float BulletmoveDirection = 10.0f;
    
    // Start is called before the first frame update
    
    
        void Start()
        {
            SpawnCheckTime = SpawnTime;
        }
    
    

   
    void Update()
    {
        // �Ѿ� �����̴� �ڵ�
        Vector3 moveDirection = new Vector3(0.0f, 0.0f, BulletmoveDirection);
        this.transform.Translate(moveDirection * BulletmoveDirection * Time.deltaTime);
        //�Ѿ� �ð������� �����ϴ��ڵ�
        
        SpawnCheckTime -= Time.deltaTime;

        if (SpawnCheckTime <= 0.0f)
        {
            SpawnCheckTime = SpawnTime;
            Destroy(gameObject);

        }
    }
    //�ð������� ���� ����
    

    public float SpawnTime = 3.0f;
    public float SpawnCheckTime = 0.0f;

   
    
    


    
}



