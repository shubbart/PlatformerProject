﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IDamage
{
    float EstimatedDamageTaken(float damageDealt);
    void TakeDamage(float damageDealt);

}
