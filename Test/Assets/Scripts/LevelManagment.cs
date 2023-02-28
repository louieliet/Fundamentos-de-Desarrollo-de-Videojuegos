using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManagment : MonoBehaviour
{
    public enum Levels{Menu = 0, Level001 = 1, Level02 = 2};
    
    public void ChangeLevel(Levels level){
        SceneManager.LoadScene((int)level);
    }
    
    public void ChangeLevel(int index){
        SceneManager.LoadScene(index);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player"){
            //GetComponent<LevelManagment>().ChangeLevel(LevelManagment.Levels.Level1);
            ChangeLevel(1);
        }
    }
}
