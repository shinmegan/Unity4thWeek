using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpController : MonoBehaviour
{
    //캐릭터 선택창
    public GameObject popUpImage;
    //order상 canvas가 popUpImage위에 위치해서 Entername을 꺼야함.
    public GameObject playerNameInput;
    //블루캐릭터
    public GameObject blueProfile;
    //핑크캐릭터
    public GameObject pinkProfile;
    //선택창 띄우는 버튼
    public GameObject popUpBtn;
    //블루캐릭터 선택 버튼
    public GameObject bluePickBtn;
    //핑크캐릭터 선택 버튼
    public GameObject pinkPickBtn;

    //캐릭터 선택창 띄우는 메서드
    public void CharacterChoicePopUp()
    {
        popUpImage.SetActive(true);
        playerNameInput.SetActive(false);
        popUpBtn.SetActive(false);
        bluePickBtn.SetActive(true );
        pinkPickBtn.SetActive(true );
    }

    //블루선택시 블루 캐릭터 활성화 메서드
    public void PickBlue()
    {
        ClosePopUp();
        blueProfile.SetActive(true);
        pinkProfile.SetActive(false);
    }

    //핑크선택시 핑크 캐릭터 활성화 메서드
    public void PickPink()
    {
        ClosePopUp();
        blueProfile.SetActive(false);
        pinkProfile.SetActive(true);
    }

    //선택창 닫는 메서드
    void ClosePopUp()
    {
        popUpImage.SetActive(false);
        playerNameInput.SetActive(true);
        popUpBtn.SetActive(true);
        bluePickBtn.SetActive(false);
        pinkPickBtn.SetActive(false);
    }
}
