using UnityEngine;
using UnityEngine.UI;

public class ScoreCalculator : MonoBehaviour
{
    #region Variables

    public Text ScoreNbr;
    public GameManager GameManagerScript;

    private Text score;

    #endregion

    void FixedUpdate()
    {
        RecordDistance();
    }
    void RecordDistance()
    {
        GameManagerScript.TotalScore += 1 % 4;
    }

    void Start()
    {
        score = ScoreNbr.GetComponent<Text>();
        GameManagerScript = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void Update()
    {
        score.text = GameManagerScript.TotalScore.ToString();
    }
}
