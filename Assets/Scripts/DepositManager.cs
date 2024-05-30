using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepositManager : MonoBehaviour
{
    public static bool object1Deposited = false;
    public static bool object2Deposited = false;

    public static bool AreBothObjectsDeposited()
    {
        return object1Deposited && object2Deposited;
    }
}
