using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class menuedie : MonoBehaviour
{
    // Start is called before the first frame update
    public void restart()
    {
      
       SceneManager.LoadScene("Level 1 remake");
     
    }
    public void Quitgame()
    {
        Debug.Log("menubatdau");
    }
    public void mainmenu()
    {
        SceneManager.LoadScene("menubatdau");
    }
}
