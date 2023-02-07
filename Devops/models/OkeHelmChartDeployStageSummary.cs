/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Oci.DevopsService.Models
{
    /// <summary>
    /// Specifies the OKE cluster deployment stage using Helm charts.
    /// </summary>
    public class OkeHelmChartDeployStageSummary : DeployStageSummary
    {
        
        /// <value>
        /// Kubernetes cluster environment OCID for deployment.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "OkeClusterDeployEnvironmentId is required.")]
        [JsonProperty(PropertyName = "okeClusterDeployEnvironmentId")]
        public string OkeClusterDeployEnvironmentId { get; set; }
        
        /// <value>
        /// Helm chart artifact OCID.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "HelmChartDeployArtifactId is required.")]
        [JsonProperty(PropertyName = "helmChartDeployArtifactId")]
        public string HelmChartDeployArtifactId { get; set; }
        
        /// <value>
        /// List of values.yaml file artifact OCIDs.
        /// </value>
        [JsonProperty(PropertyName = "valuesArtifactIds")]
        public System.Collections.Generic.List<string> ValuesArtifactIds { get; set; }
        
        /// <value>
        /// Release name of the Helm chart.
        /// </value>
        /// <remarks>
        /// Required
        /// </remarks>
        [Required(ErrorMessage = "ReleaseName is required.")]
        [JsonProperty(PropertyName = "releaseName")]
        public string ReleaseName { get; set; }
        
        /// <value>
        /// Default namespace to be used for Kubernetes deployment when not specified in the manifest.
        /// </value>
        [JsonProperty(PropertyName = "namespace")]
        public string Namespace { get; set; }
        
        /// <value>
        /// Time to wait for execution of a helm stage. Defaults to 300 seconds.
        /// </value>
        [JsonProperty(PropertyName = "timeoutInSeconds")]
        public System.Nullable<int> TimeoutInSeconds { get; set; }
        
        [JsonProperty(PropertyName = "rollbackPolicy")]
        public DeployStageRollbackPolicy RollbackPolicy { get; set; }
        
        [JsonProperty(PropertyName = "setValues")]
        public HelmSetValueCollection SetValues { get; set; }
        
        [JsonProperty(PropertyName = "setString")]
        public HelmSetValueCollection SetString { get; set; }
        
        /// <value>
        /// Disable pre/post upgrade hooks.
        /// </value>
        [JsonProperty(PropertyName = "areHooksEnabled")]
        public System.Nullable<bool> AreHooksEnabled { get; set; }
        
        /// <value>
        /// During upgrade, reuse the values of the last release and merge overrides from the command line. Set to false by default.
        /// </value>
        [JsonProperty(PropertyName = "shouldReuseValues")]
        public System.Nullable<bool> ShouldReuseValues { get; set; }
        
        /// <value>
        /// During upgrade, reset the values to the ones built into the chart. It overrides shouldReuseValues. Set to false by default.
        /// </value>
        [JsonProperty(PropertyName = "shouldResetValues")]
        public System.Nullable<bool> ShouldResetValues { get; set; }
        
        /// <value>
        /// Force resource update through delete; or if required, recreate. Set to false by default.
        /// </value>
        [JsonProperty(PropertyName = "isForceEnabled")]
        public System.Nullable<bool> IsForceEnabled { get; set; }
        
        /// <value>
        /// Allow deletion of new resources created during when an upgrade fails. Set to false by default.
        /// </value>
        [JsonProperty(PropertyName = "shouldCleanupOnFail")]
        public System.Nullable<bool> ShouldCleanupOnFail { get; set; }
        
        /// <value>
        /// Limit the maximum number of revisions saved per release. Use 0 for no limit. Set to 10 by default
        /// </value>
        [JsonProperty(PropertyName = "maxHistory")]
        public System.Nullable<int> MaxHistory { get; set; }
        
        /// <value>
        /// If set, no CRDs are installed. By default, CRDs are installed only if they are not present already.  Set to false by default.
        /// </value>
        [JsonProperty(PropertyName = "shouldSkipCrds")]
        public System.Nullable<bool> ShouldSkipCrds { get; set; }
        
        /// <value>
        /// If set, renders subchart notes along with the parent. Set to false by default.
        /// </value>
        [JsonProperty(PropertyName = "shouldSkipRenderSubchartNotes")]
        public System.Nullable<bool> ShouldSkipRenderSubchartNotes { get; set; }
        
        /// <value>
        /// Waits until all the resources are in a ready state to mark the release as successful. Set to false by default.
        /// </value>
        [JsonProperty(PropertyName = "shouldNotWait")]
        public System.Nullable<bool> ShouldNotWait { get; set; }
        
        /// <value>
        /// Enables helm --debug option to stream output. Set to false by default.
        /// </value>
        [JsonProperty(PropertyName = "isDebugEnabled")]
        public System.Nullable<bool> IsDebugEnabled { get; set; }
        
        [JsonProperty(PropertyName = "deployStageType")]
        private readonly string deployStageType = "OKE_HELM_CHART_DEPLOYMENT";
    }
}
