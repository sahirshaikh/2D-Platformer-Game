using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;


public class PlayerLifeController : MonoBehaviour
{
    private TextMeshProUGUI LifeUI;
    public Animator PlayerAnimator;
    public GameObject PlayerPos;
      
      public int Life;
    private void Awake() {
        LifeUI = GetComponent<TextMeshProUGUI>();
    }

    void Start() {
        RefreshUI();

    }


    public void LifeDecrement()   
        {
            if (Life > 1) {
            Life -= 1;
            RefreshUI();

            PlayerPos.transform.position = new Vector3(0, 0, 0);

            }
            else if (Life == 1) {
            Life -= 1;
            RefreshUI();
            PlayerAnimator.SetTrigger("Death");

            Invoke("ReloadGame",2f);

        }

        }
    private void RefreshUI()
    {
        LifeUI.text = "Life : " + Life;
    }

    private void ReloadGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}