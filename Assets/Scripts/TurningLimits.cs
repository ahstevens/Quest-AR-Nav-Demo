using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TurningLimits : MonoBehaviour
{
    Texture2D LimitLineTexture;
    List<Vector3> leftTurnLimitLinePoints;
    LineRenderer leftTurnLimitLine;
    int leftTurnLimitLineNumSegs;
    List<Vector3> rightTurnLimitLinePoints;
    LineRenderer rightTurnLimitLine;
    Texture2D rightTurnLimitLineTexture;
    int rightTurnLimitLineNumSegs;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
