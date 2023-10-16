using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : MonoBehaviour
{
    private GoldCounter goldCounter;
    [SerializeField] private int value;

    private void Start(){
        goldCounter = GoldCounter.instance;
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        RubyController controller = collider.GetComponent<RubyController>();
        if (controller != null)
        {
            goldCounter.ChangeGold(value);
            Destroy(gameObject);
        }
    }

}
