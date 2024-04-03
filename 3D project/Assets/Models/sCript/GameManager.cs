using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI targetText;

    private int _targetAmount;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        int floatingTarget = gameObject.FindGameObjectsWithTag("TargetFloating").Length
        int standingTarget = gameObject.FindGameObjectsWithTag("TargetStanding").Length
        _targetAmount = floatingTarget + standingTarget;
        targetText.text = "Targets: " + _targetAmount.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
