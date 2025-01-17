/*
 * Copyright (c) 2020, 2023, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.DisasterrecoveryService.Models
{
  /// <summary>
  /// Step types in a DR Plan.
    /// 
  /// </summary>
  public enum DrPlanStepType {
      /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
      [EnumMember(Value = null)]
      UnknownEnumValue,
      [EnumMember(Value = "COMPUTE_INSTANCE_STOP_PRECHECK")]
      ComputeInstanceStopPrecheck,
      [EnumMember(Value = "COMPUTE_INSTANCE_LAUNCH_PRECHECK")]
      ComputeInstanceLaunchPrecheck,
      [EnumMember(Value = "COMPUTE_INSTANCE_TERMINATE_PRECHECK")]
      ComputeInstanceTerminatePrecheck,
      [EnumMember(Value = "COMPUTE_INSTANCE_REMOVE_PRECHECK")]
      ComputeInstanceRemovePrecheck,
      [EnumMember(Value = "VOLUME_GROUP_RESTORE_SWITCHOVER_PRECHECK")]
      VolumeGroupRestoreSwitchoverPrecheck,
      [EnumMember(Value = "VOLUME_GROUP_RESTORE_FAILOVER_PRECHECK")]
      VolumeGroupRestoreFailoverPrecheck,
      [EnumMember(Value = "DATABASE_SWITCHOVER_PRECHECK")]
      DatabaseSwitchoverPrecheck,
      [EnumMember(Value = "DATABASE_FAILOVER_PRECHECK")]
      DatabaseFailoverPrecheck,
      [EnumMember(Value = "AUTONOMOUS_DATABASE_SWITCHOVER_PRECHECK")]
      AutonomousDatabaseSwitchoverPrecheck,
      [EnumMember(Value = "AUTONOMOUS_DATABASE_FAILOVER_PRECHECK")]
      AutonomousDatabaseFailoverPrecheck,
      [EnumMember(Value = "USER_DEFINED_PRECHECK")]
      UserDefinedPrecheck,
      [EnumMember(Value = "COMPUTE_INSTANCE_LAUNCH")]
      ComputeInstanceLaunch,
      [EnumMember(Value = "COMPUTE_INSTANCE_STOP")]
      ComputeInstanceStop,
      [EnumMember(Value = "COMPUTE_INSTANCE_TERMINATE")]
      ComputeInstanceTerminate,
      [EnumMember(Value = "COMPUTE_INSTANCE_REMOVE")]
      ComputeInstanceRemove,
      [EnumMember(Value = "DATABASE_SWITCHOVER")]
      DatabaseSwitchover,
      [EnumMember(Value = "DATABASE_FAILOVER")]
      DatabaseFailover,
      [EnumMember(Value = "AUTONOMOUS_DATABASE_SWITCHOVER")]
      AutonomousDatabaseSwitchover,
      [EnumMember(Value = "AUTONOMOUS_DATABASE_FAILOVER")]
      AutonomousDatabaseFailover,
      [EnumMember(Value = "VOLUME_GROUP_RESTORE_SWITCHOVER")]
      VolumeGroupRestoreSwitchover,
      [EnumMember(Value = "VOLUME_GROUP_RESTORE_FAILOVER")]
      VolumeGroupRestoreFailover,
      [EnumMember(Value = "VOLUME_GROUP_REVERSE")]
      VolumeGroupReverse,
      [EnumMember(Value = "VOLUME_GROUP_DELETE")]
      VolumeGroupDelete,
      [EnumMember(Value = "VOLUME_GROUP_REMOVE")]
      VolumeGroupRemove,
      [EnumMember(Value = "VOLUME_GROUP_TERMINATE")]
      VolumeGroupTerminate,
      [EnumMember(Value = "USER_DEFINED")]
      UserDefined
  }
}
