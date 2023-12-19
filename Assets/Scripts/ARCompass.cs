using UnityEngine;
using System.Collections.Generic;
using TMPro;

public class ARCompass : MonoBehaviour
{
//    double directionLabelDegreeOffset = 3.5;
//    double directionLabelHeightBig = 2.25;
//    double directionLabelHeightMedium = 2;
//    float directionLabelSizeBig = 7f;
//    float directionLabelSizeMedium = 4f;
//
//    float headingLabelFontSize = 4.0f;
//    float headingLabelHeight = 1.0f;
//    float viewDirectionLabelHeight = -1.0f;
//
//    bool linesInitialized;
//
//    //Camera m_Camera;
//    GameObject vrCameraObject;
//    Camera vrCamera;
//
//    Color compassLineColor = Color.white;
//
//    Camera aerialCamera;
//
//    //Vectrosity:
//
//    GameObject theBoat;
//
//    GameObject headingIndicator;
//    Sprite headingIndicatorSprite;
//    GameObject headingIndicatorTextLabel;
//
//    GameObject viewDirectionIndicator;
//    Sprite viewDirectionIndicatorSprite;
//    GameObject viewDirectionIndicatorTextLabel;
//
//    //AR point feature marks
//    List<GameObject> pointFeatureMarks;
//    List<Vector3> pointFeaturePositions;
//    List<string> pointFeatureLabels;
//
//    public Sprite lobsterSprite;
//    public Sprite greenBuoySprite;
//    public Sprite redBuoySprite;
//    public Sprite greenLitBuoySprite;
//    public Sprite redLitBuoySprite;
//    public Sprite greenLightSprite;
//    public Sprite redLightSprite;
//
//    void OnEnable()
//    {
//        if (linesInitialized)
//        {
//            compassRingLine.active = true;
//            compassBigTicksLines.active = true;
//            compassMediumTicksLines.active = true;
//            compassSmallTicksLines.active = true;
//            viewDirectionDistanceLine.active = true;
//            leftTurnLimitLine.active = true;
//            rightTurnLimitLine.active = true;
//            headingLine.active = true;
//            viewDirectionToHorizonLine.active = true;
//
//            headingIndicatorTextLabel.SetActive(true);
//            viewDirectionIndicator.SetActive(true);
//            viewDirectionIndicatorTextLabel.SetActive(true);
//            viewDirectionDistanceLabel.SetActive(true);
//        }
//    }
//
//
//    void OnDisable()
//    {
//        if (linesInitialized)
//        {
//            compassRingLine.active = false;
//            compassBigTicksLines.active = false;
//            compassMediumTicksLines.active = false;
//            compassSmallTicksLines.active = false;
//            viewDirectionDistanceLine.active = false;
//            leftTurnLimitLine.active = false;
//            rightTurnLimitLine.active = false;
//            headingLine.active = false;
//            viewDirectionToHorizonLine.active = false;
//
//            headingIndicatorTextLabel.SetActive(false);
//            viewDirectionIndicator.SetActive(false);
//            viewDirectionIndicatorTextLabel.SetActive(false);
//            viewDirectionDistanceLabel.SetActive(false);
//
//        }
//    }
//    //to do: move more stuff here from start
//    private void Awake()
//    {
//        linesInitialized = false;
//
//        lobsterSprite = Resources.Load("textures/Lobster", typeof(Sprite)) as Sprite;
//        greenBuoySprite = Resources.Load("textures/GreenBuoy", typeof(Sprite)) as Sprite;
//        redBuoySprite = Resources.Load("textures/RedBuoy", typeof(Sprite)) as Sprite;
//        greenLitBuoySprite = Resources.Load("textures/GreenLitBuoy", typeof(Sprite)) as Sprite;
//        redLitBuoySprite = Resources.Load("textures/RedLitBuoy", typeof(Sprite)) as Sprite;
//        greenLightSprite = Resources.Load("textures/GreenLight", typeof(Sprite)) as Sprite;
//        redLightSprite = Resources.Load("textures/RedLight", typeof(Sprite)) as Sprite;
//    }
//
//    // Use this for initialization
//    void Start()
//    {
//
//        vrCameraObject = GameObject.Find("Camera(AR)");
//        vrCamera = vrCameraObject.GetComponent<Camera>();
//
//        aerialCamera = GameObject.Find("AerialCamera").GetComponent<Camera>();
//
//        theBoat = GameObject.Find("GulfSurveyor");
//
//        headingLineTexture = Resources.Load("textures/HeadingLineTextureBold2", typeof(Texture2D)) as Texture2D;
//        LimitLineTexture = Resources.Load("textures/DashedLimitLineTexture", typeof(Texture2D)) as Texture2D;
//        viewDirectionToHorizonLineTexture = Resources.Load("textures/ViewDirectionLineTexture", typeof(Texture2D)) as Texture2D;
//
//        //for drawing
//                
//
//        //add heading icon
//        headingIndicatorSprite = Resources.Load("textures/HeadingIndicator", typeof(Sprite)) as Sprite;
//        headingIndicator = new GameObject("Heading Indicator");
//        SpriteRenderer thisSprite = headingIndicator.AddComponent<SpriteRenderer>();
//        thisSprite.sprite = headingIndicatorSprite;
//        //set inital position somewhere on ring
//        Vector3 startingPos = new Vector3(transform.position.x + 20, transform.position.y, transform.position.z);
//        headingIndicator.layer = gameObject.layer;
//        headingIndicator.transform.position = startingPos;
//        headingIndicator.transform.rotation = Quaternion.LookRotation(startingPos - transform.position, new Vector3(0, 1, 0));
//        headingIndicator.transform.localScale = new Vector3(0.25f, 0.25f, 0.25f);
//        headingIndicator.transform.SetParent(transform);
//
//        //add heading icon text
//        headingIndicatorTextLabel = addMovableTextLabel("Heading", 0, headingLabelFontSize, headingLabelHeight);
//        headingIndicatorTextLabel.GetComponent<TextMeshPro>().color = Color.yellow;
//
//
//        //build heading line
//        headingLineNumSegs = 30;
//        headingLinePoints = new List<Vector3>(headingLineNumSegs + 1);
//        headingLine = new VectorLine("HeadingLine", headingLinePoints, headingLineTexture, 10.0f, LineType.Continuous, Joins.Fill);
//        float curvature = 100.0f;
//        //Vector3 startingCenter = new Vector3(curvature, 1.0f, curvature);
//        Vector3 startingCenter = new Vector3(-curvature, 0.25f, 0);
//        headingLine.textureScale = 1.0f;
//        headingLine.textureOffset = 0.0f;
//        headingLine.SetColor(Color.yellow);
//        headingLine.drawTransform = transform;
//        headingLine.layer = gameObject.layer;
//        headingLine.MakeArc(startingCenter, new Vector3(0.0f, 1.0f, 0.0f), curvature, curvature, 90.0f, 120.0f, headingLineNumSegs);
//        
//        //build right turn limit line
//        rightTurnLimitLineNumSegs = 30;
//        rightTurnLimitLinePoints = new List<Vector3>(rightTurnLimitLineNumSegs + 1);
//        rightTurnLimitLine = new VectorLine("RightTurnLimitLine", rightTurnLimitLinePoints, LimitLineTexture, 1.0f, LineType.Continuous, Joins.Weld);
//        float rightTurnLimitCurvature = 75.0f;
//        //Vector3 startingCenter = new Vector3(curvature, 1.0f, curvature);
//        Vector3 rightTurnStartingCenter = new Vector3(-rightTurnLimitCurvature, 0.25f, 0);
//        rightTurnLimitLine.textureScale = 1.0f;
//        rightTurnLimitLine.textureOffset = 0.0f;
//        rightTurnLimitLine.SetColor(Color.red);
//        rightTurnLimitLine.drawTransform = transform;
//        rightTurnLimitLine.layer = gameObject.layer;
//        rightTurnLimitLine.MakeArc(rightTurnStartingCenter, new Vector3(0.0f, 1.0f, 0.0f), rightTurnLimitCurvature, rightTurnLimitCurvature, 90.0f, 120.0f, rightTurnLimitLineNumSegs);
//
//        //build left turn limit line
//        leftTurnLimitLineNumSegs = 30;
//        leftTurnLimitLinePoints = new List<Vector3>(leftTurnLimitLineNumSegs + 1);
//        leftTurnLimitLine = new VectorLine("LeftTurnLimitLine", leftTurnLimitLinePoints, LimitLineTexture, 1.0f, LineType.Continuous, Joins.Weld);
//        float leftTurnLimitCurvature = 75.0f;
//        Vector3 leftTurnStartingCenter = new Vector3(leftTurnLimitCurvature, 0.25f, 0);
//        leftTurnLimitLine.textureScale = 1.0f;
//        leftTurnLimitLine.textureOffset = 0.0f;
//        leftTurnLimitLine.SetColor(Color.red);
//        leftTurnLimitLine.drawTransform = transform;
//        leftTurnLimitLine.layer = gameObject.layer;
//        leftTurnLimitLine.MakeArc(leftTurnStartingCenter, new Vector3(0.0f, 1.0f, 0.0f), leftTurnLimitCurvature, leftTurnLimitCurvature, 240.0f, 270.0f, leftTurnLimitLineNumSegs);
//
//        //build view direction to horizon line
//        viewDirectionToHorizonLineNumSegs = 10;
//        viewDirectionToHorizonLinePoints = new List<Vector3>(viewDirectionToHorizonLineNumSegs + 1);
//        viewDirectionToHorizonLine = new VectorLine("ViewDirectionHeadingLine", viewDirectionToHorizonLinePoints, viewDirectionToHorizonLineTexture, 0.5f, LineType.Continuous, Joins.None);
//        viewDirectionToHorizonLine.textureScale = 3.0f;
//        viewDirectionToHorizonLine.textureOffset = 0.0f;
//        viewDirectionToHorizonLine.SetColor(Color.blue);
//        viewDirectionToHorizonLine.drawTransform = transform;
//        viewDirectionToHorizonLine.layer = gameObject.layer;
//
//        //build view direction distance line
//        viewDirectionDistanceLineNumSegs = 2;
//        viewDirectionDistanceLinePoints = new List<Vector3>(viewDirectionDistanceLineNumSegs + 1);
//        viewDirectionDistanceLine = new VectorLine("ViewDirectionDistanceLine", viewDirectionDistanceLinePoints, 0.5f, LineType.Continuous, Joins.None);
//        viewDirectionDistanceLine.SetColor(Color.blue);
//        //viewDirectionDistanceLine.drawTransform = transform;
//        viewDirectionDistanceLine.layer = gameObject.layer;
//
//        //add distance label
//        GameObject labelPrefab = Resources.Load("ARTextLabel", typeof(GameObject)) as GameObject;
//        viewDirectionDistanceLabel = Instantiate(labelPrefab, new Vector3(0.0f, 0.0f, 0.0f), Quaternion.identity);
//        viewDirectionDistanceLabel.name = "ARCompassViewDirectionDistanceLabel";
//        viewDirectionDistanceLabel.layer = gameObject.layer;
//        TextMeshPro thisText = viewDirectionDistanceLabel.GetComponent<TextMeshPro>();
//        thisText.fontSize = 2.5f;
//        thisText.enableWordWrapping = false;
//        thisText.text = "---m";
//        thisText.color = new Color(0.25f, 0.25f, 1.0f);
//        thisText.alignment = TextAlignmentOptions.BottomLeft;
//        
//
//        //add view direction indicator
//        //viewDirectionIndicatorSprite = (Sprite)AssetDatabase.LoadAssetAtPath("Assets/GUI/ViewDirectionMarker.png", typeof(Sprite));
//        viewDirectionIndicatorSprite = Resources.Load("textures/ViewDirectionMarker", typeof(Sprite)) as Sprite;
//        if (viewDirectionIndicatorSprite == null)
//        {
//            Debug.Log("Error: file null or missing\n");
//        }
//        else
//        {
//            Debug.Log("Loaded texture OK\n");
//        }
//        viewDirectionIndicator = new GameObject("View Direction Indicator");
//        SpriteRenderer thisVDISprite = viewDirectionIndicator.AddComponent<SpriteRenderer>();
//        thisVDISprite.sprite = viewDirectionIndicatorSprite;
//        //set inital position somewhere on ring
//        Vector3 startingPosition = new Vector3(transform.position.x + 20, transform.position.y, transform.position.z);
//        viewDirectionIndicator.layer = gameObject.layer;
//        viewDirectionIndicator.transform.position = startingPosition;
//        viewDirectionIndicator.transform.rotation = Quaternion.LookRotation(startingPosition - transform.position, new Vector3(0, 1, 0));
//        viewDirectionIndicator.transform.localScale = new Vector3(0.30f, 0.30f, 0.30f);
//        viewDirectionIndicator.transform.SetParent(transform);
//
//        //add view direction icon text
//        viewDirectionIndicatorTextLabel = addMovableTextLabel("ViewDirection", 0, headingLabelFontSize, viewDirectionLabelHeight);
//        viewDirectionIndicatorTextLabel.GetComponent<TextMeshPro>().color = new Color(0.25f,0.25f,1.0f);
//
//        //add Point Feature AR Markers to Compass:
//        pointFeatureMarks = new List<GameObject>();
//        pointFeaturePositions = new List<Vector3>();
//        pointFeatureLabels = new List<string>();
//        int numPointFeatures = Assets.PointFeatureList.getNumPointFeatures();
//        Debug.Log("Num features: " + numPointFeatures);
//        for (int i=0;i<numPointFeatures;i++)
//        {
//            Debug.Log("Feature# " + i + " label is: " + Assets.PointFeatureList.getPointFeatureLabelAtIndex(i));
//            GameObject newPointFeatureMarker = new GameObject();
//            newPointFeatureMarker = addPointFeatureMarker(Assets.PointFeatureList.getPointFeatureLabelAtIndex(i),
//                                                                     Assets.PointFeatureList.getPointFeaturePositionAtIndex(i),
//                                                                     Assets.PointFeatureList.getPointFeatureTypeAtIndex(i));
//            pointFeatureMarks.Add(newPointFeatureMarker);
//            pointFeaturePositions.Add(Assets.PointFeatureList.getPointFeaturePositionAtIndex(i));
//            pointFeatureLabels.Add(Assets.PointFeatureList.getPointFeatureLabelAtIndex(i));
//        }
//
//        linesInitialized = true;
//
//    }//end start()
//
//    // Update is called once per frame
//    void Update () {
//
//
//        //update heading indicator
//        Vector3 eulerAngles = theBoat.transform.rotation.eulerAngles;
//        //Debug.Log("Angles are x: " + eulerAngles.x + "   y: " + eulerAngles.y + " z: " + eulerAngles.z);
//        float thisHeadingInDegreesRaw = eulerAngles.y; //these degrees are the correct nautical bearing degrees, i.e. North=0, East=90
//        float thisHeadingInDegrees = (360 - eulerAngles.y) + 90; //adjust for unity, not sure why have to flip it with the "360-", then adjust by 90
//
//        float thisRads = (float)thisHeadingInDegrees * 0.0174533f;
//        float thisX = Mathf.Cos(thisRads) * compassRadius;
//        float thisY = Mathf.Sin(thisRads) * compassRadius;
//        Vector3 thisNewLocation = new Vector3(transform.position.x + thisX, transform.position.y, transform.position.z + thisY);
//        headingIndicator.transform.position = thisNewLocation;
//        headingIndicator.transform.rotation = Quaternion.LookRotation(thisNewLocation - transform.position, new Vector3(0, 1, 0));
//
//        thisRads = ((float)thisHeadingInDegrees+1.1f) * 0.0174533f;  //+1.1 degree to center above marker
//        thisNewLocation.x = transform.position.x + Mathf.Cos(thisRads) * compassRadius;
//        thisNewLocation.z = transform.position.z + Mathf.Sin(thisRads) * compassRadius;
//        thisNewLocation.y = transform.position.y + 0.25f;
//        headingIndicatorTextLabel.transform.position = thisNewLocation;
//        headingIndicatorTextLabel.transform.rotation = Quaternion.LookRotation(thisNewLocation - transform.position, new Vector3(0, 1, 0));
//        headingIndicatorTextLabel.GetComponent<TextMeshPro>().text = ((int)thisHeadingInDegreesRaw).ToString() + "°";
//
//        //update view direction indicator
//        Vector3 viewEulerAngles = vrCamera.transform.rotation.eulerAngles;
//        //Debug.Log("Angles are x: " + eulerAngles.x + "   y: " + eulerAngles.y + " z: " + eulerAngles.z);
//        float thisViewDirectionInDegreesRaw = viewEulerAngles.y; //these degrees are the correct nautical bearing degrees, i.e. North=0, East=90
//        float thisViewDirectionInDegrees = (360 - viewEulerAngles.y) + 90; //adjust for unity, not sure why have to flip it with the "360-", then adjust by 90
//
//        thisRads = thisViewDirectionInDegrees * 0.0174533f;
//        thisX = Mathf.Cos(thisRads) * compassRadius;
//        thisY = Mathf.Sin(thisRads) * compassRadius;
//        thisNewLocation = new Vector3(transform.position.x + thisX, transform.position.y, transform.position.z + thisY);
//        viewDirectionIndicator.transform.position = thisNewLocation;
//        viewDirectionIndicator.transform.rotation = Quaternion.LookRotation(thisNewLocation - transform.position, new Vector3(0, 1, 0));
//
//        thisRads = (thisViewDirectionInDegrees + 1.1f) * 0.0174533f;  //+1.1 degree to center above marker
//        thisNewLocation.x = transform.position.x + Mathf.Cos(thisRads) * compassRadius;
//        thisNewLocation.z = transform.position.z + Mathf.Sin(thisRads) * compassRadius;
//        thisNewLocation.y = transform.position.y - 1.0f;
//        viewDirectionIndicatorTextLabel.transform.position = thisNewLocation;
//        viewDirectionIndicatorTextLabel.transform.rotation = Quaternion.LookRotation(thisNewLocation - transform.position, new Vector3(0, 1, 0));
//        viewDirectionIndicatorTextLabel.GetComponent<TextMeshPro>().text = ((int)thisViewDirectionInDegreesRaw).ToString() + "°";
//
//        //update view direction line
//        thisRads = thisViewDirectionInDegrees * 0.0174533f;
//        Vector3 aPoint = new Vector3(0.0f, 0.0f, 0.0f);// transform.position;
//        for (int i=0;i<=viewDirectionToHorizonLineNumSegs;i++)
//        {
//            viewDirectionToHorizonLinePoints[i] = aPoint;
//            aPoint.x = aPoint.x + Mathf.Cos(thisRads) * 10.0f;
//            aPoint.z = aPoint.z + Mathf.Sin(thisRads) * 10.0f;
//        }
//        aPoint.y = aPoint.y + 10.0f;
//        viewDirectionToHorizonLinePoints[viewDirectionToHorizonLineNumSegs] = aPoint;
//
//        //for (int i = 0; i < viewDirectionToHorizonLineNumSegs; i++)
//        //{
//        //    Debug.Log("ViewDirPoint " + i+ " is x: " + viewDirectionToHorizonLinePoints[i].x + "   y: " + viewDirectionToHorizonLinePoints[i].y + " z: " + viewDirectionToHorizonLinePoints[i].z);
//        //}
//
//        //update view direction distance line
//        Vector3 viewIntersection = transform.position;
//        Vector3 toRight = vrCamera.transform.right;
//        toRight.y = 0.0f;
//        toRight.Normalize();
//        Ray viewRay = new Ray(vrCamera.transform.position, vrCamera.transform.forward);
//        Plane seaLevelGroundPlane = new Plane(new Vector3(0.0f, 1.0f, 0.0f), new Vector3(0.0f, 0.0f, 0.0f));
//        float rayDistance;
//        if (seaLevelGroundPlane.Raycast(viewRay, out rayDistance))
//        {
//            viewIntersection = viewRay.GetPoint(rayDistance);
//            viewIntersection.y = 0.5f;
//        }
//        float lineSpread = Mathf.Tan(0.04f) * rayDistance;
//        viewDirectionDistanceLinePoints[0] = viewIntersection - (toRight * lineSpread * 0.25f);
//        viewDirectionDistanceLinePoints[1] = viewIntersection;
//        viewDirectionDistanceLinePoints[2] = viewIntersection + (toRight * lineSpread);
//
//        //Debug.Log("ViewDirLinePt 0 x: " + viewDirectionDistanceLinePoints[0].x + "   y: " + viewDirectionDistanceLinePoints[0].y + " z: " + viewDirectionDistanceLinePoints[0].z);
//        //Debug.Log("ViewDirLinePt 1 x: " + viewDirectionDistanceLinePoints[1].x + "   y: " + viewDirectionDistanceLinePoints[1].y + " z: " + viewDirectionDistanceLinePoints[1].z);
//        //Debug.Log("ViewDirLinePt 2 x: " + viewDirectionDistanceLinePoints[2].x + "   y: " + viewDirectionDistanceLinePoints[2].y + " z: " + viewDirectionDistanceLinePoints[2].z);
//
//        //update label
//        Vector3 labelPosition = viewDirectionDistanceLinePoints[2];
//        labelPosition.y = 0.5f;
//        viewDirectionDistanceLabel.transform.position = labelPosition;
//        viewDirectionDistanceLabel.transform.rotation = Quaternion.LookRotation(viewDirectionDistanceLabel.transform.position - transform.position);
//        TextMeshPro thisTMP = viewDirectionDistanceLabel.GetComponent<TextMeshPro>();
//        thisTMP.text = ((int)rayDistance).ToString() + "m";
//        thisTMP.fontSize = lineSpread * 5;
//
//
//
//        //update point feature blips
//        for (int i = 0; i < pointFeatureMarks.Count; i++)
//        {
//            Vector3 featurePosition = pointFeaturePositions[i];
//            Vector3 toRing;
//            toRing.x = featurePosition.x - transform.position.x;
//            toRing.y = 0.0f;
//            toRing.z = featurePosition.z - transform.position.z;
//            //Debug.Log("To Ring " + toRing.x + "   y: " + toRing.y + " z: " + toRing.z);
//            toRing.Normalize();
//
//            Vector3 positionOnRing;
//            positionOnRing.x = transform.position.x + toRing.x * compassRadius;
//            positionOnRing.y = transform.position.y;
//            positionOnRing.z = transform.position.z + toRing.z * compassRadius;
//
//            //Debug.Log("PosOnRing " + positionOnRing.x + "   y: " + positionOnRing.y + " z: " + positionOnRing.z + "\n");
//
//            Vector3 positionAboveRing = new Vector3(positionOnRing.x, positionOnRing.y + 0.5f, positionOnRing.z);
//
//            Quaternion blipDirection = Quaternion.LookRotation(toRing, new Vector3(0, 1, 0));
//            Vector3 blipEulerAngles = blipDirection.eulerAngles;
//            //Debug.Log("Blip " + i + " Angles are x: " + blipEulerAngles.x + "   y: " + blipEulerAngles.y + " z: " + blipEulerAngles.z + "\n");
//            float blipDirectionInDegreesRaw = blipEulerAngles.y; //these degrees are the correct nautical bearing degrees, i.e. North=0, East=90
//            float blipDirectionInDegrees = (360 - blipEulerAngles.y) + 90; //adjust for unity, not sure why have to flip it with the "360-", then adjust by 90
//
//            //Debug.Log("Blip " + i + " degrees is : " + blipDirectionInDegreesRaw + "\n");
//
//            //check if within 10 degrees of view direction
//            float degreesFromViewingDirection = Mathf.Abs(Mathf.DeltaAngle(blipDirectionInDegreesRaw, thisViewDirectionInDegreesRaw));
//            bool lookingAtThisBlip = false;
//            if (degreesFromViewingDirection < 5.0f)
//                lookingAtThisBlip = true;
//
//            thisRads = (float)blipDirectionInDegrees * 0.0174533f;
//            thisX = Mathf.Cos(thisRads) * compassRadius;
//            thisY = Mathf.Sin(thisRads) * compassRadius;
//            thisNewLocation = new Vector3(transform.position.x + thisX, transform.position.y, transform.position.z + thisY);
//            pointFeatureMarks[i].transform.GetChild(1).transform.position = thisNewLocation;
//            pointFeatureMarks[i].transform.GetChild(1).transform.rotation = Quaternion.LookRotation(thisNewLocation - transform.position, new Vector3(0, 1, 0));
//
//            thisRads = ((float)blipDirectionInDegrees + 1.1f) * 0.0174533f;  //+1.1 degree to center above marker
//            thisNewLocation.x = transform.position.x + Mathf.Cos(thisRads) * compassRadius;
//            thisNewLocation.z = transform.position.z + Mathf.Sin(thisRads) * compassRadius;
//            thisNewLocation.y = transform.position.y + 0.5f;
//            pointFeatureMarks[i].transform.GetChild(0).transform.position = thisNewLocation;
//            pointFeatureMarks[i].transform.GetChild(0).transform.rotation = Quaternion.LookRotation(thisNewLocation - transform.position, new Vector3(0, 1, 0));
//            if (lookingAtThisBlip)
//            {
//                //find distance
//                int distanceToPointFeature = (int)Vector3.Distance(featurePosition, transform.position);
//
//                pointFeatureMarks[i].transform.GetChild(0).GetComponent<TextMeshPro>().text = Assets.PointFeatureList.getPointFeatureLabelAtIndex(i) + "\n" + distanceToPointFeature.ToString() + "m  " +((int)blipDirectionInDegreesRaw).ToString() + "°";
//                pointFeatureMarks[i].transform.GetChild(0).GetComponent<TextMeshPro>().fontSize = 4.0f;
//            }
//            else
//            {
//                pointFeatureMarks[i].transform.GetChild(0).GetComponent<TextMeshPro>().text = "";
//                pointFeatureMarks[i].transform.GetChild(0).GetComponent<TextMeshPro>().fontSize = 2.5f;
//            }
//        }//end for i point features
//
//    }//end update()
//
//    private void LateUpdate()
//    {
//        //Recalculate all trajectory lines
//        Vector3 boatsVelocity = theBoat.GetComponent<Rigidbody>().velocity;
//        Vector3 boatsAngularVelocity = theBoat.GetComponent<Rigidbody>().angularVelocity;
//        float speed = Mathf.Sqrt((boatsVelocity.x * boatsVelocity.x) + (boatsVelocity.z * boatsVelocity.z));
//        //Debug.Log("Raw speed is " + speed);
//        float maxSpeed = 1.5f;
//        if (speed > maxSpeed)
//            speed = maxSpeed;
//        if (speed < 0.0f)
//            speed = 0.0f;
//        
//        float turnSpeed = boatsAngularVelocity.y;
//                
//        float speedFactor = (speed / maxSpeed); //0 (slowest) to 1 (fastest)
//        
//        Vector3 eulerAngles = theBoat.transform.rotation.eulerAngles;
//        Vector3 direction = new Vector3(Mathf.Sin(eulerAngles.y * 0.0174533f), 0.0f, Mathf.Cos(-eulerAngles.y * 0.0174533f));
//        Vector3 aPoint = new Vector3(0.0f, 0.0f, 0.0f);
//        //convert angular velocity to a turning angle
//        float turningAngle = boatsAngularVelocity.y * -15.0f; //-7.5f;
//        //Debug.Log("Angular Velocty is " + boatsAngularVelocity.y + "  Turning Angle is  " + turningAngle);
//        float cosA = Mathf.Cos(turningAngle * 0.0174533f);
//        float sinA = Mathf.Sin(turningAngle * 0.0174533f);
//        for (int i = 0; i <= headingLineNumSegs; i++)
//        {
//            headingLinePoints[i] = aPoint;
//            direction.x = direction.x * cosA - direction.z * sinA;
//            direction.z = direction.x * sinA + direction.z * cosA;
//            direction.Normalize();
//            aPoint.x += direction.x * (2.0f + 3.0f *  speedFactor);
//            aPoint.z += direction.z * (2.0f + 3.0f * speedFactor);//5.0f;
//        }
//
//        //calculate max turn lines
//        float maxTurnAngle;
//        //if (speed < 0.02f)
//        //    maxTurnAngle = 20;
//        //else
//        //    maxTurnAngle = 2.0f + 5.0f * speedFactor;
//
//        maxTurnAngle = 20.0f - (19.0f * speedFactor);
//
//        cosA = Mathf.Cos(maxTurnAngle * 0.0174533f);
//        sinA = Mathf.Sin(maxTurnAngle * 0.0174533f);
//        aPoint = new Vector3(0.0f, 0.0f, 0.0f);
//        direction = new Vector3(Mathf.Sin(eulerAngles.y * 0.0174533f), 0.0f, Mathf.Cos(-eulerAngles.y * 0.0174533f));
//        float accumulatedAngle = 0;
//        for (int i = 0; i <= rightTurnLimitLineNumSegs; i++)
//        {
//            rightTurnLimitLinePoints[i] = aPoint;
//            if (accumulatedAngle < 320) //don't wrap around in a full circle
//            {
//                direction.x = direction.x * cosA - direction.z * sinA;
//                direction.z = direction.x * sinA + direction.z * cosA;
//                direction.Normalize();
//                aPoint.x += direction.x * 5;
//                aPoint.z += direction.z * 5;
//                accumulatedAngle += maxTurnAngle;
//            }
//        }
//        cosA = Mathf.Cos(-maxTurnAngle * 0.0174533f);
//        sinA = Mathf.Sin(-maxTurnAngle * 0.0174533f);
//        aPoint = new Vector3(0.0f, 0.0f, 0.0f);
//        direction = new Vector3(Mathf.Sin(eulerAngles.y * 0.0174533f), 0.0f, Mathf.Cos(-eulerAngles.y * 0.0174533f));
//        accumulatedAngle = 0;
//        for (int i = 0; i <= leftTurnLimitLineNumSegs; i++)
//        {
//            leftTurnLimitLinePoints[i] = aPoint;
//            if (accumulatedAngle < 320)
//            {
//                direction.x = direction.x * cosA - direction.z * sinA;
//                direction.z = direction.x * sinA + direction.z * cosA;
//                direction.Normalize();
//                aPoint.x += direction.x * 5;
//                aPoint.z += direction.z * 5;
//                accumulatedAngle += maxTurnAngle;
//            }
//        }
//        
//
//
//        //we need to call draw3d here each frame after the main update is finished
//        //the draw3d doesn't actually draw the item, it will draw regardless, instead it seems to "rebuild" the mesh for the position/orientation
//        //so if you put these draw3d calls up in start() you will still see the lines, but they will not move with the boat
//        VectorLine.SetCamera3D(vrCamera);
//        compassRingLine.Draw3D();
//        compassBigTicksLines.Draw3D();
//        compassMediumTicksLines.Draw3D();
//        compassSmallTicksLines.Draw3D();
//        viewDirectionDistanceLine.Draw3D();
//        
//
//
//        //draw heading lines from the aerialCamera's point of view, so they appear flat on the water.
//        VectorLine.SetCamera3D(aerialCamera);
//        leftTurnLimitLine.Draw3D();
//        rightTurnLimitLine.Draw3D();
//        headingLine.Draw3D();
//        viewDirectionToHorizonLine.Draw3D();
//        //testNavLine.Draw3D();
//
//
//    }
//
//    GameObject AddMovableTextLabel(string label, double degrees, float fontSize, double height)
//    {
//        float thisRads = (float)degrees * 0.0174533f;
//        float thisX = Mathf.Cos(thisRads) * compassRadius;
//        float thisY = Mathf.Sin(thisRads) * compassRadius;
//        Vector3 thisLocation = new Vector3(transform.position.x + thisX, (float)height, transform.position.z + thisY);
//
//        GameObject thisPrefab = Resources.Load("ARTextLabel", typeof(GameObject)) as GameObject;
//        GameObject thisGameObject = Instantiate(thisPrefab, thisLocation, Quaternion.LookRotation(thisLocation - transform.position, new Vector3(0, 1, 0)));
//        thisGameObject.name = "ARCompassMovableTextLabel:" + label;
//
//        thisGameObject.transform.SetParent(transform);
//        thisGameObject.layer = gameObject.layer;
//        TextMeshPro thisText = thisGameObject.GetComponentInChildren<TextMeshPro>();
//        thisText.fontSize = fontSize;
//        thisText.text = label;
//
//        return thisGameObject;
//    }
//
//    void MoveTextLabel(GameObject objectToMove, double degrees)
//    {
//        float thisRads = (float)degrees * 0.0174533f;
//        float thisX = Mathf.Cos(thisRads) * compassRadius;
//        float thisY = Mathf.Sin(thisRads) * compassRadius;
//        Vector3 thisLocation = new(transform.position.x + thisX, objectToMove.transform.position.y, transform.position.z + thisY);
//        objectToMove.transform.position = thisLocation;
//        objectToMove.transform.rotation = Quaternion.LookRotation(thisLocation - transform.position, new Vector3(0, 1, 0));
//    }
//
//    GameObject AddPointFeatureMarker(string label, Vector3 position, int type)
//    {
//        GameObject thisGameObject = new("PointFeatureCompassMarker:" + label);
//        thisGameObject.transform.SetParent(transform, false);
//        thisGameObject.layer = gameObject.layer;
//
//        // Debug.Log("Pos " + position.x + "," + position.y + "," + position.z + " Compass" + transform.position.x + "," + transform.position.y+ "," + transform.position.z + " \n");
//
//        Vector3 toRing;
//        toRing.x = position.x - transform.position.x;
//        toRing.y = 0;
//        toRing.z = position.z - transform.position.z;
//        toRing.Normalize();
//        Vector3 positionOnRing;
//        positionOnRing.x = toRing.x * compassRadius;
//        positionOnRing.y = 0;
//        positionOnRing.z = toRing.z * compassRadius;
//
//        Vector3 positionAboveRing = new Vector3(positionOnRing.x, positionOnRing.y + 0.5f, positionOnRing.z);
//
//        //make text label object
//        GameObject thisPrefab = Resources.Load("ARTextLabel", typeof(GameObject)) as GameObject;
//        GameObject thisTextGameObject = Instantiate(thisPrefab, positionAboveRing, Quaternion.LookRotation(positionOnRing, new Vector3(0, 1, 0)));
//        thisTextGameObject.name = "ARCompassPointFeatureMovableTextLabel:" + label;
//        TextMeshPro thisText = thisTextGameObject.GetComponentInChildren<TextMeshPro>();
//        thisText.fontSize = 2.5f;
//        thisText.enableWordWrapping = false;
//        thisText.text = label;
//        thisTextGameObject.layer = gameObject.layer;
//        //attach text label to main point feature marker object
//        thisTextGameObject.transform.SetParent(thisGameObject.transform, false);
//
//        //make sprite object
//        GameObject ARMArkPrefab = Resources.Load("ARCompassPointFeatureIconPrefab", typeof(GameObject)) as GameObject;
//        GameObject thisMark = Instantiate(ARMArkPrefab, positionOnRing, Quaternion.LookRotation(positionOnRing, new Vector3(0, 1, 0)));
//        SpriteRenderer thisSprite = thisMark.GetComponentInChildren<SpriteRenderer>();
//        if (type == 0)
//            thisSprite.sprite = greenBuoySprite;
//        if (type == 1)
//            thisSprite.sprite = greenLitBuoySprite;
//        if (type == 2)
//            thisSprite.sprite = redBuoySprite;
//        if (type == 3)
//            thisSprite.sprite = redLitBuoySprite;
//        if (type == 4)
//            thisSprite.sprite = greenLightSprite;
//        if (type == 5)
//            thisSprite.sprite = redLightSprite;
//        if (type == 99)
//            thisSprite.sprite = lobsterSprite;
//        thisSprite.transform.localScale = new Vector3(0.25f, 0.25f, 0.25f);
//        thisMark.transform.SetParent(thisGameObject.transform, false);
//        thisMark.layer = gameObject.layer;
//
//        return thisGameObject;
//    }
}
