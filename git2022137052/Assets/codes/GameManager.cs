using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


// restart 기능을 만들자
// 재시작 할 때 image restart를 보이지 않게 하자
public class GameManager : MonoBehaviour
{
  
    public void OnClickRestart()
    {
        //첫 장면을 가져오게 된다.
        //GetActiveScene.name를 통해 현재 scene의 이름을 받아온다.
        //LoadScene을 통해 해당 scene을 실행한다.z
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public GameObject imageRestart;

    // Start is called before the first frame update
    void Start()
    {
        //활성화, 비활성화
        imageRestart.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    //restart 버튼을 누르면
 
}