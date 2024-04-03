using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ammo : MonoBehaviour
{ 
    public TextMeshProUGUI ammoAmountText;

    private int _ammoAmmount = 10;
    // Start is called before the first frame update
    void Start()
    {
        //Display ammo amount
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    public void UpdateAmmoAmount()
    {
       _ammoAmmount -= 1;
       ammoAmountText.text = _ammoAmmount.ToString();
    }
     public void AddAmmo()
    {
        _ammoAmmount += 10;
         ammoAmountText.text = _ammoAmmount.ToString();
    }

    private void RemoveAmmo()
    {

    }
    private void DisplayAmmoAmount()
    {
        ammoAmountText = "Ammo" + _ammoAmmount.ToString();
    }
}
