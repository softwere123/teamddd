using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  //ui�� �ڵ�
public class HeartSysthem : MonoBehaviour
{
    public Image targetImage; // �̹��� ������Ʈ�� ���� ���� ������Ʈ ���
    public BulletDestroyed BD;

    // �������� ����� ���� ��
    public Color newColor = new Color(1.0f, 0.0f, 0.0f, 1.0f); // ������

    public void ChangeImageColor()
    {
      
    }

    public void Start()
    {
        targetImage = this.gameObject.GetComponent<Image>();
    }

    public void Update()
    {
        targetImage.fillAmount = BD.PlayerHP / 1000.0f;
    }

}
