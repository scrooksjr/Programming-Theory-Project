using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SaveCharacterName : MonoBehaviour
{
    [SerializeField]
    TMPro.TMP_Text character_text;
    [SerializeField]
    TMP_InputField display_character_name;

    // Start is called before the first frame update
    void Start()
    {
        character_text.text = PlayerPrefs.GetString("character_name");
    }

    // Update is called once per frame
    void Update()
    {
        OnGUI();
    }

    public void OnGUI()
    {
        character_text.text = display_character_name.text;
        PlayerPrefs.SetString("character_name", character_text.text);
        PlayerPrefs.Save();
    }
}
