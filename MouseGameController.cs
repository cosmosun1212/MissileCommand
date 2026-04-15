//IGameController interface를 통한 마우스 입력
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MouseGameController : IGameController
{
  public bool FireButtonPressed()
  {
    return Input.GetMouseButtonDown(0);
  }
}
