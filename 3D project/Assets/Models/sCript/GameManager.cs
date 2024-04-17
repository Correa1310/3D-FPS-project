using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI targetText;

    private int _targetAmount;

    public winScene;


    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Game Manager").GetComponent<Timer>();
        Cursor.lockState = CursorLockMode.Locked;
        int floatingTarget = GameObject.FindGameObjectsWithTag("TargetFloating").Length;
        int standingTarget = GameObject.FindGameObjectsWithTag("TargetStanding").Length;
        _targetAmount = floatingTarget + standingTarget;
        targetText.text = "Targets: " + _targetAmount.ToString();
    }

    void Update()
    {
        if(_timer.GetTimeRemaining)
        SceneManager.LoadScene(loseScene);
    }

    // Update is called once per frame
    public void UpdateTargetAmount()
    {
        _targetAmount -=1;
        targetText.text = "Targets: " + _targetAmount.ToString();

        if(_targetAmount <= 0)
        {
            //Stop timmer
            GameObject.Find("Game Manager").GetComponent<Timer>().EndGameTimer();
        }
    }
}
