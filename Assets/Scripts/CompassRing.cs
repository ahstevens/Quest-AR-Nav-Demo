using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompassRing : MonoBehaviour
{
    [SerializeField] Material compassLineMaterial;

    [SerializeField] float compassHeight = 1.5f;
    [SerializeField] float compassRadius = 20;
    [SerializeField] float compassElevation = 0.5f;

    Vector3[] compassRingPoints;
    List<Vector3> bigTickPoints;
    List<Vector3> mediumTickPoints;
    List<Vector3> smallTickPoints;

    GameObject compassRingLine;
    LineRenderer compassBigTicksLines;
    LineRenderer compassMediumTicksLines;
    LineRenderer compassSmallTicksLines;

    // Start is called before the first frame update
    void Start()
    {
        compassRingPoints = new Vector3[360];
        bigTickPoints = new List<Vector3>();
        mediumTickPoints = new List<Vector3>();
        smallTickPoints = new List<Vector3>();

        //float halfHeight = compassHeight / 2;
        //float bigHalfHeight = halfHeight;
        //float mediumHalfHeight = halfHeight * 0.75f;
        //float littleHalfHeight = halfHeight * 0.33f;

        for (int i = 0; i < 360; i++)
        {
            float thisRads = (float)i * 0.0174533f;
            float thisX = Mathf.Cos(thisRads) * compassRadius;
            float thisY = Mathf.Sin(thisRads) * compassRadius;

            compassRingPoints[i] = new(thisX, 0, thisY);

            //if (i % 90 == 0)
            //{
            //
            //    bigTickPoints.Add(new Vector3(thisX, -bigHalfHeight, thisY));
            //    bigTickPoints.Add(new Vector3(thisX, bigHalfHeight, thisY));
            //
            //
            //}
            //else if (i % 45 == 0)
            //{
            //    mediumTickPoints.Add(new Vector3(thisX, -mediumHalfHeight, thisY));
            //    mediumTickPoints.Add(new Vector3(thisX, mediumHalfHeight, thisY));
            //
            //
            //}
            //else if (i % 5 == 0)
            //{
            //    smallTickPoints.Add(new Vector3(thisX, -littleHalfHeight, thisY));
            //    smallTickPoints.Add(new Vector3(thisX, littleHalfHeight, thisY));
            //
            //}

        }//end for i 0-359

        // Make the GameObject as a child and center it on the parent
        compassRingLine = new GameObject("CompassRing");
        compassRingLine.transform.parent = this.transform;
        compassRingLine.transform.SetLocalPositionAndRotation(Vector3.zero, Quaternion.identity);

        // Add and configure the line renderer
        var crlLR = compassRingLine.AddComponent<LineRenderer>();

        crlLR.loop = true;
        crlLR.useWorldSpace = false; // center ring on parent

        crlLR.positionCount = 360;
        crlLR.SetPositions(compassRingPoints);

        if (compassLineMaterial != null)
            crlLR.material = compassLineMaterial;


        //compassRingLine = new VectorLine("CompassRing", compassRingPoints, 2.0f, LineType.Continuous);
        //compassBigTicksLines = new VectorLine("CompassBigTicks", bigTickPoints, 2.0f, LineType.Discrete);
        //compassMediumTicksLines = new VectorLine("CompassMediumTicks", mediumTickPoints, 2.0f, LineType.Discrete);
        //compassSmallTicksLines = new VectorLine("CompassSmallTicks", smallTickPoints, 2.0f, LineType.Discrete);



        //This can be done here instead of every update as it does not COPY the transform to the drawTransform, but instead passes a reference/pointer, i.e. if you move the boat later, the lines will move with it
        //All attempts to set a parent failed and introduced weird rotation/dimension swapping and z-buffer precision issues.
        //compassRingLine.drawTransform = transform;
        //compassBigTicksLines.drawTransform = transform;
        //compassMediumTicksLines.drawTransform = transform;
        //compassSmallTicksLines.drawTransform = transform;

        //set lines' layer to AROverlay
        //compassRingLine.layer = gameObject.layer;
        //compassBigTicksLines.layer = gameObject.layer;
        //compassMediumTicksLines.layer = gameObject.layer;
        //compassSmallTicksLines.layer = gameObject.layer;

        //set line widths

        //why need the extra 3 degrees? figure out later
        //addFixedTextLabel("S", 90 + directionLabelDegreeOffset, directionLabelSizeBig, directionLabelHeightBig);
        //addFixedTextLabel("W", 0 + directionLabelDegreeOffset, directionLabelSizeBig, directionLabelHeightBig);
        //addFixedTextLabel("N", 270 + directionLabelDegreeOffset, directionLabelSizeBig, directionLabelHeightBig);
        //addFixedTextLabel("E", 180 + directionLabelDegreeOffset, directionLabelSizeBig, directionLabelHeightBig);
        //
        //addFixedTextLabel("SW", 45 + directionLabelDegreeOffset, directionLabelSizeMedium, directionLabelHeightMedium);
        //addFixedTextLabel("NW", 315 + directionLabelDegreeOffset, directionLabelSizeMedium, directionLabelHeightMedium);
        //addFixedTextLabel("NE", 225 + directionLabelDegreeOffset, directionLabelSizeMedium, directionLabelHeightMedium);
        //addFixedTextLabel("SE", 135 + directionLabelDegreeOffset, directionLabelSizeMedium, directionLabelHeightMedium);
    }

    // Update is called once per frame
    void Update()
    {
        //move compass ring to be around user
        //transform.SetPositionAndRotation(new Vector3(transform.position.x, compassElevation, transform.position.z), Quaternion.identity);
    }

    public void AddFixedTextLabel(string label, double degrees, float fontSize, double height)
    {
        float thisRads = (float)degrees * 0.0174533f;
        float thisX = Mathf.Cos(thisRads) * compassRadius;
        float thisY = Mathf.Sin(thisRads) * compassRadius;
        Vector3 thisLocation = new Vector3(transform.position.x + thisX, (float)height, transform.position.z + thisY);

        GameObject thisPrefab = Resources.Load("ARTextLabel", typeof(GameObject)) as GameObject;
        GameObject thisMark = Instantiate(thisPrefab, thisLocation, Quaternion.LookRotation(thisLocation - transform.position, new Vector3(0, 1, 0)));
        thisMark.name = "ARCompassFixedTextLabel:" + label;

        thisMark.transform.SetParent(transform);
        thisMark.layer = gameObject.layer;
        //TextMeshPro thisText = thisMark.GetComponentInChildren<TextMeshPro>();
        //thisText.fontSize = fontSize;
        //thisText.text = label;
    }
}
