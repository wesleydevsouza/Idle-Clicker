using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public static GameController gameController;

    [Header("Auto Controller")]
    public int prodAuto;
    public int qtdAutoUpgrade;
    public int priceAutoUpg;
    public bool isAuto;


    [Header("Manual Controller")]
    public int prodManual; 
    public int qtdManualUpg; 
    public int priceManualUpg;


    [Header("UI Controller")]
    public Button btnClick;
    public Button btnAuto;
    public Button btnManualUpg;
    public Text txtManualUpg;
    public Text txtAuto;
    public Text Result;

    [Header("Global Controller")]
    public int gold;

    private void Awake()
    {
        gameController = this;
    }

    void Start()
    {

    }

    void Update()
    {

    }
}
