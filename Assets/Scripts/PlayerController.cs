using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private GameObject ObjectText;
    private Text obj;
    public GameObject ui;
    private bool ray = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            RaycastHit hitInfo;
            Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(myRay, out hitInfo, 2))
            {
                if (ui && hitInfo.collider.gameObject.tag != "Untagged")
                {
                    ui.SetActive(true);
                    ObjectText = GameObject.FindWithTag("Text");
                    obj = ObjectText.GetComponent<Text>();
                    obj.text = hitInfo.collider.gameObject.tag;
                }
                
            
            }
            else
            {
                ui.SetActive(false);
            }
    }
}
