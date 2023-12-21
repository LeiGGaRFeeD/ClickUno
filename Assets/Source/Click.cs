using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class Click : MonoBehaviour
{
    [SerializeField] private bool _debugMode;
    private void Start()
    {
        if (PlayerPrefs.GetFloat("PerTap")<= 0)
        {
            PlayerPrefs.SetFloat("PerTap", 1);
        }
    }
    public void Tap()
    {
        PlayerPrefs.SetFloat("coins", PlayerPrefs.GetFloat("coins") + PlayerPrefs.GetFloat("PerTap"));

        if (_debugMode == true)
        {
            Debug.Log("Coins: "+PlayerPrefs.GetFloat("coins"));
            Debug.Log("PerTap: " + PlayerPrefs.GetFloat("PerTap"));
        }
    }
}
 