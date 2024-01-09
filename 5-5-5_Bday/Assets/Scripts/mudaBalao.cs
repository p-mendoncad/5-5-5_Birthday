using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mudaBalao : MonoBehaviour
{
    public Text Text;

    string num = mudaContador.numBaloes.ToString();
    // Start is called before the first frame update
    void Start()
    {
        Text.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        string num = mudaContador.numBaloes.ToString();
        Text.text= num;
        Debug.Log(num);
    }
}
