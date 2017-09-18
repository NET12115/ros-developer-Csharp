﻿*/
© Siemens AG, 2017
Author: Dr. Martin Bischoff (martin.bischoff@siemens.com)

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

<http://www.apache.org/licenses/LICENSE-2.0>.

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/


using System.Collections.Generic;
using UnityEngine;

public static class JointStatePatcher
{
    public static void patch(GameObject UrdfModel)
    {
        int jointID = 0;
        foreach (Transform child in UrdfModel.GetComponentsInChildren<Transform>())
        {
            if (child.name.Contains("continuous Joint") || child.name.Contains("revolute Joint"))
            {
                JointStateManager jointStateApplyer = child.GetComponent<JointStateManager>();

                if (jointStateApplyer != null)
                    Object.DestroyImmediate(jointStateApplyer);

                jointStateApplyer = child.gameObject.AddComponent<JointStateManager>();
                jointStateApplyer.jointStateId = jointID++;

                Debug.Log("Joint state manager applied to joint: " + child.name);
            }
        }
    }
}