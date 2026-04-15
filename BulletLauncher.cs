public class BulletLauncher : MonoBehaviour
{ 
  IGameController controller;
  private void Start()
  {
      controller = new MouseGameController();
  }

  // Update is called once per frame
  void Update()
  {
          if (controller.FireButtonPressed())
          {
              Debug.Log("Fired a bullet!");
          }
  }
}
