using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class PrefabManager : MonoBehaviour
{
    public GameObject popUpPrefab;
    public GameObject bluePickBtnPrefab;
    public GameObject pinkPickBtnPrefab;

    public void OpenPopUp()
    {
        popUpPrefab.SetActive(true);
        bluePickBtnPrefab.SetActive(true);
        pinkPickBtnPrefab.SetActive(true);
    }

    public void ClosePopUp()
    {
        popUpPrefab.SetActive(false);
        bluePickBtnPrefab.SetActive(false);
        pinkPickBtnPrefab.SetActive(false);
    }

    //블루선택시 블루 캐릭터 활성화 메서드
    public void PickBlue()
    {
        PlayerPrefs.SetString("SelectedCharacterColor", "blue");
        ClosePopUp();
    }
    //핑크선택시 핑크 캐릭터 활성화 메서드
    public void PickPink()
    {
        PlayerPrefs.SetString("SelectedCharacterColor", "pink");
        ClosePopUp();
    }
}
