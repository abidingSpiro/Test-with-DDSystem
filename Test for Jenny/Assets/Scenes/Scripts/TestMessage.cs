using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;

public class TestMessage : MonoBehaviour
{
    public DialogManager DialogManager;

    public GameObject[] Example;

    private void Awake()
    {
        var dialogTexts = new List<DialogData>();

                
        dialogTexts.Add(new DialogData("welp, i found a cool dialogue system.", "Li"));

        dialogTexts.Add(new DialogData("/emote:Happy/ Something like this? ", "Li"));

        dialogTexts.Add(new DialogData("I think I can get the grid working tomorrow", "Li"));

        dialogTexts.Add(new DialogData("/emote:Happy/ that's all. buenas noches", "Li"));

        DialogManager.Show(dialogTexts);
    }

    private void Show_Example(int index)
    {
        Example[index].SetActive(true);
    }
}
