using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreController : MonoBehaviour
{
    private TextMeshProUGUI ScoreUI;
    private int score = 0 ;

    private void Awake() {
        ScoreUI = GetComponent<TextMeshProUGUI>();
    }

    void Start() {
        RefreshUI();

    }

    public void Scoreincrement(int SC)   
        {
            score += SC;
            RefreshUI();
        }
    private void RefreshUI()
    {
        ScoreUI.text = "Score : " + score;
    }
}
