using UnityEngine;
using UnityEngine.UI;

public class ScriptActivator : MonoBehaviour
{
    public GameObject scriptToActivate; // Ȱ��ȭ�� ��ũ��Ʈ�� ���� ���� ������Ʈ

    private void Start()
    {
        // ��ư Ŭ���� ȣ���� �Լ��� ���
        Button button = GetComponent<Button>();
        button.onClick.AddListener(ActivateScript);
    }

    void ActivateScript()
    {
        // ��ũ��Ʈ�� Ȱ��ȭ
        if (scriptToActivate != null)
        {
            scriptToActivate.SetActive(true);
            // ���� ��ũ��Ʈ�� MonoBehaviours�� �����ϰ� �ִٸ�, ���⼭ Ȱ��ȭ�� �� �ֽ��ϴ�.
            // ���� ���:
            // scriptToActivate.GetComponent<YourScript>().enabled = true;
        }
    }
}