using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IHeal
{
    float EstimatedHealingReceived(float healing);
    void TakeHealing(float healing);

}
