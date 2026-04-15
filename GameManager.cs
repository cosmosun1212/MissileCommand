//
using System.Collections; 
using System.Collections.Generic; 
using UnityEngine;
public class GameManager : MonoBehaviour 
{ 
    [SerializeField] 
    BulletLauncher launcherPrefab; 
    BulletLauncher launcher; 
    // Start is called before the first frame update 
    void Start() 
    { 
        launcher = Instantiate(launcherPrefab); 
        launcher.SetGameController(new MouseGameController()); //Dependency Injection 코드
        //launcher.SetGameController(new KeyGameController()); //BulletLauncher launcher 하나로 하나의 입력만
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
