using UnityEngine;
using System;

public interface IFactory
{
    GameObject FactoryMethod(int tag);
}