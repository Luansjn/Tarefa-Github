using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InputName : MonoBehaviour
{
    public bool isPlayer;
    public InputField inputName;
    private void Start()
    {
        inputName.onValueChanged.AddListener(UpdateName);
    }
    public void UpdateName(string name)
    {
        if (isPlayer)
            SaveController.Instance.namePlayer = name;
        else
            SaveController.Instance.nameEnemy = name;
    }
}
