using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f; // �̵� �ӵ�

    public int PlayerHP;
    public int PlayerMax = 100;

    private void Start()
    {
        PlayerHP = PlayerMax;
    }

    private void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, verticalInput, 0f ).normalized * moveSpeed;

        // Rigidbody�� ����Ͽ� ������
        // Rigidbody�� ������ Transform�� ����� ���� �ֽ��ϴ�.
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.velocity = movement;
    }

    public void PlayerDamaged(int Damage)
    {
        PlayerHP -= Damage;

        if( PlayerHP < 0 )
        {
            Die();
        }
    }

    public void Die()
    {
       this.gameObject.SetActive( false );
    }
}
