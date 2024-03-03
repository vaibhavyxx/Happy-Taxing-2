using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerInfo : MonoBehaviour
{
    // fields
    [SerializeField]
    private TextMeshProUGUI text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Funds: $" + Player.Instance.Money + "  Time: " + Player.Instance.Time + ":00\n" + 
                    "Debt: $" + Player.Instance.Debt;
    }
}
