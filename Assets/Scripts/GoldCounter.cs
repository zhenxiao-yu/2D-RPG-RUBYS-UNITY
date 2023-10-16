using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GoldCounter : MonoBehaviour
{
    public static GoldCounter instance;
    [SerializeField] private TMP_Text goldText;

    private int gold;

    public void Awake() {
        if (instance == null) {
            instance = this;
        }
    }

    private void OnGUI() {
        goldText.text = gold.ToString();
    }


    public void ChangeGold(int amount) {
        gold += amount;
    }
}