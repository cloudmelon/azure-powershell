// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Internal.Network.Version2017_10_01.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Constraints that determine the list of available Internet service
    /// providers.
    /// </summary>
    public partial class AvailableProvidersListParameters
    {
        /// <summary>
        /// Initializes a new instance of the AvailableProvidersListParameters
        /// class.
        /// </summary>
        public AvailableProvidersListParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AvailableProvidersListParameters
        /// class.
        /// </summary>
        /// <param name="azureLocations">A list of Azure regions.</param>
        /// <param name="country">The country for available providers
        /// list.</param>
        /// <param name="state">The state for available providers list.</param>
        /// <param name="city">The city or town for available providers
        /// list.</param>
        public AvailableProvidersListParameters(IList<string> azureLocations = default(IList<string>), string country = default(string), string state = default(string), string city = default(string))
        {
            AzureLocations = azureLocations;
            Country = country;
            State = state;
            City = city;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a list of Azure regions.
        /// </summary>
        [JsonProperty(PropertyName = "azureLocations")]
        public IList<string> AzureLocations { get; set; }

        /// <summary>
        /// Gets or sets the country for available providers list.
        /// </summary>
        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets the state for available providers list.
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets the city or town for available providers list.
        /// </summary>
        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }

    }
}