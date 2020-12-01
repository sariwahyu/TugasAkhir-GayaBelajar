using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PolygonField : MonoBehaviour
{
    public GameObject[] goRaw;
    public Text[] goTextAngle;
    public Text[] goTextDsitance;
    public Text perimeterText;
    public Text areaText;
    public Text typeText;

    private Vector2[] goPoints;
    private Text[] goPointsTextA;
    private Text[] goPointsTextD;
    private GameObject[] go_n;

    private LineRenderer lineRenderer;
    private MeshFilter filter;

    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = gameObject.GetComponent<LineRenderer>();
        filter = gameObject.GetComponent<MeshFilter>();
    }

    // Update is called once per frame
    void Update()
    {
        getAllAvailablePoints();
        draw();
        drawLines();
        calculation();
    }

    //distance between two points (pythagoras)
    private float distance(float x1, float y1, float x2, float y2)
    {
        float a = Mathf.Abs(x1 - x2);
        float b = Mathf.Abs(y1 - y2);
        float c = Mathf.Sqrt(a * a + b * b);

        return c;
    }

    //angle between two lines(three points) anticlockwise
    private float angle(float i1, float i2, float i3, float p1x, float p1y, float p2x, float p2y, float p3x, float p3y)
    {
        float k = ((i2 * i2) + (i1 * i1) - (i3 * i3)) / (2 * i1 * i2);
        float d = Mathf.Acos(k) * (180 / Mathf.PI);

        float dd = direction(p1x, p1y, p2x, p2y, p3x, p3y);

        if (dd > 0)
        {
            d = 360 - d;
        }

        return d;
    }

    private float direction(float x1, float y1, float x2, float y2, float x3, float y3)
    {
        float d = ((x2 - x1) * (y3 - y1)) - ((y2 - y1) * (x3 - x1));
        return d;
    }

    //middle point between two points
    private Vector2 midPoint(float x1, float y1, float x2, float y2)
    {
        float x = (x1 + x2) / 2;
        float y = (y1 + y2) / 2;
        return new Vector2(x, y);
    }

    //zero way angle between two points
    private float angleZero(float x1, float y1, float x2, float y2)
    {
        float xDiff = x2 - x1;
        float yDiff = y2 - y1;
        float d = Mathf.Atan2(yDiff, xDiff) * (180 / Mathf.PI);

        return d;
    }

    // Write shape type name 
    private string shapeType(int points)
    {
        string r = "None";

        switch (points)
        {
            case 1:
                r = "Titik";
                break;
            case 2:
                r = "Garis";
                break;
            case 3:
                r = "Segitiga";
                break;
            case 4:
                r = "Segiempat";
                break;
            case 5:
                r = "Segilima";
                break;
        }

        return r;
    }

    private void getAllAvailablePoints()
    {
        // create new vector2 and text lists
        List<Vector2> vertices2DList = new List<Vector2>();
        List<Text> textAList = new List<Text>();
        List<Text> textDList = new List<Text>();
        List<GameObject> oList = new List<GameObject>();

        // fill lists if available
        for (int i = 0; i < goRaw.Length; i++)
        {
            if (goRaw[i] != null)
            {
                if(goRaw[i].GetComponent<MeshRenderer>().enabled)
                {
                    goTextAngle[i].enabled = true;
                    goTextDsitance[i].enabled = true;

                    vertices2DList.Add(new Vector2(goRaw[i].transform.position.x, goRaw[i].transform.position.y));
                    textAList.Add(goTextAngle[i]);
                    textDList.Add(goTextDsitance[i]);
                    oList.Add(goRaw[i]);
                }
                else
                {
                    goTextAngle[i].enabled = false;
                    goTextDsitance[i].enabled = false;
                }
            }
        }

        // convert to array
        goPointsTextA = textAList.ToArray();
        goPointsTextD = textDList.ToArray();
        goPoints = vertices2DList.ToArray();
        go_n = oList.ToArray();

    }

    private void draw()
    {
        // create vector2 vertice
        Vector2[] vertice2D = goPoints;

        // use the triangulator to get indices for creating triangles
        Triangulator tr = new Triangulator(vertice2D);
        int[] indices = tr.Triangulate();

        // create the vector3 vertices
        Vector3[] vertices = new Vector3[vertice2D.Length];
        for(int i = 0; i < vertices.Length; i++)
        {
            vertices[i] = new Vector3(go_n[i].transform.position.x, go_n[i].transform.position.y, go_n[i].transform.position.z);
        }

        // create the mesh
        Mesh msh = new Mesh();
        msh.vertices = vertices;
        msh.triangles = indices;
        msh.RecalculateNormals();
        msh.RecalculateBounds();

        // set up game object with mesh
        filter.mesh = msh;

    }

    private void drawLines()
    {
        // set positions size
        lineRenderer.positionCount = goPoints.Length;

        // set all line postitions
        for(int i = 0; i < goPoints.Length; i++)
        {
            lineRenderer.SetPosition(i, new Vector3(go_n[i].transform.position.x, go_n[i].transform.position.y, go_n[i].transform.position.z));
        }
    }

    private void calculation()
    {
        //perimeter varible
        float p = 0;
        //area varible
        float area = 0;
        //type varible 
        int n = 0;

        //loop all points
        for(int i = 0; i < goPoints.Length; i++)
        {
            //for test neighbors 
            //int x0, x1, x2

            //point before
            Vector2 v0;
            if ((i-1) >= 0)
            {
                v0 = goPoints[i - 1];  //x0 = i - 1;
            }
            else
            {
                v0 = goPoints[goPoints.Length - 1]; //x0 = goPoints.Lenght - 1;
            }

            //point now
            Vector2 v1 = goPoints[i]; //x1 = i;

            //point after
            Vector2 v2;
            if ((i + 1) < goPoints.Length)
            {
                v2 = goPoints[i + 1]; //x2 = i + 1;
            }
            else
            {
                v2 = goPoints[0]; //x2 = 0;
            }

            //triangular distances
            float dv0 = distance(v0.x, v0.y, v1.x, v1.y); //v0 & v1
            float dv1 = distance(v1.x, v1.y, v2.x, v2.y); //v1 & v2
            float dv2 = distance(v0.x, v0.y, v2.x, v2.y); //v0 & v2

            //perimeter
            p += dv1;

            //area
            float temp_area = (v1.x * v2.y) - (v1.y * v2.x);
            area += temp_area;

            //type
            n++;

            //angle//
            //set point angle ∠v0v1v2
            float a = angle(dv0, dv1, dv2, v0.x, v0.y, v1.x, v1.y, v2.x, v2.y);
            goPointsTextA[i].text = Mathf.Round(a) + "°";
            //text neighbors
            //goPointsTextA[i].text = 1 + "#" + x0 + " " + x1 + " " + x2;

            //distance
            //set distance postition
            Vector2 mp = midPoint(v1.x, v1.y, v2.x, v2.y);
            goPointsTextD[i].transform.parent.position = new Vector3(mp.x, mp.y, goPointsTextD[i].transform.parent.position.z);

            //set distance angle 
            float az = angleZero(v1.x, v1.y, v2.x, v2.y);
            goPointsTextD[i].transform.parent.eulerAngles = new Vector3(goPointsTextD[i].transform.parent.eulerAngles.x, goPointsTextD[i].transform.parent.eulerAngles.y, (float)az);

            //set "point" and "pont after" distance
            goPointsTextD[i].text = System.Math.Round(dv1, 2) + "";
        }

        //set perimeter 
        perimeterText.text = "Perimeter : " + System.Math.Round(p, 2);

        //set area
        areaText.text = "Area: " + System.Math.Round(Mathf.Abs(area / 2), 2);

        //set type
        typeText.text = "Type: " + shapeType(n);
    }
}
