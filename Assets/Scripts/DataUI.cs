using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class DataUI : MonoBehaviour
{
    [SerializeField] private GameObject tankObject;
    [SerializeField] private GameObject fuelObject;

    [SerializeField] private Text tankTxt;
    [SerializeField] private Text fuelTxt;
    [SerializeField] private Text powerTxt;


    private void Start()
    {
        tankTxt.text = tankObject.transform.position.ToString();
    }
}
