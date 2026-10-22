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

    // Переменная для индекса (из методички)
    private int indecs;

    public void Start()
    {
        Time.timeScale = 0; // Ставим игру на паузу при старте
    }

    public void OnClick(int indecs)
    {
        // 1. Выключаем симулятор, чтобы он не перехватывал управление
        if (XR_device_simulator != null)
            XR_device_simulator.SetActive(false);

        // 2. Выключаем ОБА префаба игрока (чтобы они не конфликтовали)
        XR_base_device.SetActive(false);
        XR_action_base.SetActive(false);

        // 3. Включаем ТОЛЬКО ТОТ, который выбрал пользователь
        if (indecs == 1)
        {
            XR_base_device.SetActive(true);
        }
        else if (indecs == 2)
        {
            XR_action_base.SetActive(true);
        }

        // 4. Прячем меню и снимаем паузу
       // System_Input_Canvas.gameObject.SetActive(false);
        Time.timeScale = 1;
    }
}