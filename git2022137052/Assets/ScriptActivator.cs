using UnityEngine;
using UnityEngine.UI;

public class ScriptActivator : MonoBehaviour
{
    public GameObject scriptToActivate; // 활성화할 스크립트를 가진 게임 오브젝트

    private void Start()
    {
        // 버튼 클릭시 호출할 함수를 등록
        Button button = GetComponent<Button>();
        button.onClick.AddListener(ActivateScript);
    }

    void ActivateScript()
    {
        // 스크립트를 활성화
        if (scriptToActivate != null)
        {
            scriptToActivate.SetActive(true);
            // 만약 스크립트가 MonoBehaviours를 포함하고 있다면, 여기서 활성화할 수 있습니다.
            // 예를 들어:
            // scriptToActivate.GetComponent<YourScript>().enabled = true;
        }
    }
}