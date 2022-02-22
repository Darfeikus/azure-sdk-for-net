// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Script activity type.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Script")]
    [Rest.Serialization.JsonTransformation]
    public partial class ScriptActivity : ExecutionActivity
    {
        /// <summary>
        /// Initializes a new instance of the ScriptActivity class.
        /// </summary>
        public ScriptActivity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ScriptActivity class.
        /// </summary>
        /// <param name="name">Activity name.</param>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="description">Activity description.</param>
        /// <param name="dependsOn">Activity depends on condition.</param>
        /// <param name="userProperties">Activity user properties.</param>
        /// <param name="linkedServiceName">Linked service reference.</param>
        /// <param name="policy">Activity policy.</param>
        /// <param name="scripts">Array of script blocks. Type: array.</param>
        /// <param name="logSettings">Log settings of script activity.</param>
        public ScriptActivity(string name, IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string description = default(string), IList<ActivityDependency> dependsOn = default(IList<ActivityDependency>), IList<UserProperty> userProperties = default(IList<UserProperty>), LinkedServiceReference linkedServiceName = default(LinkedServiceReference), ActivityPolicy policy = default(ActivityPolicy), IList<ScriptActivityScriptBlock> scripts = default(IList<ScriptActivityScriptBlock>), ScriptActivityTypePropertiesLogSettings logSettings = default(ScriptActivityTypePropertiesLogSettings))
            : base(name, additionalProperties, description, dependsOn, userProperties, linkedServiceName, policy)
        {
            Scripts = scripts;
            LogSettings = logSettings;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets array of script blocks. Type: array.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.scripts")]
        public IList<ScriptActivityScriptBlock> Scripts { get; set; }

        /// <summary>
        /// Gets or sets log settings of script activity.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.logSettings")]
        public ScriptActivityTypePropertiesLogSettings LogSettings { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Scripts != null)
            {
                foreach (var element in Scripts)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (LogSettings != null)
            {
                LogSettings.Validate();
            }
        }
    }
}
