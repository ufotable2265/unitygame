using UnityEngine;
using UnityEngine.UI; // UI 관련 기능 사용을 위해 필요
using UnityEngine.SceneManagement; // 씬 관리 관련 라이브러리

public class Gm : MonoBehaviour
{
    public Button myButton; // 변경할 버튼 GameObject를 드래그 앤 드롭으로 연결
    public Button myButton1; // 변경할 버튼 GameObject를 드래그 앤 드롭으로 연결

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            {
                // SampleScene 씬을 로드
                SceneManager.LoadScene("all has one");
            }

    }
}