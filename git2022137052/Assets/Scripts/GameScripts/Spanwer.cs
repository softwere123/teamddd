using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spanwer : MonoBehaviour
{
    public GameObject MapData; // ������ �̴ϸ� ������ ���� ������Ʈ
    public float mapMoveSpeed = 10.0f; // �̴ϸ� �̵� �ӵ�

    public float changeTimer = 0.0f; // �̴ϸ� �̵� Ÿ�̸�
    public float changeCheckTime = 10.0f; // �̴ϸ� ���� �� ��ü ����

    // Update is called once per frame
    public Vector3 spawnPosition = new Vector3(0.0f, 0.0f, 0.0f);
    void Update()
    {
        // �� �����Ӹ��� �̴ϸ��� ���� �̵�
        this.gameObject.transform.position += new Vector3(0.0f, 0.0f, mapMoveSpeed * Time.deltaTime);

        // �ð��� �����ϴ� Ÿ�̸Ӹ� ����
        changeTimer += Time.deltaTime;

        // ���� �ð� ����(changeCheckTime)���� ���ο� �̴ϸ� ������ ���� �� ���� �̴ϸ� �ı�
        if (changeCheckTime <= changeTimer)
        {
            // ���ο� �̴ϸ� ������ ����
            GameObject temp = Instantiate(MapData, spawnPosition, Quaternion.identity);

            // ���ο� �̴ϸ� �������� ��ġ�� ���� �̴ϸʰ� �����ϰ� ����
            Destroy(this.gameObject);



            // Ÿ�̸� �ʱ�ȭ
            changeTimer = 0.0f;
        }
    }
}
