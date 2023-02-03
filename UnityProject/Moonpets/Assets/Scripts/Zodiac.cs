using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Zodiac", menuName = "Zodiac", order = 2)]
public class Zodiac : ScriptableObject
{
    public string zodiacName = "";
    public string startDate;
    public string endDate;

    public Characteristic[] characteristics;
}
