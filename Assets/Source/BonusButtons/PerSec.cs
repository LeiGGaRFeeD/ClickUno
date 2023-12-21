using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PerSec : MonoBehaviour
{
    [SerializeField] private Text _price;
    [SerializeField] private Text _amount;

    private float price = 100;
    private float increaseX = 2;
    private float amount =1;
    void Start()
    {
        InvokeRepeating("Sec", 0, 1);
    }
    public void Sec()
    {
        Debug.Log("Sec past");
        PlayerPrefs.SetFloat("money", (PlayerPrefs.GetFloat("money") + amount));
    }
    public void Buy()
    {
        Debug.Log("Button clicked");
        float a = (PlayerPrefs.GetFloat("money"));
        if (a <= price)
        {
            Debug.Log("Buy ok");
            PlayerPrefs.SetFloat("money", PlayerPrefs.GetFloat("money") - price);
            price = price * increaseX;
            amount = amount + increaseX;
        }
    }

    public void Update()
    {
        _price.text = price.ToString();
        _amount.text = amount.ToString();
    }
}
