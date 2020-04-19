﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IUsable
{
    void Use();
    void Destroy();

    bool CanUse();
}
