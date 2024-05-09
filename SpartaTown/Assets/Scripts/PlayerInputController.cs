using UnityEngine.InputSystem;
using UnityEngine;

public class PlayerInputController : TopDownController
{
    private Camera _camera;
    private void Awake()
    {
        _camera = Camera.main; //mainCamera라는 태그가 붙어있는 카메라를 가져온다.
    }

    public void OnMove(InputValue value)
    {
        // Debug.Log("OnMove" + value.ToString());
        Vector2 moveInput = value.Get<Vector2>().normalized; //크기 1인 벡터로 바로 변경.
        CallMoveEvent(moveInput); //TopDownController 클래스 메서드 사용
        //실제 움직이는 처리는 여기서 하는게 아니라 PlayerMovement에서 함.
    }

    public void OnLook(InputValue value)
    {
        // Debug.Log("OnLook" + value.ToString());
        Vector2 newAim = value.Get<Vector2>();
        Vector2 worldPos = _camera.ScreenToWorldPoint(newAim); //카메라를 기준으로 스크린 속 마우스 좌표를 월드좌표로 변경
        newAim = (worldPos - (Vector2)transform.position).normalized; //transform.position에서 월드좌표로 이동.(T -> W) = W - T

        if (newAim.magnitude >= .9f)
        // Vector 값을 실수로 변환
        {
            CallLookEvent(newAim);
        }
    }

    public void OnFire(InputValue value)
    {
        Debug.Log("OnFire" + value.ToString());
    }
}
