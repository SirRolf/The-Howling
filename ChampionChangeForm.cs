using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChampionChangeForm : MonoBehaviour {

    private bool inForm1 = true;

    private SpriteRenderer spriteR;

    [Header("Sprites")]
    [SerializeField]
    private Sprite Form1;
    [SerializeField]
    private Sprite Form2;

    void Start()
    {
        spriteR = gameObject.GetComponent<SpriteRenderer>();

        GameObject knop = GameObject.Find("FormChanger");
        Button buttonComp = knop.GetComponent<Button>();

        buttonComp.onClick.AddListener(ChangeForm);
    }

    void Update()
    {
        if (inForm1 == true)
        {
            spriteR.sprite = Form1;
        }
        else
        {
            spriteR.sprite = Form2;
        }
    }

    public void ChangeForm()
    {
        GameObject.Find("Ability1").GetComponent<AbilityChange>().changeForm();
        GameObject.Find("Ability2").GetComponent<AbilityChange>().changeForm();
        GameObject.Find("Ability3").GetComponent<AbilityChange>().changeForm();
        GameObject.Find("Ability4").GetComponent<AbilityChange>().changeForm();
        GameObject.Find("icon").GetComponent<AbilityChange>().changeForm();
        inForm1 = !inForm1;
    }
}
