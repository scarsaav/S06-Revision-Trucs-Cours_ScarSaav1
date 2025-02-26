using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreationMonnaiesOr : MonoBehaviour
{
    [SerializeField] GameObject _prefabOriginal;
    [SerializeField] Vector3 _positionCreation;

    void Start()
    {
        Quaternion _rotation = Quaternion.Euler(0f, 90f, 0f); //representation de rotation en 3D
        Instantiate(_prefabOriginal, _positionCreation, _rotation); //commande qui va creer le clone (variable qui permet de cloner un gameobject
    }
}
