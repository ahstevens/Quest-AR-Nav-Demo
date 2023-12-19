using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewDirectionLine : MonoBehaviour
{
    LineRenderer viewDirectionToHorizonLine;
    int viewDirectionToHorizonLineNumSegs;
    Texture2D viewDirectionToHorizonLineTexture;
    List<Vector3> viewDirectionToHorizonLinePoints;

    LineRenderer viewDirectionDistanceLine;
    int viewDirectionDistanceLineNumSegs;
    List<Vector3> viewDirectionDistanceLinePoints;

    GameObject viewDirectionDistanceLabel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
