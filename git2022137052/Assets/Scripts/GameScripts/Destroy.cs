using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.Serialization;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public float destroyDelay = 5.0f; // �� �� �Ŀ� ������Ʈ�� �������� ������ �� �ֽ��ϴ�.

    void Start()
    {
        // destroyDelay �� �Ŀ� ���� ��ũ��Ʈ�� ����� ���� ������Ʈ�� �����մϴ�.
        Destroy(gameObject, destroyDelay);
    }
}