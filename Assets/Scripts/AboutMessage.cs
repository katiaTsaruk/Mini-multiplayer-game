using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AboutMessage : MonoBehaviour
{
    public void InitMessage(float time, Color color, float size, string text)
    {
        Text myText = this.GetComponent<Text>();
        myText.text = text;
        myText.color = color;
        myText.fontSize = (int)size;
        Invoke("Destroy", time);
    }
    void Destroy()
    {
        GameObject.Destroy(this.gameObject);
    }
}