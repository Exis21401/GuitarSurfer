using System.Collections; // Librería de funcionalidades de Unity
using System.Collections.Generic; // Librería de funcionalidades de Unity
using UnityEngine; //Usando el motor de Unity
using TMPro; //Usar el TextMesh Pro

public class Test : MonoBehaviour
{
    public float velocity; public bool canRun; public string playerName; public int currentLevel; int numerador; int denominador;

    // Lo primero que se ejecuta
    private void Awake() { 
        
    }

    // Start is called before the first frame update
    void Start() { 
        canRun = false; velocity = 20f; playerName = "Alexis"; numerador = 4; denominador = 2;

        Debug.Log("Numerador: " + numerador);
        Debug.Log("Denominador: " + denominador);

        if(denominador != 0 && numerador >= denominador){
            Debug.Log("Resultado: " + numerador / denominador);
        }
    }

    // Update is called once per frame
    void Update(){
        
    }

    private void LateUpdate(){
        
    }
}
