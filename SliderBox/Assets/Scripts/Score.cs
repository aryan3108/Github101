using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    float s = 0.0f;
    
    void FixedUpdate()
    {
        s = -player.position.z;
        scoreText.text = s.ToString("0");
    }
}
