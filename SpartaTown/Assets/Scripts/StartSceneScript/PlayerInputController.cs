using UnityEngine.InputSystem;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInputController : TopDownController
{
    private Camera _camera;
    private void Awake()
    {
        //mainCamera라는 태그가 붙어있는 카메라를 가져온다.
        _camera = Camera.main; 
    }

    public void OnMove(InputValue value)
    {
        //크기 1인 벡터로 바로 변경.
        Vector2 moveInput = value.Get<Vector2>().normalized;
        //상위 클래스 메서드 사용(실제 움직이는 처리는 TopDownMovement에서 함)
        CallMoveEvent(moveInput); 
    }

    public void OnLook(InputValue value)  
    {
        //마우스 입력을 받음
        Vector2 newAim = value.Get<Vector2>();
        //카메라를 기준으로 스크린 속 마우스 좌표를 월드좌표로 변경
        Vector2 worldPos = _camera.ScreenToWorldPoint(newAim);
        //캐릭터의 시선 방향 = 마우스 월드좌표 - 캐릭터 위치 좌표 (C -> M) = M - C
        newAim = (worldPos - (Vector2)transform.position).normalized;

        // Vector 값을 실수로 변환
        if (newAim.magnitude >= .9f)
        {
            CallLookEvent(newAim);
        }
    }

    public void OnFire(InputValue value)
    {
        Debug.Log("OnFire" + value.ToString());
    }
}
