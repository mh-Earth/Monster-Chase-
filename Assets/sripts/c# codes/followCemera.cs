using UnityEngine;

public class followCemera : MonoBehaviour
{   

    private Transform player;
    private Transform Moon;
    private Vector3 cameraPosition;

    [SerializeField]
    private float minCamDist = -34;
    [SerializeField]
    private float maxCamDist = 32f;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        Moon = GameObject.FindWithTag("Moon").transform;
        
    }

    // Update is called once per frame
    void LateUpdate()
    {   

        // if (player == null)
        if (!player)
        {
            return;
        }

        cameraPosition = transform.position;
        cameraPosition.x = player.position.x;
        
        if (cameraPosition.x < minCamDist){
            cameraPosition.x = minCamDist;
        }

        if (cameraPosition.x > maxCamDist){
            cameraPosition.x = maxCamDist;
        }

        transform.position = cameraPosition;
        // Moon.position.x = cameraPosition.x;
        Moon.transform.position = new Vector3(cameraPosition.x-7.5f,cameraPosition.y+3.3f,0f);
        
        // Debug.Log(cameraPosition.x);    




        
    }
}
