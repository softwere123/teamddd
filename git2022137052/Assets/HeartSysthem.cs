using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HeartSysthem : MonoBehaviour
{
    public Image targetImage; // 이미지 컴포넌트를 가진 게임 오브젝트 대상

    // 예제에서 사용할 색상 값
    public Color newColor = new Color(1.0f, 0.0f, 0.0f, 1.0f); // 빨간색

    public void ChangeImageColor()
    {
        void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Bullet") || collision.gameObject.CompareTag("Player"))
            {
                if (targetImage != null)
                {
                    // 이미지의 색상 변경
                    targetImage.color = newColor;
                }
                else
                {
                    Debug.LogWarning("대상 이미지 컴포넌트를 찾을 수 없습니다.");
                }
            }
        }
    }
  
}
