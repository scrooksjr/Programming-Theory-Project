using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SaveCharacterName : MonoBehaviour
{
    // ABSTRACTION

    public TMPro.TMP_Text character_text;
    public TMP_InputField display_character_name;


    // Start is called before the first frame update
    void Start()
    {
        character_text.text = PlayerPrefs.GetString("character_name");
    }

    // Update is called once per frame
    void Update()
    {
        CharacterName(); //call higher-level method
    }

    public void CharacterName() // higher-level method
    {
        character_text.text = display_character_name.text;
        PlayerPrefs.SetString("character_name", character_text.text);
        PlayerPrefs.Save();
    }
}