using AYellowpaper.SerializedCollections;
using NUnit.Framework;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class Couldron : MonoBehaviour
{
    public List<Herb> herbs = new();
    public SerializedDictionary<Element, int> elements = new();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.TryGetComponent(out Herb touchingHerb)) return;
        if (herbs.Contains(touchingHerb)) return;
        herbs.Add(touchingHerb);
        AddElements(touchingHerb);
        touchingHerb.enabled = false;
    }

    private void AddElements(Herb herb)
    {
        foreach (var element in herb.elements)
        {
            if (elements.ContainsKey(element.Key)){
                elements[element.Key] += element.Value;
            }
            else
            {
                elements[element.Key] = element.Value;
            }
        }
    }
}
