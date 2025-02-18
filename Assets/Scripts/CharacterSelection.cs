using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;

public class CharacterSelection : MonoBehaviour
{
    [SerializeField]
    GameObject[] character;

    [System.Serializable]
    public enum ChooseCharacter
    {
        Character1,
        Character2,
        Character3
    }

    public ChooseCharacter theCharacter;

    public void Update()
    {
        switch (theCharacter)
        {
            case ChooseCharacter.Character1:
                character[0].SetActive(true);
                character[1].SetActive(false);
                character[2].SetActive(false);
                break;
            case ChooseCharacter.Character2:
                character[0].SetActive(false);
                character[1].SetActive(true);
                character[2].SetActive(false);
                break;
            case ChooseCharacter.Character3:
                character[0].SetActive(false);
                character[1].SetActive(false);
                character[2].SetActive(true);
                break;
            default:
                character[0].SetActive(true);
                break;
        }
    }
}