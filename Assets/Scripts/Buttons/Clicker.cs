using UnityEngine;
using UnityEngine.UI;

public class Clicker : MonoBehaviour
{
    public static Clicker InstClicker;

    /// <summary>
    /// TODO Editar as variaveis no botão de clic, gold 0, prdo e mult = 
    /// </summary>

    [Header("Var Controle")]
    public int gold, production, multClick;

    public Button button;
    public Text Result;

    void ManualIncrement()
    {
        if (gold <= 0) {
            gold = production;
        }
        else {
            
            gold = gold + (production * multClick);
        }
        
        Debug.Log(gold);
    }

    void TextUpdate()
    {
        Result.text = gold.ToString();
    }

    private void Awake()
    {
        InstClicker = this;
    }

    void Start()
    {
        button.onClick.AddListener(ManualIncrement);


    }

    // Update is called once per frame
    void Update()
    {
        TextUpdate();
    }
}
