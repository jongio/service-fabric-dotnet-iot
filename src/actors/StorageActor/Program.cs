﻿// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace StorageActor
{
    using System;
    using System.Threading;
    using Microsoft.ServiceFabric.Actors.Runtime;

    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                ActorRuntime.RegisterActorAsync<StorageActor>().GetAwaiter().GetResult();

                Thread.Sleep(Timeout.Infinite);
            }
            catch (Exception e)
            {
                ActorEventSource.Current.ActorHostInitializationFailed(e);
                throw;
            }
        }
    }
}