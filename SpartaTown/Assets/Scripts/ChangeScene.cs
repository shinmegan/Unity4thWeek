using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    //���ξ����� �̵� �޼���
    public void ChangeIntoMainScene()
    {
        SceneManager.LoadScene("MainScene");
    }
}
