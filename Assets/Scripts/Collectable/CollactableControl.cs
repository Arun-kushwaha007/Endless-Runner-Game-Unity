using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class CollactableControl : MonoBehaviour
{
    public static int coinCount;
    public GameObject coinCountDisplay;
    public GameObject coinEndDisplay;
    //private TMP_Text m_TextComponent;


    void Update()
    {
       
        coinCountDisplay.GetComponent<TMP_Text>().text = "" + coinCount;
        coinEndDisplay.GetComponent<TMP_Text>().text = "" + coinCount;
    }
}
