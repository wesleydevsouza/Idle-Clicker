using UnityEngine;
using UnityEngine.UI;

public class UpgradeClick : MonoBehaviour
{
    void UpgradeProdClick()
    {
        if (GameController.gameController.gold >= GameController.gameController.qtdManualUpg)
        {
            GameController.gameController.gold -= GameController.gameController.qtdManualUpg;
            UpgradePrice();

        }

        {
            Debug.Log("Gold insuficiente");
            return;

        }
    }

    void UpgradePrice()
    {
        GameController.gameController.qtdManualUpg = GameController.gameController.qtdManualUpg * GameController.gameController.qtdManualUpg;
        GameController.gameController.qtdManualUpg++;
    }



    void Start()
    {
        GameController.gameController.qtdManualUpg = GameController.gameController.qtdManualUpg * GameController.gameController.qtdManualUpg;
        GameController.gameController.btnManualUpg.onClick.AddListener(UpgradeProdClick);
    }

    void Update()
    {
        GameController.gameController.txtManualUpg.text = "Upgrade Click " + GameController.gameController.qtdManualUpg + "$";
    }
}
