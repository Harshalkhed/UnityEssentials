using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudsController : MonoBehaviour
{
    [SerializeField]
    private Transform _clouds;
    [SerializeField]
    private Transform[] _allchildren;

    // Start is called before the first frame update
    void Start()
    {
        _allchildren= new Transform[_clouds.transform.childCount];

        for(int i = 0; i<_allchildren.Length;i++)
        {
            _allchildren[i] = _clouds.GetChild(i);
        }

    }

    // Update is called once per frame
    void Update()
    {
        for( int i=0; i<_allchildren.Length;i++)
        {
            _allchildren[i].position = _allchildren[i].position + Vector3.right * Time.deltaTime;
        }
       
        
    }
}
