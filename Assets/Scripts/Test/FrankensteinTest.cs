using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FrankensteinTest : MonoBehaviour, IDataPersistence
{
    public List<string> answers;

    public void LoadData(GameData data)
    {
        answers = data.frankensteinAns;
    }
    
    //set data in the list with toggles
    public void SetData(string key)
    {
        answers.Insert(key[0], key[1].ToString());
    }
    
    public void SaveData(GameData data)
    {
        data.frankensteinAns = answers;
    }
}
