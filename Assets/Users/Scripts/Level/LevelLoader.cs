using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class LevelLoader : MonoBehaviour
{
    public string LevelName;
    private Button button;

    private void Awake() {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnButtonClick);        
    }

    private void OnButtonClick()
    {
        LevelStatus levelStatus = LevelManager.Instance.GetLevelStatus( LevelName );

        switch ( levelStatus )
        {
            case LevelStatus.Locked:
                SoundManager.Instance.Play(SoundManager.Sounds.ButtonClick);
                Debug.Log( "This Level is Locked" );
                break;
            case LevelStatus.Unlocked:
                SoundManager.Instance.Play(SoundManager.Sounds.ButtonClick);
                Debug.Log( "This Level is UnLocked" + LevelName );
                SceneManager.LoadScene( LevelName );
                break;
            case LevelStatus.Completed:
                SoundManager.Instance.Play(SoundManager.Sounds.ButtonClick);
                Debug.Log( "This Level is completed" + LevelName );
                SceneManager.LoadScene( LevelName );
                break;
        }
    }
}
