//Dependency Injection  코드 추가

using System.Collections; 
using System.Collections.Generic; 
using UnityEngine;
public class BulletLauncher : MonoBehaviour 
{ 
  IGameController controller;

  public void SetGameController(IGameController controller)
  {
      this.controller = controller;
  }

  //Dependecy Injection으로 전환할 경우 //Start()함수 삭제
  private void Start()
  {
      controller = new MouseGameController();
  }
  
  // Update is called once per frame
  void Update()
  {
      if (controller != null)
      {
          if (controller.FireButtonPressed())
          {
              Debug.Log("Fired a bullet!");
          }
      }
      else
      {
          Debug.Log("controller is null!");
      }
  }
}
