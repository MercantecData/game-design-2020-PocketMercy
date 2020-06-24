using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookAtMaus : MonoBehaviour
{
    public GameObject model;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var mousePos = Input.mousePosition;
        var mousePosWorld = Camera.main.ScreenToWorldPoint(mousePos);

        var crossHairPos = mousePosWorld - transform.position;

        crossHairPos.z = 0;

        //Set variables for model
        var staticPostition = transform.right;
        staticPostition.x = 0;
        staticPostition.y = 0;
        staticPostition.z = 0;

        transform.right = crossHairPos; //Turn player body
        model.transform.right = staticPostition; //Keep model rotation
    }
}
