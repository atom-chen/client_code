﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameFramework
{
    public class LoadingUI : Baselayer, IBgLayerUI
    {
       virtual public bool showBG
        {
            get { return false; }
        }

        override public float type
        {
            get
            {
                return LAYER_TYPE_LOADING;
            }
        }
    }
}
