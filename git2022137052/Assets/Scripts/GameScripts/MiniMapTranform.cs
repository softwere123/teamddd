using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMapTranform : MonoBehaviour
{

    public GameObject MapData;
    public float mapMoveSpeed = 10.0f;

    public float flagPosition = -20.0f;

    public float changeTimer = 0.0f;
    public float changeCheckTime = 10.0f;

    public GameObject[] Mapobject;

    // Start is called before the first frame update
    void Start()
    {
        Mapobject = new GameObject[5];
    }
    
    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.position += new Vector3(0.0f, 0.0f, mapMoveSpeed * Time.deltaTime);

        changeTimer += Time.deltaTime;

        if (this.gameObject.transform.position.z <= -20.0f)
        {//for���� Ȱ���ؿ� ������ �ɼ��ֳ�? // if���������� �� �迭�� 1+�ұ�? �װ͵��� �޸��� Ȱ�䵵�Ǥ� ���̰� �ñ��ϴ�
            

            this.gameObject.transform.position += new Vector3(0.0f, 0.0f, 80.0f);
            

            //if (changeCheckTime <= changeTimer)
            //{
            //    GameObject temp = (GameObject)Instantiate(MapData);
            //    transform.position = this.gameObject.transform.position;
            //    Destroy(this.gameObject);

            //}
        }

       
    }

   

    //������Ų�� ���ο�� �� ����� ??
    
    
    //�÷��̾� �����ϴ�ĳ���Ͱ�
    //if (������Ʈ �����̽���)

    //{+ �ν��ٽ� > ������ > �ı��ϰų� > �ð������� ������� >   <Ÿ�ݽ�}
    //
}
