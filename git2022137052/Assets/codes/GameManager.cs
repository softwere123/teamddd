using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


// restart ����� ������
// ����� �� �� image restart�� ������ �ʰ� ����
public class GameManager : MonoBehaviour
{
   
    public void OnClickRestart()
    {
        //ù ����� �������� �ȴ�.
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public GameObject imageRestart;

    // Start is called before the first frame update
    void Start()
    {
        //Ȱ��ȭ, ��Ȱ��ȭ
       // imageRestart.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    //restart ��ư�� ������
 
}