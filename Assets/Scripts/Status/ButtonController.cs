using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    [SerializeField] private GameObject menuBtn;
    [SerializeField] private GameObject status;
    [SerializeField] private GameObject inventory;

    private void Start()
    {
        SetStartUI();
    }
    private void SetStartUI()
    {
        menuBtn.SetActive(true);
        status.SetActive(false);
        inventory.SetActive(false);
    }
    public void PressedInventoryBtn()
    {
        menuBtn.SetActive(false);
        inventory.SetActive(true);
    }
    public void PressedStatusBtn()
    {
        menuBtn.SetActive(false);
        status.SetActive(true);
    }

    public void PressedBackBtn()
    {
        menuBtn.SetActive(true);
        status.SetActive(false);
        inventory.SetActive(false);
    }
}
