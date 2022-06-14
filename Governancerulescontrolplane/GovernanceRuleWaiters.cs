/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.

using System.Linq;
using Oci.Common.Waiters;
using Oci.GovernancerulescontrolplaneService.Models;
using Oci.GovernancerulescontrolplaneService.Requests;
using Oci.GovernancerulescontrolplaneService.Responses;

namespace Oci.GovernancerulescontrolplaneService
{
    /// <summary>
    /// Contains collection of helper methods to produce Oci.Common.Waiters for different resources of GovernanceRule.
    /// </summary>
    public class GovernanceRuleWaiters
    {
        private readonly GovernanceRuleClient client;

        public  GovernanceRuleWaiters(GovernanceRuleClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetEnforcedGovernanceRuleRequest, GetEnforcedGovernanceRuleResponse> ForEnforcedGovernanceRule(GetEnforcedGovernanceRuleRequest request, params GovernanceRuleLifecycleState[] targetStates)
        {
            return this.ForEnforcedGovernanceRule(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetEnforcedGovernanceRuleRequest, GetEnforcedGovernanceRuleResponse> ForEnforcedGovernanceRule(GetEnforcedGovernanceRuleRequest request, WaiterConfiguration config, params GovernanceRuleLifecycleState[] targetStates)
        {
            var agent = new WaiterAgent<GetEnforcedGovernanceRuleRequest, GetEnforcedGovernanceRuleResponse>(
                request,
                request => client.GetEnforcedGovernanceRule(request),
                response => targetStates.Contains(response.EnforcedGovernanceRule.LifecycleState.Value),
                targetStates.Contains(GovernanceRuleLifecycleState.Deleted)
            );
            return new Waiter<GetEnforcedGovernanceRuleRequest, GetEnforcedGovernanceRuleResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetGovernanceRuleRequest, GetGovernanceRuleResponse> ForGovernanceRule(GetGovernanceRuleRequest request, params GovernanceRuleLifecycleState[] targetStates)
        {
            return this.ForGovernanceRule(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetGovernanceRuleRequest, GetGovernanceRuleResponse> ForGovernanceRule(GetGovernanceRuleRequest request, WaiterConfiguration config, params GovernanceRuleLifecycleState[] targetStates)
        {
            var agent = new WaiterAgent<GetGovernanceRuleRequest, GetGovernanceRuleResponse>(
                request,
                request => client.GetGovernanceRule(request),
                response => targetStates.Contains(response.GovernanceRule.LifecycleState.Value),
                targetStates.Contains(GovernanceRuleLifecycleState.Deleted)
            );
            return new Waiter<GetGovernanceRuleRequest, GetGovernanceRuleResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetInclusionCriterionRequest, GetInclusionCriterionResponse> ForInclusionCriterion(GetInclusionCriterionRequest request, params InclusionCriterion.LifecycleStateEnum[] targetStates)
        {
            return this.ForInclusionCriterion(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetInclusionCriterionRequest, GetInclusionCriterionResponse> ForInclusionCriterion(GetInclusionCriterionRequest request, WaiterConfiguration config, params InclusionCriterion.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetInclusionCriterionRequest, GetInclusionCriterionResponse>(
                request,
                request => client.GetInclusionCriterion(request),
                response => targetStates.Contains(response.InclusionCriterion.LifecycleState.Value),
                targetStates.Contains(InclusionCriterion.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetInclusionCriterionRequest, GetInclusionCriterionResponse>(config, agent);
        }
        /// <summary>
        /// Creates a waiter using default wait configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetTenancyAttachmentRequest, GetTenancyAttachmentResponse> ForTenancyAttachment(GetTenancyAttachmentRequest request, params TenancyAttachment.LifecycleStateEnum[] targetStates)
        {
            return this.ForTenancyAttachment(request, WaiterConfiguration.DefaultWaiterConfiguration, targetStates);
        }

        /// <summary>
        /// Creates a waiter using the provided configuration.
        /// </summary>
        /// <param name="request">Request to send.</param>
        /// <param name="config">Wait Configuration</param>
        /// <param name="targetStates">Desired resource states. If multiple states are provided then the waiter will return once the resource reaches any of the provided states</param>
        /// <returns>a new Oci.common.Waiter instance</returns>
        public Waiter<GetTenancyAttachmentRequest, GetTenancyAttachmentResponse> ForTenancyAttachment(GetTenancyAttachmentRequest request, WaiterConfiguration config, params TenancyAttachment.LifecycleStateEnum[] targetStates)
        {
            var agent = new WaiterAgent<GetTenancyAttachmentRequest, GetTenancyAttachmentResponse>(
                request,
                request => client.GetTenancyAttachment(request),
                response => targetStates.Contains(response.TenancyAttachment.LifecycleState.Value),
                targetStates.Contains(TenancyAttachment.LifecycleStateEnum.Deleted)
            );
            return new Waiter<GetTenancyAttachmentRequest, GetTenancyAttachmentResponse>(config, agent);
        }
    }
}
