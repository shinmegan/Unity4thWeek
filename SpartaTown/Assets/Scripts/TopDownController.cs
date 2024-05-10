﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent; //Action은 무조건 void만 반환해야함(아니면 Func사용)
    public event Action<Vector2> OnLookEvent; //마우스

    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction); //? : 없으면 말고, 있으면 실행
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }

}