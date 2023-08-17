using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class ScoreBoard : MonoBehaviour
{
    public Text[] scoresText_10Pair;
    public Text[] dateText_10Pair;

    public Text[] scoresText_15Pair;
    public Text[] dateText_15Pair;

    public Text[] scoresText_20Pair;
    public Text[] dateText_20Pair;

    void Start()
    {
        UpdateScoreBoard();
    }

    public void UpdateScoreBoard()
    {
        config.UpdateScoreList();

        DisplayPairsScoreData(config.ScoreTimeList10Pairs, config.PairNumberList10Pairs, scoresText_10Pair, dateText_10Pair);
        DisplayPairsScoreData(config.ScoreTimeList15Pairs, config.PairNumberList15Pairs, scoresText_15Pair, dateText_15Pair);
        DisplayPairsScoreData(config.ScoreTimeList20Pairs, config.PairNumberList20Pairs, scoresText_20Pair, dateText_20Pair);
    }

    private void DisplayPairsScoreData(float[] scoreTimeList, string[] pairNumberList, Text[] scoreText, Text[] dataText)
    {
        for (var index = 0; index < 3; index ++)
        {
            if (scoreTimeList[index] > 0)
            {
                var dataTime = Regex.Split(pairNumberList[index], "T");

                var minutes = Mathf.Floor(scoreTimeList[index] / 60);
                var seconds = Mathf.Floor(scoreTimeList[index] % 60);

                scoreText[index].text = minutes.ToString("00") + ":" + seconds.ToString("00");
                dataText[index].text = dataTime[0] + " " + dataTime[1];
            }
            else
            {
                scoreText[index].text = " ";
                dataText[index].text = " ";
             }
        }
    }

  
}
