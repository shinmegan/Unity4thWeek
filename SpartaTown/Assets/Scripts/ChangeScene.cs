using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    //메인씬으로 이동 메서드
    public void ChangeIntoMainScene()
    {
        SceneManager.LoadScene("MainScene");
    }
}
