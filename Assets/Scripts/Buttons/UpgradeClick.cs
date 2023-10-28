using UnityEngine;
using UnityEngine.UI;

public class UpgradeClick : MonoBehaviour
{

    public Button btnUpClick;
    public Text txtClick;
    public int qtdUpgrade;
    int priceUpgrade;

    void UpgradeProdClick() {
        if (Clicker.InstClicker.gold >= priceUpgrade) {
            Clicker.InstClicker.gold -= priceUpgrade;
            UpgradePrice(); 
             
        }

        {
            Debug.Log("Gold insuficiente");
            return;

        }
    }

    void UpgradePrice() {
        priceUpgrade = qtdUpgrade * priceUpgrade;
        qtdUpgrade++;
    } 


    
    void Start()
    {
        priceUpgrade = qtdUpgrade * priceUpgrade;
        btnUpClick.onClick.AddListener(UpgradeProdClick);
    }

    // Update is called once per frame
    void Update()
    {
        txtClick.text = "Upgrade Click " + priceUpgrade + "$";
    }
}
