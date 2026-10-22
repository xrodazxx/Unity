using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Management;

public class System_Input : MonoBehaviour
{
    [SerializeField] public Canvas System_Input_Canvas;
    [SerializeField] public GameObject XR_base_device;
    [SerializeField] public GameObject XR_action_base;
    [SerializeField] public GameObject XR_device_simulator;
    private int indecs;

    public void Start()
    {
        Time.timeScale = 0; // Пауза при старте
    }

    public void OnClick(int indecs)
    {

        // Выключаем обоих игроков перед включением нужного
        XR_base_device.SetActive(false);
        XR_action_base.SetActive(false);

        if (indecs == 1)
        {
            XR_base_device.SetActive(true);
        }
        else if (indecs == 2)
        {
            XR_action_base.SetActive(true);
        }

        System_Input_Canvas.gameObject.SetActive(false);
        Time.timeScale = 1; // Снимаем паузу
    }
}