using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI text;

    private float time; //# of seconds remaining

    private void Update()
    {
        text.text = score.ToString();

        time -= Time.deltaTime;
    }
}
