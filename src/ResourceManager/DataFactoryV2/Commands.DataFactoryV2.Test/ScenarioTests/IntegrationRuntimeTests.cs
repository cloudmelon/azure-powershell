﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.ServiceManagemenet.Common.Models;
using Microsoft.WindowsAzure.Commands.ScenarioTest;
using Xunit;
using Xunit.Abstractions;

namespace Microsoft.Azure.Commands.DataFactoryV2.Test
{
    public class IntegrationRuntimeTests : DataFactoriesScenarioTestsBase
    {
        public IntegrationRuntimeTests(ITestOutputHelper output)
        {
            XunitTracingInterceptor.AddToContext(new XunitTracingInterceptor(output));
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestSelfHosedIntegrationRuntime()
        {
            RunPowerShellTest("Test-SelfHosted-IntegrationRuntime");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestAzureIntegrationRuntime()
        {
            RunPowerShellTest("Test-Azure-IntegrationRuntime");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        public void TestIntegrationRuntimePiping()
        {
            RunPowerShellTest("Test-IntegrationRuntime-Piping");
        }

        [Fact(Skip = "Need service team to re-record test after changes to the ClientRuntime.")]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait("Re-record", "ClientRuntime changes")]
        public void TestSsisAzureIntegrationRuntime()
        {
            RunPowerShellTest("Test-SsisAzure-IntegrationRuntime");
        }
    }
}
