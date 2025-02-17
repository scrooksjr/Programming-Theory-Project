using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CharacterName : MonoBehaviour
{
    [SerializeField] // expose private variable in the inspector.
    private TMPro.TMP_Text characterText;

    private void Update()
    {
        characterText.text = PlayerPrefs.GetString("character_name");
    }
}