/*
 * Goddard.ToursWebApi
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = FranchiseePortal.ToursWebApiClient.Client.OpenAPIDateConverter;

namespace FranchiseePortal.ToursWebApiClient.Model
{
    /// <summary>
    /// Defines TourStatus
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TourStatus
    {
        /// <summary>
        /// Enum Scheduled for value: Scheduled
        /// </summary>
        [EnumMember(Value = "Scheduled")]
        Scheduled = 1,

        /// <summary>
        /// Enum Completed for value: Completed
        /// </summary>
        [EnumMember(Value = "Completed")]
        Completed = 2,

        /// <summary>
        /// Enum NoShow for value: NoShow
        /// </summary>
        [EnumMember(Value = "NoShow")]
        NoShow = 3,

        /// <summary>
        /// Enum Cancelled for value: Cancelled
        /// </summary>
        [EnumMember(Value = "Cancelled")]
        Cancelled = 4

    }

}
