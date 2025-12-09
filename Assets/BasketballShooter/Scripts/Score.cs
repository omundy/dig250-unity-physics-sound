using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int score;
    public TMP_Text scoreText;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            score++;
            scoreText.text = score.ToString();
        }

    }

}
