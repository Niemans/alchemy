using AYellowpaper.SerializedCollections;
using System.Collections.Generic;
using UnityEngine;

public class Herb : MonoBehaviour
{
    public string herb_name;
    public string description;
    public SerializedDictionary<Element, int> elements = new();
    public string taste;
    public string smell;
    //dodaæ dodatkowe w³aœciwoœci



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
