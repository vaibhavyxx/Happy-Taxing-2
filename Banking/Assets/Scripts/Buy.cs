using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buy : MonoBehaviour
{
    [SerializeField] GameObject paymentPanel;
    [SerializeField] Button buyButton;

    void Start()
    {
        paymentPanel.SetActive(false);

        // Get a reference to the Button component attached to the Buy button
        buyButton = GetComponent<Button>();

        // Add an event listener to the Buy button
        buyButton.onClick.AddListener(ShowPaymentPanel);
    }

    public void ShowPaymentPanel()
    {
        // Activate the payment panel
        paymentPanel.SetActive(true);
    }

}
