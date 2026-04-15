//IGameController interface에 의한 키보드 입력
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class KeyGameController : IGameController
{
  public bool FireButtonPressed()
  {
    return Input.GetKeyDown(KeyCode.Space);
  }
}
