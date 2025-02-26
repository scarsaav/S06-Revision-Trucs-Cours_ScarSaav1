using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreationMonnaieBronze : MonoBehaviour
{

    [SerializeField] GameObject _prefabOriginal;


    // Start is called before the first frame update
    void Start()
    {
        Instantiate(_prefabOriginal, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
