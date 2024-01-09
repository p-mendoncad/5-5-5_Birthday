using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;


public class mostraResultado : MonoBehaviour
{
    public Text placarBaloes;

    string baloes = mudaContador.numBaloes.ToString();
    // Start is called before the first frame update
    void Start()
    {
       placarBaloes.text += baloes;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
