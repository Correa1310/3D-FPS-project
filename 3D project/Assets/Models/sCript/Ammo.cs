using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using Unity.VisualScripting;

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
        DisplayAmmoAmount();
    }

    private void RemoveAmmo()
    {
        _ammoAmmount += 1;
        DisplayAmmoAmount();
    }
    private void DisplayAmmoAmount()
    {
        ammoAmountText.text = "Ammo" + _ammoAmmount.ToString();
    }

     void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("AmmoBox"))
        {
            Destroy(other.gameObject);
            AddAmmo();
        }
    }
     void OntriggerEnter(Collision other)
    {
        if(other.gameObject.CompareTag("AmmoBox"))
        {
            Destroy(other.gameObject);
            AddAmmo();
        }
    }
}
