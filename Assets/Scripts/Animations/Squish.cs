using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Squish : MonoBehaviour
{
    private Button btn;
    private Animator anim;

    private void Awake() {
       
        btn = GetComponent<Button>();
        anim = GetComponent<Animator>();
        anim.ResetTrigger("Squish"); 
    }

    private void TriggerSquish() {
        anim.SetTrigger("Squish");

    }

    void Start()
    {

        btn.onClick.AddListener(TriggerSquish);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
