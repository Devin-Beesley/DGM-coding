using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoad : MonoBehaviour {

	// Use this for initialization
	
	
	public void LoadLevel(string level){

   
        SceneManager.LoadScene(level);
    }
}
