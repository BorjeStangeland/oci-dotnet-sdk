/*
 * Copyright (c) 2020, 2022, Oracle and/or its affiliates. All rights reserved.
 * This software is dual-licensed to you under the Universal Permissive License (UPL) 1.0 as shown at https://oss.oracle.com/licenses/upl or Apache License 2.0 as shown at http://www.apache.org/licenses/LICENSE-2.0. You may choose either license.
 */

// NOTE: Code generated by OracleSDKGenerator.
// DO NOT EDIT this file manually.


using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Oci.GoldengateService.Models
{
  /// <summary>
  /// The connection type.
    /// 
  /// </summary>
  public enum ConnectionType {
      /// This value is used if a service returns a value for this enum that is not recognized by this version of the SDK.
      [EnumMember(Value = null)]
      UnknownEnumValue,
      [EnumMember(Value = "GOLDENGATE")]
      Goldengate,
      [EnumMember(Value = "KAFKA")]
      Kafka,
      [EnumMember(Value = "KAFKA_SCHEMA_REGISTRY")]
      KafkaSchemaRegistry,
      [EnumMember(Value = "MYSQL")]
      Mysql,
      [EnumMember(Value = "OCI_OBJECT_STORAGE")]
      OciObjectStorage,
      [EnumMember(Value = "ORACLE")]
      Oracle,
      [EnumMember(Value = "AZURE_DATA_LAKE_STORAGE")]
      AzureDataLakeStorage,
      [EnumMember(Value = "POSTGRESQL")]
      Postgresql,
      [EnumMember(Value = "AZURE_SYNAPSE_ANALYTICS")]
      AzureSynapseAnalytics
  }
}