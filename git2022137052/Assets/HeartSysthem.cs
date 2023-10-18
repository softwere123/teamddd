using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HeartSysthem : MonoBehaviour
{
    public Image targetImage; // �̹��� ������Ʈ�� ���� ���� ������Ʈ ���

    // �������� ����� ���� ��
    public Color newColor = new Color(1.0f, 0.0f, 0.0f, 1.0f); // ������

    public void ChangeImageColor()
    {
        void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Bullet") || collision.gameObject.CompareTag("Player"))
            {
                if (targetImage != null)
                {
                    // �̹����� ���� ����
                    targetImage.color = newColor;
                }
                else
                {
                    Debug.LogWarning("��� �̹��� ������Ʈ�� ã�� �� �����ϴ�.");
                }
            }
        }
    }
  
}
