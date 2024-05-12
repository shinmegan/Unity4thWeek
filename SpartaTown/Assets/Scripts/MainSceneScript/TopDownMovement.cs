using UnityEngine;
using UnityEngine.EventSystems;

public class TopDownMovement : MonoBehaviour
{
    //실제로 이동이 일어날 컴포넌트
    private TopDownController movementController;
    private Rigidbody2D movementRigidbody;
    private Vector2 movementDirection = Vector2.zero; 
    private Transform tf;
    private Camera _camera;

    private void Awake() //주로 내 컴포넌트안에서 끝나는 것을 정의
    {
        // controller랑 TopdownMovement랑 같은 게임오브젝트 안에 있다라는 가정 하에.
        // 같은 게임오브젝트의 TopDownController, Rigidbody를 가져올 것 
        movementController = GetComponent<TopDownController>();
        movementRigidbody = GetComponent<Rigidbody2D>();
        _camera = Camera.main; 
        tf = transform; 
    }

    private void Start()
    {   // OnMoveEvent에 Move를 호출하라고 등록함
        movementController.OnMoveEvent += Move;
    }

    private void Update()
    {
        movementController.OnLookEvent += Look;
    }

    private void FixedUpdate() 
    {
        // 물리 업데이트에서 움직임 적용(rigidbody의 값을 변경)
        if(UIManager.instance.allowMovement)
            ApplyMovement(movementDirection);
    }

    private void Move(Vector2 direction)
    {
        // 이동방향만 정해두고 실제로 움직이지는 않음.
        // 움직이는 것은 물리 업데이트에서 진행(rigidbody가 물리니까)
        movementDirection = direction;
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * 5;
        movementRigidbody.velocity = direction;
    }


    //캐릭터의 시선을 실제로 변경
    private void Look(Vector2 direction)
    {   //실시간으로 마우스 위치를 추적
        Vector2 mousePosition = _camera.ScreenToWorldPoint(Input.mousePosition); 
        if (mousePosition.x < tf.position.x)
        {
            // 마우스의 x좌표가 캐릭터의 x좌표보다 작으면 좌측을 바라봄
            tf.localScale = new Vector2(-1,1);
            // 캐릭터의 이름도 좌측으로 반전
            UIManager.instance.playerNameTxt.rectTransform.localScale = new Vector2(-1, 1);
        }
        else if (mousePosition.x > tf.position.x)
        {
            // 마우스의 x좌표가 캐릭터의 x좌표보다 크면 우측을 바라봄
            tf.localScale = new Vector2(1,1);
            UIManager.instance.playerNameTxt.rectTransform.localScale = new Vector2(1, 1);
        }
    }
}
