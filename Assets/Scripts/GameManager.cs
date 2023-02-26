using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private int iScore;
    [SerializeField]
    private AudioSource asButton;
    [SerializeField]
    private TextMeshProUGUI tFeedback;
    public void vPlay()
    {
        asButton.Play();
        this.tFeedback.text = UnityEngine.Random.Range(1f, (3f + this.iScore++ / 2)) >= 3f ? "You've won , so lost. Go back to level " + (this.iScore-=this.iScore).ToString() + "." : "Draw or Lose Streak: " + this.iScore; // 1f - 2.9 draw or lose and 3 - 3 + (half of points)
    }

    public void vQuit()
    {
        Application.Quit();
    }
}
