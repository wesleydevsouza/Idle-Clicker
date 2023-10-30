using UnityEngine;
using UnityEngine.UI;

public class AutoClick : MonoBehaviour
{


    void AutoIncrement()
    {
        GameController.gameController.gold = GameController.gameController.gold + (GameController.gameController.prodAuto * GameController.gameController.qtdAutoUpgrade);

    }

    void EnableAuto()
    {
        if (GameController.gameController.isAuto == false) {
            //Buy Auto Prod
            if (GameController.gameController.gold >= GameController.gameController.priceAutoUpg) {
                GameController.gameController.gold -= GameController.gameController.priceAutoUpg;
                GameController.gameController.isAuto = true;
                InvokeRepeating("AutoIncrement", 1f, 1f);
                PriceUpgrade();

            } else {
                Debug.Log("Gold insuficiente");
                return;

            }

        } else {
            //Upgrade Auto
            if (GameController.gameController.gold >= GameController.gameController.priceAutoUpg) {
                GameController.gameController.gold -= GameController.gameController.priceAutoUpg;

                PriceUpgrade();

                GameController.gameController.txtAuto.text = "Upgrade Auto " + GameController.gameController.priceAutoUpg + "$";

            } else {
                Debug.Log("Gold insuficiente");
                return;

            }

        }

    }

    void PriceUpgrade()
    {
        GameController.gameController.qtdAutoUpgrade++;
        GameController.gameController.priceAutoUpg = GameController.gameController.priceAutoUpg * GameController.gameController.qtdAutoUpgrade;
        
    }
    
    void Start() {

        //Buy Auto
        GameController.gameController.btnAuto.onClick.AddListener(EnableAuto);

       
    }


    void Update()
    {
        GameController.gameController.txtAuto.text = "Upgrade Auto " + GameController.gameController.priceAutoUpg + "$";
    }

}
